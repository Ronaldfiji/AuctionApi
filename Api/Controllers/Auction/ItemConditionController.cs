using Microsoft.AspNetCore.Mvc;
using Repository.Repository.Auction.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PayApi.Controllers.Auction
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemConditionController : ControllerBase
    {
        private readonly IItemConditionRepository itemConditionRepository;
        private ILogger<ItemConditionController> logger;

        public ItemConditionController(IItemConditionRepository _itemConditionRepository, ILogger<ItemConditionController> _logger)
        {
            itemConditionRepository = _itemConditionRepository; 
            logger = _logger;
        }

        // GET api/<ItemConditionController>GetItemCondition/5
        [HttpGet("GetItemCondition/{id:int}")]
        public async Task<ActionResult> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var itemConditionDto = await itemConditionRepository.GetById(id);

                if (itemConditionDto == null)
                {
                    return NotFound();
                }
                return Ok(itemConditionDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<ItemConditionController/GetItemConditions>
        [HttpGet("GetItemConditions")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                //pagingRequestDto.RedisCacheExpiry = 30;
                var itemConditionDtos = await itemConditionRepository.GetItemConditions(pagingRequestDto);

                if (itemConditionDtos == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<ItemConditionDto>
                {
                    Items = itemConditionDtos.ToList(),
                    MetaData = itemConditionDtos.MetaData,
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
