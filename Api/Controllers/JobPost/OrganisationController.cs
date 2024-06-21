using Microsoft.AspNetCore.Mvc;
using Repository.Repository.Jobs.Contracts;
using SharedModel.Dtos;
using SharedModel.JobsDto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.JobPost
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        private readonly IOrganisationRepository organisationRepository;
        private ILogger<OrganisationController> logger;

        public OrganisationController(IOrganisationRepository _organisationRepository, ILogger<OrganisationController> _logger)
        {
            organisationRepository = _organisationRepository;
            logger = _logger;
        }

        // GET api/<OrganisationController>GetOrganisation/5
        [HttpGet("GetOrganisation/{id:int}")]
        public async Task<ActionResult> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var organisationDto = await organisationRepository.GetById(id);

                if (organisationDto == null)
                {
                    return NotFound();
                }
                return Ok(organisationDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<OrganisationController/GetOrganisations>
        [HttpGet("GetOrganisations")]
        public async Task<ActionResult> Get()        
        {
            try
            {
                var organisationDtos = await organisationRepository.GetOrganisations();

                if (organisationDtos == null)
                {
                    return NotFound();
                }

            
                return Ok(organisationDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // POST: api/<OrganisationController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult> PostItem([FromBody] OrganisationDto organisationDto)
        {
            try
            {
                if (organisationDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(organisationDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    organisationDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var organisation = await organisationRepository.Find(d => d.Name.ToLower() == organisationDto.Name.ToLower());
                if (organisation != null && organisation.Any())
                {
                    ModelState.AddModelError("Organisation name", "Organisation already exist in database !");
                    return StatusCode(StatusCodes.Status409Conflict, $"Organisation exist in database : {organisationDto.Name} . Provide different organisation name !");
                }

                var newOrganisation = await this.organisationRepository.CreateOrganisation(organisationDto);

                if (newOrganisation == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newOrganisation?.Id})");
                }

                return CreatedAtAction(nameof(GetItem), new { id = newOrganisation.Id }, newOrganisation);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key row in object") || ex.Message.Contains("UNIQUE constraint failed"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // Delete: OrganisationController/Delete/5        
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<UserDto>> DeleteItem(int id)
        {
            try
            {
                var deletedObject = await organisationRepository.DeleteOrganisation(id);

                if (deletedObject == null)
                {
                    return NotFound();
                }             

                return Ok(deletedObject); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
