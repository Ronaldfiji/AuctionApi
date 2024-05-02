using DataModel.Entity;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.Dtos;

namespace Repository.Repository.Contracts
{
    public interface IUserTypesRepository : IGenericRepository<UserType>
    {
        Task<UserTypeDto?> GetUserType(int id);
        Task<PagedList<UserTypeDto>> GetUserTypes(PagingRequestDto pagingRequestDto);
    }
}
