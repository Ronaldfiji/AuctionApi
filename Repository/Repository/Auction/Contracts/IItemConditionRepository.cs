using DataModel.Entity.AuctionEntity;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.AutionsDto;
using SharedModel.Dtos;


namespace Repository.Repository.Auction.Contracts
{
    public interface IItemConditionRepository : IGenericRepository<ItemCondition>
    {
        Task<ItemConditionDto> GetById(int id);
        Task<PagedList<ItemConditionDto>> GetItemConditions(PagingRequestDto pagingRequestDto);
    }
}
