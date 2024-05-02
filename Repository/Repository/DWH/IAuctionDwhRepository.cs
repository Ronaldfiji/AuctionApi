using Repository.Extention;
using SharedModel.AutionsDto;
using SharedModel.Dtos;


namespace Repository.Repository.DWH
{
    public interface IAuctionDwhRepository
    {
        Task<PagedList<ProductDto>> GetProducts(PagingRequestDto pagingRequestDto);
        Task<PagedList<UserDto>> GetUsers(PagingRequestDto pagingRequestDto);
    }

}
