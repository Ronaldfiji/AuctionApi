using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository.Auction;
using Repository.Repository.Auction.Contracts;
using Repository.Repository.Jobs;
using Repository.Repository.Jobs.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;
using SharedModel.JobsDto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.JobPost
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostController : ControllerBase
    {
   
        private readonly IJobPostRepository jobPostRepository;
        private ILogger<JobPostController> logger;

        public JobPostController(IJobPostRepository _jobPostRepository, ILogger<JobPostController> _logger)
        {
           jobPostRepository = _jobPostRepository;
            logger = _logger;
        }

        // GET api/<JobPostController>GetJobPost/5
        [AllowAnonymous]
        [HttpGet("GetJobPost/{id:int}")]
        public async Task<ActionResult> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var jobPostDto = await jobPostRepository.GetById(id);

                if (jobPostDto == null)
                {
                    return NotFound();
                }
                return Ok(jobPostDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<JobPostController/GetJobPosts>
        [AllowAnonymous]
        [HttpGet("GetJobPosts")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                //pagingRequestDto.RedisCacheExpiry = 30;
                var jobPostDtos = await jobPostRepository.GetJobPosts(pagingRequestDto);

                if (jobPostDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<JobPostDto>
                {
                    Items = jobPostDtos.ToList(),
                    MetaData = jobPostDtos.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
          }

        /* To pass dictionary data in api call -> https://localhost/api/JobPost/GetJobPostFiltered?FilterList[code]=cat0006&FilterList[name]=real%20estate */
        // GET: api/<Controller/GetJobPostFiltered>
        [AllowAnonymous]
        [HttpGet("GetJobPostFiltered")]
        public async Task<ActionResult> GetJobPostFiltered([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var productDtos = await this.jobPostRepository.GetJobPostsFiltered(pagingRequestDto);

                if (productDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<JobPostDto>
                {
                    Items = productDtos.ToList(),
                    MetaData = productDtos.MetaData,
                };

                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // POST: api/<JobPostController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult> PostItem([FromBody] JobPostDto jobPostDto)
        {
            try
            {
                if (jobPostDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(jobPostDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    jobPostDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var jobExist = await jobPostRepository.Find(d => d.JobTitle.ToLower() == jobPostDto.JobTitle.ToLower()
                && d.OrganisationID == jobPostDto.OrganisationID &&
                d.CreatedDate >= DateTime.Today && d.CreatedDate < DateTime.Today.AddDays(1));

                if (jobExist != null && jobExist.Any())
                {
                    ModelState.AddModelError("Job Posts ", "Job post already exist in database !");
                    return StatusCode(StatusCodes.Status409Conflict, $"Job post exist in database : {jobPostDto.JobTitle} .You may update job summary !");
                }

                var newJobPost = await jobPostRepository.CreateJobPost(jobPostDto);

                if (newJobPost == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newJobPost?.Id})");
                }

                return CreatedAtAction(nameof(GetItem), new { id = newJobPost.Id }, newJobPost);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key row in object") || ex.Message.Contains("UNIQUE constraint failed") ||
                    ex.Message.Contains("FOREIGN KEY constraint failed"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //PATCH: api/JobPostController/UpdateJobPost{int id, JobPostDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateJobPost(int id, [FromBody] JobPostDto jobPostDto)
        {
            try
            {
                if (jobPostDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(jobPostDto)} cannot be null or empty !");
                }

                if (id != jobPostDto.Id)
                    return BadRequest("Item ID mismatch !");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    jobPostDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                jobPostDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedJobPost = await jobPostRepository.UpdateJobPost(jobPostDto);

                if (updatedJobPost == null)
                {
                    return NotFound(updatedJobPost);
                }
                return Ok(updatedJobPost);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key row in object") || ex.Message.Contains("UNIQUE constraint failed") ||
                  ex.Message.Contains("FOREIGN KEY constraint failed"))               
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


        // DELETE api/<JobPostController>/Delete/5     
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await jobPostRepository.DeleteJobPost(id);

                if (deletedItem == null)
                {
                    return NotFound($"Failed to delete object {nameof(JobPostDto)} with id : {id}");
                }

                return Ok(deletedItem); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Delete: api/JobPostController/Delete/List<JobPostDto>
        [HttpPost("DeleteItems")]
        public async Task<ActionResult> DeleteJobPosts([FromBody] IEnumerable<JobPostDto> jobPostDtos)
        {
            try
            {

                if (jobPostDtos == null || !jobPostDtos.Any() || !ModelState.IsValid)
                {
                    return BadRequest($"Entity to delete {nameof(jobPostDtos)} cannot be null or empty !");
                }

                foreach (var jobPost in jobPostDtos)
                {
                    var itemExist = await jobPostRepository.GetById(jobPost.Id);
                    if (itemExist == null)
                    {
                        return NotFound($"Item to be deleted does not exist with id :  {jobPost.Id}");
                    }
                }

                var deleteStatus = await jobPostRepository.DeleteJobPosts(jobPostDtos.ToList());

                if (deleteStatus == false)
                {
                    return NotFound();
                }

                return Ok(new { message = "Records deleted successfully", StatusCode = 200, Status = deleteStatus });
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("modified or deleted"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
