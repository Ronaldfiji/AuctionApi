using DataModel.Entity.AuctionEntity;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.AutionsDto;
using SharedModel.Dtos;


namespace Repository.Repository.Auction.Contracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<CategoryDto> GetById(int id);
        Task<PagedList<CategoryDto>> GetCategories(PagingRequestDto pagingRequestDto);
        Task<PagedList<CategoryDto>> GetCategoriesFiltered(PagingRequestDto pagingRequestDto);
        Task<VirtualizeResponse<CategoryDto>> GetAllDesignations(ItemRequestDto itemRequestDto);
        Task<CategoryDto> CreateCategory(CategoryDto categoryDto);
        Task<CategoryDto> UpdateCategory(CategoryDto categoryDto);
        Task<CategoryDto?> DeleteCategory(int id);
        Task<bool> DeleteCategories(List<CategoryDto> categoryListDtos);

    }
}
