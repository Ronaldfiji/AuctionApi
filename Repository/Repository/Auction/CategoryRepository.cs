using DataModel.DB;
using DataModel.Entity.AuctionEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Repository.Extention;
using Repository.Repository.Auction.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;
using System.Linq.Expressions;
using ConfigurationManager = Repository.Util.ConfigurationManager;

namespace Repository.Repository.Auction
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ICacheService cacheService;
        public CategoryRepository(AuctionDBContext context, ICacheService cacheService, ILogger<CategoryRepository> logger) : base(context, logger)
        {
            this.cacheService = cacheService;
        }

        public async Task<CategoryDto> GetById(int id)
        {
            try
            {
                var itemInRedisCache = cacheService.GetData<CategoryDto>($"categoryDto_{id}");

                if (itemInRedisCache != null && itemInRedisCache.Id > 0)
                {
                    return itemInRedisCache;
                }
                var category = await _context.Category
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(s => s.ID == id);

                var categoryDto = Mapping.Mapper.Map<CategoryDto>(category);

                if (categoryDto != null)
                {
                    var redisCacheExp = ConfigurationManager.AppSetting["CacheSettings:RedisCachingExpiry"];
                    var expiryTime = DateTimeOffset.Now.AddSeconds(Convert.ToDouble(redisCacheExp));
                    cacheService.SetData<CategoryDto>($"categoryDto_{id}", categoryDto, expiryTime);
                }

                return categoryDto!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(CategoryRepository));
                throw new Exception($"Failed to find item with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<CategoryDto>> GetCategories(PagingRequestDto pagingRequestDto)
        {
            try
            {
                /*
                var redisCache = cacheService.GetData<IEnumerable<DesignationDto>>($"designationDto_pg{pagingRequestDto.PageNumber}");
                var totalRows = cacheService.GetData<int>($"TotalItems{typeof(Designation).Name}");

                if (redisCache != null && redisCache.ToList().Count() > 0 &&
                    redisCache?.ToList()?.Count() == pagingRequestDto.PageSize &&
                    string.IsNullOrEmpty(pagingRequestDto.ColumnName) && string.IsNullOrEmpty(pagingRequestDto.SearchTerm))
                {
                    return PagedList<DesignationDto>.ToPagedList(redisCache, totalRows, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);
                }*/

                var categories = await _context.Category
                                    .SearchCategory(pagingRequestDto)
                                    .AsNoTracking()
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();

                int ItemCount = await _context.Category.CountAsync();

                var categoryDtos = Mapping.Mapper.Map<List<CategoryDto>>(categories);

                var redisCacheExp = ConfigurationManager.AppSetting["CacheSettings:RedisCacheExpiryPaging"];

                var expiryTime = DateTimeOffset.Now.AddSeconds(Convert.ToDouble(redisCacheExp));

                cacheService.SetData<IEnumerable<CategoryDto>>($"categoryDto_pg{pagingRequestDto.PageNumber}", categoryDtos, expiryTime);
                cacheService.SetData<int>($"TotalItems{typeof(Category).Name}", ItemCount, expiryTime);

                return PagedList<CategoryDto>.ToPagedList(categoryDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetCategories() method error", typeof(CategoryRepository));
                throw new Exception($"GetCategories menthod() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<CategoryDto>> GetCategoriesFiltered(PagingRequestDto pagingRequestDto)
        {
            try
            {
                IQueryable<Category> categoriesQuery = from d in _context.Category select d;
                int ItemCount = await categoriesQuery.CountAsync();

                categoriesQuery = categoriesQuery.SearchCategory(pagingRequestDto);

                if (string.Equals(pagingRequestDto.SortOrder?.Trim(), "desc", StringComparison.OrdinalIgnoreCase))
                {
                    categoriesQuery = categoriesQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderByDescending(GetSortProperty(pagingRequestDto));

                }
                else
                {
                    categoriesQuery = categoriesQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderBy(GetSortProperty(pagingRequestDto));
                }

                //var designationDtos = (from d in designationsQuery select new DesignationDto() {}).ToListAsync();


                var categoriesDtos = await categoriesQuery.Select(d => new CategoryDto
                {
                    Id = d.ID,
                    Code = d.Code,
                    Name = d.Name,
                    Description = d.Description,
                    CreatedBy = d.CreatedBy,
                    CreatedDate = d.CreatedDate,
                    UpdatedBy = d.UpdatedBy,
                    ModifiedDate = d.ModifiedDate,
                    IPAddress = d.IPAddress
                }).ToListAsync();

                /* var pagedData = designationsDtos                                 
                                     .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                     .Take(pagingRequestDto.PageSize)
                                     .ToList();*/

                return PagedList<CategoryDto>.ToPagedList(categoriesDtos, ItemCount, pagingRequestDto.PageNumber,
                    pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetCategories Filtered() method error", typeof(CategoryRepository));
                throw new Exception($"GetCategories Filtered() method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        private static Expression<Func<Category, object>>
            GetSortProperty(PagingRequestDto request) => request.SortColumn?.ToLower() switch
            {
                "code" => desig => desig.Code,
                "name" => desig => desig.Name,
                "description" => desig => desig.Description,
                "createddate" => desig => desig.CreatedDate,
                "IPAddress" => desig => desig.IPAddress,
                _ => desig => desig.ID

            };

        public async Task<VirtualizeResponse<CategoryDto>> GetAllDesignations(ItemRequestDto itemRequestDto)
        {
            var totalSize = await _context.Category.CountAsync();

            var items = await _context.Category
               .OrderBy(p => p.ID)
               .Skip(itemRequestDto.StartIndex)
               .Take(itemRequestDto.PageSize)
               .ToListAsync();

            var itemsDto = Mapping.Mapper.Map<List<CategoryDto>>(items);

            return new VirtualizeResponse<CategoryDto> { Items = itemsDto, TotalSize = totalSize };
        }

        public async Task<CategoryDto> CreateCategory(CategoryDto categoryDto)
        {
            try
            {
                var category = new Category()
                {
                    Code = categoryDto.Code,
                    Name = categoryDto.Name,
                    Icon= categoryDto.Icon,
                    Description = categoryDto.Description,                  
                    CreatedBy   = categoryDto.CreatedBy,
                    IPAddress = categoryDto.IPAddress,
                };

                cacheService.RemoveData($"categoryDto_pg{CurrentUserPage.CurrentPage}");
                cacheService.RemoveData($"categoryDto_pg{CurrentUserPage.TotalPages}");
                var newItem = await Add(category);
                var newCategory = Mapping.Mapper.Map<CategoryDto>(newItem);
                return newCategory;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateCategory() method error", typeof(CategoryRepository));
                throw new Exception($"Failed to create item {nameof(categoryDto)} in database " + $": {ex}");
            }
        }

        public async Task<CategoryDto> UpdateCategory(CategoryDto categoryDto)
        {
            try
            {
                var item = await Get(categoryDto.Id);

                if (item == null)
                {
                    return null!;
                }

                item.Code = categoryDto.Code;
                item.Name = categoryDto.Name;
                item.Icon = categoryDto.Icon;
                item.Description = categoryDto.Description;
                item.ModifiedDate = categoryDto.ModifiedDate;
                item.UpdatedBy = categoryDto.UpdatedBy;
                item.IPAddress = categoryDto.IPAddress;    

                cacheService.RemoveData($"categoryDto_{item.ID}");
                cacheService.RemoveData($"categoryDto_pg{CurrentUserPage.CurrentPage}");

                var updatedItem = await UpdateAsync(item);
                var updatedItemDto = Mapping.Mapper.Map<CategoryDto>(updatedItem);
                return updatedItemDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateCategory() method error", typeof(CategoryRepository));
                throw new Exception($"Failed to update {nameof(categoryDto)} in database " + $": {ex.Message}");
            }
        }


        public async Task<CategoryDto?> DeleteCategory(int id)
        {
            try
            {
                var item = await Get(id);

                if (item != null)
                {
                    var deletedItem = await DeleteAsync(item);
                    var deletedItemDto = Mapping.Mapper.Map<CategoryDto>(deletedItem);
                    cacheService.RemoveData($"categoryDto_{item.ID}");
                    return deletedItemDto;
                }
                return null!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteCategory() method error", typeof(CategoryRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }


        public async Task<bool> DeleteCategories(List<CategoryDto> categoryListDtos)
        {
            try
            {
                var categories = Mapping.Mapper.Map<List<Category>>(categoryListDtos);

                var deletedItemsStatus = await DeleteRangeAsync(categories);
                categories.ForEach(c => cacheService.RemoveData($"categoryDto_{c.ID}"));

                cacheService.RemoveData($"categoryDto_pg{CurrentUserPage.CurrentPage}");
                return deletedItemsStatus;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteCategories() method error", typeof(CategoryRepository));
                throw new Exception($"Failed to delete {nameof(CategoryDto)} in database " + $": {ex.Message}");
            }
        }

        /*public async Task<PagedList<DesignationDto>> GetDesignations(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var designationList = await _context.Designation
                                    .AsNoTracking()
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();

                var designationDtos = Mapping.Mapper.Map<List<DesignationDto>>(designationList);
                int ItemCount = await _context.Designation.CountAsync();
                return PagedList<DesignationDto>.ToPagedList(designationDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetDesignations() method error", typeof(DesignationRepository));
                throw new Exception($"GetDesignations method() => Failed to fetch designations data  in database " + $": {ex.Message}");
            }
        }*/


        
    }
}
