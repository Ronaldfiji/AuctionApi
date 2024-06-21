using AutoMapper;
using DataModel.Entity.AuctionEntity;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.AutionsDto;
using SharedModel.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository roleRepository;
        private ILogger<RoleController> logger;
    

        public RoleController(IRoleRepository _roleRepository, ILogger<RoleController> _logger)
        {
            roleRepository = _roleRepository;          
            logger = _logger;
        }

        // GET api/<RoleController>/5
        [HttpGet("GetUser/{id:int}")]
        public async Task<ActionResult<RoleDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var role = await this.roleRepository.GetById(id);

                if (role == null)
                {
                    return NotFound();                }
              
                return Ok(role);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<RoleController/GetRoles>
        [HttpGet("GetRoles")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {

            try
            {
                var pagedRoles = await this.roleRepository.GetAllRoles(pagingRequestDto);

                if (pagedRoles == null)
                {
                    return NotFound();
                }
                var pagedResponse = new PagingResponse<RoleDto>
                {
                    Items = pagedRoles.ToList(),
                    MetaData = pagedRoles.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: api/<RoleController/Create>
        [HttpPost("Create")]
        public async Task<ActionResult<RoleDto>> PostItem([FromBody] RoleToAddEditDto roleToAddEditDto)
        {
            try
            {
                if (roleToAddEditDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(UserToAddDto)} cannot be null or empty !");
                }
                //Check if same item exist in db.

                var role = await roleRepository.GetRoleByName(roleToAddEditDto.Name);
                if (role != null)
                {
                    ModelState.AddModelError("email", "Role exist in database, provide different name !");
                    return BadRequest(ModelState);
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    roleToAddEditDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var newRole = await this.roleRepository.CreateRole(roleToAddEditDto);

                if (newRole == null)
                {
                    throw new Exception($"Something went wrong when attempting to create object (Item: ({newRole?.Id})");
                }
               
                return CreatedAtAction(nameof(GetItem), new { id = newRole.Id }, newRole);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        //[HttpPatch("Update/{id:int, roleToEditDto}")]        
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult> UpdateRole(int id, [FromBody] RoleToAddEditDto roleToAddEdit)
        {
            try
            {
                if (roleToAddEdit == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(RoleToAddEditDto)} cannot be null or empty !");
                }

                if (id != roleToAddEdit.Id)
                    return BadRequest("Role profile ID mismatch");

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    roleToAddEdit.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                roleToAddEdit.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedRole = await this.roleRepository.UpdateRole(id, roleToAddEdit);
                if (updatedRole == null)
                {
                    return NotFound();
                }       
                return Ok(updatedRole);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


        // Delete: RoleController/Delete/5

        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<RoleDto>> DeleteItem(int id)
        {
            try
            {
                var deletedRole = await roleRepository.DeleteRole(id);

                if (deletedRole == null)
                {
                    return NotFound();
                }
                return Ok(deletedRole); // or ' return NoContent();'
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
