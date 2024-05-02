using Microsoft.AspNetCore.Mvc;
using Repository.Repository.Auction.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PayApi.Controllers.Auction
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        private ILogger<CategoryController> logger;

        public CategoryController(ICategoryRepository _categoryRepository, ILogger<CategoryController> _logger)
        {
             categoryRepository = _categoryRepository;  
            logger = _logger;
        }

        // GET api/<CategoryController>GetCategory/5
        [HttpGet("GetCategory/{id:int}")]
        public async Task<ActionResult> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var categoryDto = await categoryRepository.GetById(id);

                if (categoryDto == null)
                {
                    return NotFound();
                }
                return Ok(categoryDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<CategoryController/GetCategories>
        [HttpGet("GetCategories")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                //pagingRequestDto.RedisCacheExpiry = 30;
                var categoriesDtos = await this.categoryRepository.GetCategories(pagingRequestDto);

                if (categoriesDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<CategoryDto>
                {
                    Items = categoriesDtos.ToList(),
                    MetaData = categoriesDtos.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        /* To pass dictionary data in api call -> https://localhost/api/Category/GetCategoriesFiltered?FilterList[code]=cat0006&FilterList[name]=real%20estate */
        // GET: api/<CategoryController/GetCategoriesFiltered>
        [HttpGet("GetCategoriesFiltered")]
        public async Task<ActionResult> GetCategoriesFiltered([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var categoryDtos = await this.categoryRepository.GetCategoriesFiltered(pagingRequestDto);

                if (categoryDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<CategoryDto>
                {
                    Items = categoryDtos.ToList(),
                    MetaData = categoryDtos.MetaData,
                };

                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // POST: api/<CategoryController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult> PostItem([FromBody] CategoryDto categoryDto)
        {
            try
            {
                if (categoryDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(categoryDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    categoryDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var category = await categoryRepository.Find(d => d.Code.ToLower() == categoryDto.Code.ToLower());
                if (category != null && category.Any())
                {
                    ModelState.AddModelError("Job title", "Category already exist in database !");
                    return StatusCode(StatusCodes.Status409Conflict, $"Category exist in database : {categoryDto.Code} . Provide different category code !");
                }
                var newCategory = await this.categoryRepository.CreateCategory(categoryDto);

                if (newCategory == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newCategory?.Id})");
                }

                return CreatedAtAction(nameof(GetItem), new { id = newCategory.Id }, newCategory);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key row in object"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        //PATCH: api/CategoryController/UpdateCategory{int id, categoryDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateCategory(int id, [FromBody] CategoryDto categoryDto)
        {
            try
            {
                if (categoryDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(categoryDto)} cannot be null or empty !");
                }

                if (id != categoryDto.Id)
                    return BadRequest("Category ID mismatch !");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    categoryDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                categoryDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedCategory = await this.categoryRepository.UpdateCategory(categoryDto);

                if (updatedCategory == null)
                {
                    return NotFound();
                }                           
                return Ok(updatedCategory);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key row in object"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // DELETE api/<CategoryController>/Delete/5     
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await categoryRepository.DeleteCategory(id);

                if (deletedItem == null)
                {
                    return NotFound($"Failed to delete object {nameof(CategoryDto)} with id : {id}");
                }

                return Ok(deletedItem); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Delete: api/CategoryController/Delete/List<categoryDto>
        [HttpPost("DeleteItems")]
        public async Task<ActionResult> DeleteCategories([FromBody] IEnumerable<CategoryDto> categoryDtos)
        {
            try
            {

                if (categoryDtos == null || !categoryDtos.Any() || !ModelState.IsValid)
                {
                    return BadRequest($"Entity to delete {nameof(categoryDtos)} cannot be null or empty !");
                }

                foreach (var category in categoryDtos)
                {
                    var itemExist = await categoryRepository.GetById(category.Id);
                    if (itemExist == null)
                    {
                        return NotFound($"Item to be deleted does not exist with id :  {category.Id}");
                    }
                }

                var deleteStatus = await categoryRepository.DeleteCategories(categoryDtos.ToList());

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
