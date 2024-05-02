using DataModel.DB;
using DataModel.Entity.AuctionEntity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Extention;
using Repository.Repository.Auction.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;


namespace Repository.Repository.Auction
{
    public class ItemConditionRepository : GenericRepository<ItemCondition>, IItemConditionRepository
    {

        private readonly IWebHostEnvironment env;
        public ItemConditionRepository(AuctionDBContext context, ILogger<ItemConditionRepository> logger,
            IWebHostEnvironment _env) : base(context, logger)
        {
            env = _env;
        }

        public async Task<ItemConditionDto> GetById(int id)
        {
            try
            {
              
                var itemCondition = await _context.ItemCondition
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(s => s.ID == id);

                var itemConditionDto = Mapping.Mapper.Map<ItemConditionDto>(itemCondition);

                return itemConditionDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(ItemConditionRepository));
                throw new Exception($"Failed to find item with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<ItemConditionDto>> GetItemConditions(PagingRequestDto pagingRequestDto)
        {
            try
            {       

                var itemConditions = await _context.ItemCondition                                    
                                    .AsNoTracking()
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();

                int ItemCount = await _context.ItemCondition.CountAsync();

                var itemConditionDtos = Mapping.Mapper.Map<List<ItemConditionDto>>(itemConditions);  
           
                return PagedList<ItemConditionDto>.ToPagedList(itemConditionDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetItemConditions() method error", typeof(ItemConditionRepository));
                throw new Exception($"GetItemConditions menthod() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }


    }
    
}
