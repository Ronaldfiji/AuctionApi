using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Repository.Contracts;
using SharedModel.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypesController : ControllerBase
    {
        private readonly IUserTypesRepository userTypesRepository;

        public UserTypesController(IUserTypesRepository _userTypesRepository)
        {
            userTypesRepository = _userTypesRepository;
        }


        
        // GET api/<DesignationController>GetDesignation/5
        //[Authorize(Roles = "HOD")]
        [HttpGet("GetUserType/{id:int}")]
        public async Task<ActionResult> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var userDto = await this.userTypesRepository.GetUserType(id);

                if (userDto == null)
                {
                    return NotFound();
                }

                return Ok(userDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<UserTypesController/GetUserTypes>
        [HttpGet("GetUserTypes")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
                //pagingRequestDto.RedisCacheExpiry = 30;
                var userTypesDto = await userTypesRepository.GetUserTypes(pagingRequestDto);

                if (userTypesDto == null)
                {
                    return NotFound();
                }

                var pagedResponse = new PagingResponse<UserTypeDto>
                {
                    Items = userTypesDto.ToList(),
                    MetaData = userTypesDto.MetaData,
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
