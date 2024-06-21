
using DataModel.DB;
using DataModel.Entity;
using DataModel.Entity.AuctionEntity;
using DataModel.Entity.Jobs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Extention;
using Repository.Repository.Auction;
using Repository.Repository.Jobs.Contracts;
using Repository.Service;
using SharedModel.AutionsDto;
using SharedModel.Dtos;
using SharedModel.JobsDto;

namespace Repository.Repository.Jobs
{
    public class OrganisationRepository : GenericRepository<Organisation>, IOrganisationRepository
    {
        private readonly IWebHostEnvironment env;
        public OrganisationRepository(AuctionDBContext context, ILogger<OrganisationRepository> logger,
             IWebHostEnvironment _env) : base(context, logger)
        { 
                env = _env;
        }

        public async Task<OrganisationDto> GetById(int id)
        {
            try
            {
                var organisation = await _context.Organisation                                    
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(s => s.ID == id);

                if (organisation == null) return null!;

                var organisationDto = Mapping.Mapper.Map<OrganisationDto>(organisation);            

                return organisationDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(OrganisationRepository));
                throw new Exception($"Failed to find item with {nameof(id)} in database " + $": {ex.Message}");
            }
        }



        public async Task<List<OrganisationDto>> GetOrganisations()
        {
            try
            {

                var items = await GetAllAsync();               

                var organisationDtos = Mapping.Mapper.Map<List<OrganisationDto>>(items);

                return organisationDtos;
      
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetOrganisation() method error", typeof(OrganisationRepository));
                throw new Exception($"GetOrganisation method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }


        public async Task<OrganisationDto> CreateOrganisation(OrganisationDto organisationDto)
        {
            try
            {
                var savedImages = new OrganisationLogoDto();

                if(organisationDto.organisationLogoDto != null)
                {
                    savedImages = await SaveImagesToLocalDirectory(organisationDto.organisationLogoDto, organisationDto.Tin, "Organisation");

                }

                var newOrg = new Organisation()
                {
                    Code = organisationDto.Code,
                    Name = organisationDto.Name,
                    Tin = organisationDto.Tin,
                    LogoPath = savedImages.Path,
                    CreatedBy= organisationDto.CreatedBy,
                    IPAddress = organisationDto.IPAddress,
                };

                var organisation = await Add(newOrg);
                var orgDto = Mapping.Mapper.Map<OrganisationDto>(organisation);
                return orgDto;          
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateOrganisation() method error", typeof(OrganisationRepository));
                throw new Exception($"Failed to create item {nameof(organisationDto)} in database " + $": {ex}");
            }
        }


        public async Task<OrganisationDto?> DeleteOrganisation(int id)
        {
            try
            {
                var item = await _context.Organisation                                       
                                         .AsNoTracking()
                                         .FirstOrDefaultAsync(s => s.ID == id);

                if (item == null) return null!;

                var deletedItem = await DeleteAsync(item);

                if (deletedItem == null) throw new Exception("Failed to delete item  " + nameof(id));

                var deletedItemDto = Mapping.Mapper.Map<OrganisationDto>(deletedItem);

                if ( ! string.IsNullOrEmpty( item.LogoPath))
                {
                    var status = await DeleteImageFolder("Organisation", deletedItem.Tin);
                    if (status == false)
                    {
                        throw new Exception("Failed to delete image directory of product !");
                    }

                    return deletedItemDto;
                }
                return deletedItemDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteProduct() method error", typeof(ProductRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        private async Task<OrganisationLogoDto> SaveImagesToLocalDirectory(OrganisationLogoDto organisationLogoDto, string organisationCode, string primaryFolderName)
        {
            if (organisationLogoDto == null || string.IsNullOrEmpty(organisationLogoDto?.Base64data.ToString()))
            {
                return null!;
            }
            try
            {
                //var orgLogoSaved = new OrganisationLogoDto();
              
                    var buf = Convert.FromBase64String(organisationLogoDto.Base64data);
                    var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}", organisationCode);
                    var pathToSave = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory()
                    System.IO.Directory.CreateDirectory(pathToSave);
                    await System.IO.File.WriteAllBytesAsync(pathToSave + Path.DirectorySeparatorChar
                        + $"{organisationCode}" + organisationLogoDto.FileName, buf);

                
                var orgLogoSaved = new OrganisationLogoDto(){
                    FileName= organisationLogoDto.FileName,
                    Path = "Static/" + primaryFolderName + "/" + organisationCode + "/" + $"{organisationCode}" + organisationLogoDto.FileName,
                    Description = "Full path of image: " + pathToSave
                };                   
                                   
                return orgLogoSaved;
            }
            catch (Exception)
            {
                throw;
            }
        }




        private async Task<bool> DeleteImageFolder(string primaryFolderName, string productCode)
        {
            try
            {
                var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}", productCode);

                var fullPathToDelete = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory() 
                if (Directory.Exists(fullPathToDelete))
                {
                    DirectoryInfo directory = new DirectoryInfo(fullPathToDelete);
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        file.Delete();
                    }
                    Directory.Delete(fullPathToDelete);
                    return true;
                }
                return await Task.FromResult(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.Message);
                _logger.LogError(ex, "{Repo} DeleteImageFolder() method error, failed to delete image folder!!", typeof(OrganisationRepository));
                throw new Exception($"Failed to delete images folder on server. " + $": {ex.Message}");
            }
        }

    }

}




