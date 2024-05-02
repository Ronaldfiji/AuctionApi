using DataModel.DB;
using DataModel.Entity.AuctionEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.Dtos;
using System.Linq.Expressions;

using ConfigurationManager = Repository.Util.ConfigurationManager;

namespace Repository.Repository
{
    public class DesignationRepository : GenericRepository<Designation>, IDesignationRepository
    {
        
        private readonly ICacheService cacheService;
        public DesignationRepository(AuctionDBContext context,ICacheService cacheService , ILogger<DesignationRepository> logger) : base(context, logger)
        {
            this.cacheService = cacheService;          
        }


        public  async Task<DesignationDto> GetById(int id)
        {
            try
            {
                var designationInRedisCache = cacheService.GetData<DesignationDto>($"designationDto_{id}");

                if (designationInRedisCache != null && designationInRedisCache.Id > 0)
                {
                    return designationInRedisCache;
                }
                var designation = await _context.Designation
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(s => s.ID == id);

                var desigantionDto = Mapping.Mapper.Map<DesignationDto>(designation);

                if (desigantionDto != null)
                {
                    var redisCacheExp = ConfigurationManager.AppSetting["CacheSettings:RedisCachingExpiry"];
                    var expiryTime = DateTimeOffset.Now.AddSeconds(Convert.ToDouble(redisCacheExp));
                    cacheService.SetData<DesignationDto>($"designationDto_{id}", desigantionDto, expiryTime);
                }

                return desigantionDto!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(DesignationRepository));
                throw new Exception($"Failed to find item with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<DesignationDto>> GetDesignations(PagingRequestDto pagingRequestDto)
        {
            try
            {
                //var redisCache = cacheService.GetData<IEnumerable<DesignationDto>>($"designationDto_pg{pagingRequestDto.PageNumber}");
                //var totalRows = cacheService.GetData<int>($"TotalItems{typeof(Designation).Name}");
              
                //if (redisCache != null && redisCache.ToList().Count() > 0 && 
                //    redisCache?.ToList()?.Count() == pagingRequestDto.PageSize && 
                //    string.IsNullOrEmpty(pagingRequestDto.ColumnName) && string.IsNullOrEmpty(pagingRequestDto.SearchTerm))
                //{
                //    return PagedList<DesignationDto>.ToPagedList(redisCache, totalRows, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);
                //}

                var designations = await _context.Designation
                                    .SearchDesignation(pagingRequestDto)
                                    .AsNoTracking()
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();
                
                int ItemCount = await _context.Designation.CountAsync();               

                var designationDtos = Mapping.Mapper.Map<List<DesignationDto>>(designations);

                var redisCacheExp = ConfigurationManager.AppSetting["CacheSettings:RedisCacheExpiryPaging"];

                var expiryTime = DateTimeOffset.Now.AddSeconds(Convert.ToDouble(redisCacheExp));

                cacheService.SetData<IEnumerable<DesignationDto>>($"designationDto_pg{pagingRequestDto.PageNumber}", designationDtos, expiryTime);
                cacheService.SetData<int>($"TotalItems{typeof(Designation).Name}", ItemCount, expiryTime);

                return PagedList<DesignationDto>.ToPagedList(designationDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetDesignations() method error", typeof(DesignationRepository));
                throw new Exception($"GetDesignations menthod() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<DesignationDto>> GetDesignationsFiltered(PagingRequestDto pagingRequestDto)
        {
            try
            {
                IQueryable<Designation> designationsQuery = from d in _context.Designation select d;
                int ItemCount = await designationsQuery.CountAsync();

                designationsQuery = designationsQuery.SearchDesignation(pagingRequestDto);               
               
                if (string.Equals(pagingRequestDto.SortOrder?.Trim(), "desc", StringComparison.OrdinalIgnoreCase))
                {                  
                    designationsQuery = designationsQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderByDescending(GetSortProperty(pagingRequestDto));
                        
                }
                else
                {                    
                    designationsQuery = designationsQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderBy(GetSortProperty(pagingRequestDto));
                }           

                //var designationDtos = (from d in designationsQuery select new DesignationDto() {}).ToListAsync();
                             

                var designationsDtos = await designationsQuery.Select(d => new DesignationDto
                {
                    Id = d.ID,
                    JobTitle = d.JobTitle,
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

                return PagedList<DesignationDto>.ToPagedList(designationsDtos, ItemCount, pagingRequestDto.PageNumber, 
                    pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetDesignations() method error", typeof(DesignationRepository));
                throw new Exception($"GetDesignations menthod() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        private static Expression<Func<Designation, object>>
            GetSortProperty(PagingRequestDto request) => request.SortColumn?.ToLower() switch
            {
                "jobtitle" => desig => desig.JobTitle,
                "description" => desig => desig.Description,
                "createddate" => desig => desig.CreatedDate,
                "IPAddress" => desig => desig.IPAddress,
                _ => desig => desig.ID

            };

        public async Task<VirtualizeResponse<DesignationDto>> GetAllDesignations(ItemRequestDto itemRequestDto)
        {
            var totalSize = await _context.Designation.CountAsync();

            var items = await _context.Designation
               .OrderBy(p => p.ID)
               .Skip(itemRequestDto.StartIndex)
               .Take(itemRequestDto.PageSize)
               .ToListAsync();

            var itemsDto = Mapping.Mapper.Map<List<DesignationDto>>(items);

            return new VirtualizeResponse<DesignationDto> { Items = itemsDto, TotalSize = totalSize };
        }

        public async Task<DesignationDto> CreateDesignation(DesignationDto designationDto)
        {
            try
            {
                var designation = new Designation()
                {
                    JobTitle = designationDto.JobTitle, 
                    Description = designationDto.Description,                               
                    CreatedBy = designationDto.CreatedBy,                  
                    IPAddress = designationDto.IPAddress,   
                    DesignationDate = designationDto.DesignationDate,
                };
                
                cacheService.RemoveData($"designationDto_pg{CurrentUserPage.CurrentPage}");
                cacheService.RemoveData($"designationDto_pg{CurrentUserPage.TotalPages}");
                var newItem = await Add(designation);
                var desigantionDto = Mapping.Mapper.Map<DesignationDto>(newItem);
                return desigantionDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateDesignation() method error", typeof(DesignationRepository));
                throw new Exception($"Failed to create item {nameof(designationDto)} in database " + $": {ex}");
            }
        }

        public async Task<DesignationDto> UpdateDesignation(DesignationDto designationDto)
        {
            try
            {
                var item = await Get(designationDto.Id);

                if (item == null)
                {
                    return null!;
                }

                item.JobTitle = designationDto.JobTitle;
                item.Description = designationDto.Description; 
                item.UpdatedBy = designationDto.UpdatedBy;
                item.ModifiedDate = designationDto.ModifiedDate;
                item.IPAddress = designationDto.IPAddress;             

                cacheService.RemoveData($"designationDto_{item.ID}");
                cacheService.RemoveData($"designationDto_pg{CurrentUserPage.CurrentPage}");

                var updatedItem = await UpdateAsync(item);
                var updatedItemDto = Mapping.Mapper.Map<DesignationDto>(updatedItem);
                return updatedItemDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateDesignation() method error", typeof(DesignationRepository));
                throw new Exception($"Failed to update {nameof(designationDto)} in database " + $": {ex.Message}");
            }
        }


        public async Task<DesignationDto?> DeleteDesignation(int id)
        {
            try
            {
                var item = await Get(id);

                if (item != null)
                {
                    var deletedItem = await DeleteAsync(item);
                    var deletedItemDto = Mapping.Mapper.Map<DesignationDto>(deletedItem);
                    cacheService.RemoveData($"designationDto_{item.ID}");
                    return deletedItemDto;
                }
                return null!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteDesignation() method error", typeof(DesignationRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }


        public async Task<bool> DeleteDesignations(List<DesignationDto> designationDtos)
        {
            try
            {
                var designations = Mapping.Mapper.Map<List<Designation>>(designationDtos);

                var deletedItemsStatus = await DeleteRangeAsync(designations);
                designations.ForEach(c => cacheService.RemoveData($"designationDto_{c.ID}"));
            
                cacheService.RemoveData($"designationDto_pg{CurrentUserPage.CurrentPage}");
                return deletedItemsStatus;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteDesignations() method error", typeof(DesignationRepository));
                throw new Exception($"Failed to delete {nameof(designationDtos)} in database " + $": {ex.Message}");
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


        //public async Task<PagedList<DesignationDto>> GetFilteredDesignations(PagingRequestDto pagingRequestDto)
        //{
        //    try
        //    {
        //        var designationList = await _context.Designation
        //                                .SearchDesignation(pagingRequestDto)
        //                            .AsNoTracking()
        //                            .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
        //                            .Take(pagingRequestDto.PageSize)
        //                            .ToListAsync();

        //        var designationDtos = Mapping.Mapper.Map<List<DesignationDto>>(designationList);
        //        int ItemCount = await _context.Designation.CountAsync();
        //        return PagedList<DesignationDto>.ToPagedList(designationDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "{Repo} GetFilteredDesignations() method error", typeof(DesignationRepository));
        //        throw new Exception($"GetFilteredDesignations method() => Failed to fetch designations data  in database " + $": {ex.Message}");
        //    }

        //}
    }
}

//var model = JsonSerializer.Serialize(newUser, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("New Roles are: " + model);