using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository.DWH;
using SharedModel.AutionsDto;
using SharedModel.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.Auction
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionDwhController : ControllerBase
    {
        private ILogger<AuctionDwhController> logger;
        private IAuctionDwhRepository auctionDwhRepository;

        public AuctionDwhController(ILogger<AuctionDwhController> logger, IAuctionDwhRepository _auctionDwhRepository)
        {
            this.logger = logger;
            auctionDwhRepository = _auctionDwhRepository;
        }

        // GET: api/<AuctionDwhController/GetProducts>
        [HttpGet("GetProducts")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var productDtos = await auctionDwhRepository.GetProducts(pagingRequestDto);

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

        // GET: api/<AuctionDwhController/GetUserss>       
        [HttpGet("GetUsers")]
        public async Task<ActionResult> GetUsers([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                var usersDtos = await auctionDwhRepository.GetUsers(pagingRequestDto);

                if (usersDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<UserDto>
                {
                    Items = usersDtos.ToList(),
                    MetaData = usersDtos.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

    }
}
