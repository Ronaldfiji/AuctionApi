using DataModel.DB;
using DataModel.Entity;
using DataModel.Entity.AuctionEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Extention;
using Repository.Extention.AuctionDtoConversion;

using SharedModel.AutionsDto;
using SharedModel.Dtos;
using System.Linq.Expressions;


namespace Repository.Repository.DWH
{
    public class AuctionDwhRepository : IAuctionDwhRepository
    {

        public readonly AuctionDBContext payrollDBContext;
        public readonly ILogger<AuctionDwhRepository> logger;

        public AuctionDwhRepository(AuctionDBContext _payrollDBContext, ILogger<AuctionDwhRepository> _logger)
        {
            payrollDBContext = _payrollDBContext;
            logger = _logger;
        }

        public async Task<PagedList<ProductDto>> GetProducts(PagingRequestDto pagingRequestDto)
        {
            try
            {

                IQueryable<Product> productsQuery = from d in payrollDBContext.Product.Include(p => p.ProductPictures) select d;
                int ItemCount = await productsQuery.CountAsync();

                if(pagingRequestDto.PageNumber == 0)
                {
                    var allProductsDtos = productsQuery.ConvertToDto();
                    return PagedList<ProductDto>.ToPagedList(allProductsDtos, ItemCount, pagingRequestDto.PageNumber,
                    pagingRequestDto.PageSize);
                }

                productsQuery = productsQuery.SearchProduct(pagingRequestDto);

                if (string.Equals(pagingRequestDto.SortOrder?.Trim(), "desc", StringComparison.OrdinalIgnoreCase))
                {
                    productsQuery = productsQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderByDescending(GetSortProperty(pagingRequestDto));

                }
                else
                {
                    productsQuery = productsQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderBy(GetSortProperty(pagingRequestDto));
                }

                //var designationDtos = (from d in designationsQuery select new DesignationDto() {}).ToListAsync();

                var productsDtos = productsQuery.ConvertToDto();

                return PagedList<ProductDto>.ToPagedList(productsDtos, ItemCount, pagingRequestDto.PageNumber,
                    pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "{Repo} GetProducts() method error", typeof(AuctionDwhRepository));
                throw new Exception($"GetProducts() method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<UserDto>> GetUsers(PagingRequestDto pagingRequestDto)
        {
            try
            {

                IQueryable<User> usersQuery = from d in payrollDBContext.User select d;
                int ItemCount = await usersQuery.CountAsync();

                if (pagingRequestDto.PageNumber == 0)
                {
                    var allUsersDtos = usersQuery.ConvertToDto();
                    return PagedList<UserDto>.ToPagedList(allUsersDtos, ItemCount, pagingRequestDto.PageNumber,
                    pagingRequestDto.PageSize);
                }

                usersQuery = usersQuery.SearchUser(pagingRequestDto);

                if (string.Equals(pagingRequestDto.SortOrder?.Trim(), "desc", StringComparison.OrdinalIgnoreCase))
                {
                    usersQuery = usersQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderByDescending(GetSortPropertyUsers(pagingRequestDto));

                }
                else
                {
                    usersQuery = usersQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderBy(GetSortPropertyUsers(pagingRequestDto));
                }

                //var designationDtos = (from d in designationsQuery select new DesignationDto() {}).ToListAsync();

                var usersDtos = usersQuery.ConvertToDto();

                return PagedList<UserDto>.ToPagedList(usersDtos, ItemCount, pagingRequestDto.PageNumber,
                    pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "{Repo} GetUsers() method error", typeof(AuctionDwhRepository));
                throw new Exception($"GetUsers() method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }


        private static Expression<Func<Product, object>>
         GetSortProperty(PagingRequestDto request) => request.SortColumn?.ToLower() switch
         {
             "name" => desig => desig.Name,
             "unitprice" => desig => desig.UnitPrice,
             "address" => desig => desig.Address,
             "description" => desig => desig.Description,
             "createddate" => desig => desig.CreatedDate,
             "ipaddress" => desig => desig.IPAddress,
             _ => desig => desig.ID

         };

        private static Expression<Func<User, object>>
        GetSortPropertyUsers(PagingRequestDto request) => request.SortColumn?.ToLower() switch
        {
            "firstname" => user => user.FirstName,
            "lastname" => user => user.LastName,
            "email" => user => user.Email,
            "city" => user => user.City,
            "createddate" => user => user.CreatedDate ?? new DateTime(),
            "ipaddress" => user => user.IPAddress ?? "",
            _ => user => user.ID

        };

    }
}
 