using DataModel.Entity.Jobs;
using Repository.Contracts;
using SharedModel.JobsDto;

namespace Repository.Repository.Jobs.Contracts
{
    public interface IOrganisationRepository : IGenericRepository<Organisation>
    {
        Task<OrganisationDto> GetById(int id);
        Task<List<OrganisationDto>> GetOrganisations();
        Task<OrganisationDto> CreateOrganisation(OrganisationDto organisationDto);
        Task<OrganisationDto?> DeleteOrganisation(int id);


     }
}
