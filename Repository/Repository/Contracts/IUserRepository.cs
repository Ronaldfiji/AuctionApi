using DataModel.Entity;
using Repository.Extention;
using SharedModel.Dtos;


namespace Repository.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<UserDto?> GetById(int id);
        Task<PagedList<UserDto>> GetAllUsers(PagingRequestDto pagingRequestDto);
      
        Task<UserDto> CreateUser(UserToAddDto userDto);
        Task<UserDto> UpdateUser(int id, UserToEditDto userToEditDto);
        Task<UserDto> UpdateUserWithStatus(int id, UserToEditDto userToEditDto);
        Task<UserDto> UpdateUserWithRoles(int id, UserToEditDto userToEditDto);
        Task<UserDto> DeleteUser(int id);
        Task<UserDto?> GetUserByEmail(string email);
        Task<ServiceResponse<UserDto>> AssignRole(int userId, List<UserRoleDto> userRoleList);
    }
}
