using DataModel.Entity;
using Repository.Extention;
using SharedModel.Dtos;

namespace Repository.Contracts
{
    public interface IRoleRepository
    {
        Task<Role> Get(int id);
        Task<PagedList<Role>> GetAllRoles(PagingRequestDto pagingRequestDto);
        Task<List<Role>> GetAll();
        Task<Role> CreateRole(RoleToAddEditDto roleToAdd);
        Task<Role> UpdateRole(int id, RoleToAddEditDto roleToAddEdit);
        Task<Role> DeleteRole(int id);
        Task<Role> GetRoleByName(string name);
    }
}
