using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository.Auction.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PayApi.Controllers.Auction
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private ILogger<ProductController> logger;

        public ProductController(IProductRepository _productRepository, ILogger<ProductController> _logger)
        {
            productRepository= _productRepository;
            logger = _logger;
        }

        // GET api/<ProductController>GetProduct/5
        [AllowAnonymous]
        [HttpGet("GetProduct/{id:int}")]
        public async Task<ActionResult> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var productDto = await productRepository.GetById(id);

                if (productDto == null)
                {
                    return NotFound();
                }
                return Ok(productDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<ProductController/GetProducts>
        [AllowAnonymous]
        [HttpGet("GetProducts")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {               
                var productDtos = await productRepository.GetProducts(pagingRequestDto);

                if (productDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<ProductDto>
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

        /* To pass dictionary data in api call -> https://localhost/api/Category/GetProductsFiltered?FilterList[code]=cat0006&FilterList[name]=real%20estate */
        // GET: api/<Controller/GetProductsFiltered>
        [AllowAnonymous]
        [HttpGet("GetProductsFiltered")]
        public async Task<ActionResult> GetProductsFiltered([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var productDtos = await this.productRepository.GetProductsFiltered(pagingRequestDto);

                if (productDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<ProductDto>
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

        // POST: api/<ProductController/Create>        
        [HttpPost("Create")]
        public async Task<ActionResult> PostItem([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(productDto)} cannot be null or empty !");
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    productDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var product = await productRepository.Find(d => d.Name.ToLower() == productDto.Name.ToLower());
                if (product != null && product.Any())
                {
                    ModelState.AddModelError("Product name", "Product already exist in database !");
                    return StatusCode(StatusCodes.Status409Conflict, $"Product exist in database : {productDto.Name} . Provide different product name !");
                }
                var newProduct = await this.productRepository.CreateProduct(productDto);

                if (newProduct == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newProduct?.Id})");
                }

                return CreatedAtAction(nameof(GetItem), new { id = newProduct.Id }, newProduct);
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


        //PATCH: api/ProductController/UpdateProduct{int id, productDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(productDto)} cannot be null or empty !");
                }

                if (id != productDto.Id)
                    return BadRequest("Item ID mismatch !");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    productDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                productDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedProduct = await productRepository.UpdateProduct(productDto);

                if (updatedProduct == null)
                {
                    return NotFound(updatedProduct);
                }
                return Ok(updatedProduct);
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


        // DELETE api/<ProductController>/Delete/5     
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await productRepository.DeleteProduct(id);

                if (deletedItem == null)
                {
                    return NotFound($"Failed to delete object {nameof(ProductDto)} with id : {id}");
                }

                return Ok(deletedItem); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Delete: api/ProductController/Delete/List<productDto>
        [HttpPost("DeleteItems")]
        public async Task<ActionResult> DeleteProducts([FromBody] IEnumerable<ProductDto> productDtos)
        {
            try
            {

                if (productDtos == null || !productDtos.Any() || !ModelState.IsValid)
                {
                    return BadRequest($"Entity to delete {nameof(productDtos)} cannot be null or empty !");
                }

                foreach (var product in productDtos)
                {
                    var itemExist = await productRepository.GetById(product.Id);
                    if (itemExist == null)
                    {
                        return NotFound($"Item to be deleted does not exist with id :  {product.Id}");
                    }
                }

                var deleteStatus = await productRepository.DeleteProducts(productDtos.ToList());

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


        // Delete: api/ProductController/DeleteItemPicture/1
        [HttpDelete("DeleteProductPicture/{id:int}")]
        public async Task<ActionResult> DeleteImage(int id)
        {
            try
            {
                var deleteStatus = await productRepository.DeleteProductPicture(id);
                if (deleteStatus.StatusCode == 404)
                {
                    return NotFound();
                }
                if (deleteStatus.StatusCode == 200)
                {                   
                    return Ok(deleteStatus);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to delete item. Review error logs");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

       

    }
}
