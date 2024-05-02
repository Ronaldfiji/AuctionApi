using DataModel.Entity.AuctionEntity;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.AutionsDto;
using SharedModel.Dtos;


namespace Repository.Repository.Auction.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<ProductDto> GetById(int id);
        Task<PagedList<ProductDto>> GetProducts(PagingRequestDto pagingRequestDto);
        Task<VirtualizeResponse<ProductDto>> GetAllProducts(ItemRequestDto itemRequestDto);
        Task<PagedList<ProductDto>> GetProductsFiltered(PagingRequestDto pagingRequestDto);
        Task<ProductDto> CreateProduct(ProductDto productDto);
        Task<ProductDto> UpdateProduct(ProductDto productDto);
        Task<ProductDto?> DeleteProduct(int id);
        Task<bool> DeleteProducts(List<ProductDto> productDtos);
        Task<ServiceResponse<ProductPicturesDto>> DeleteProductPicture(int id);
        Task SeedingProductPicturesDataTable();
    }
}
