using DataModel.Entity.AuctionEntity;
using Repository.Extention;
using SharedModel.Dtos;

namespace Repository.Contracts
{
    public interface IDesignationRepository : IGenericRepository<Designation>
    {        
        Task<DesignationDto> GetById(int id);
        Task<PagedList<DesignationDto>> GetDesignations(PagingRequestDto pagingRequestDto);
        Task<PagedList<DesignationDto>> GetDesignationsFiltered(PagingRequestDto pagingRequestDto);
        Task<DesignationDto> CreateDesignation(DesignationDto designationDto);
        Task<DesignationDto> UpdateDesignation(DesignationDto designationDto);
        Task<DesignationDto?> DeleteDesignation(int id);
        Task<bool> DeleteDesignations(List<DesignationDto> designationDtos);
    }
}
