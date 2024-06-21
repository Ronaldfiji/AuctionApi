using DataModel.Entity;
using Repository.Extention;
using SharedModel.Dtos;

namespace Repository.Contracts
{
    public interface IRoleRepository
    {
        Task<RoleDto> GetById(int id);
        Task<PagedList<RoleDto>> GetAllRoles(PagingRequestDto pagingRequestDto);
        Task<List<RoleDto>> GetAll();
        Task<RoleDto> CreateRole(RoleToAddEditDto roleToAdd);
        Task<RoleDto> UpdateRole(int id, RoleToAddEditDto roleToAddEdit);
        Task<RoleDto> DeleteRole(int id);
        Task<RoleDto> GetRoleByName(string name);
    }
}
