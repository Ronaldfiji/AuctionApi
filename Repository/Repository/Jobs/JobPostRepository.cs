using DataModel.DB;
using DataModel.Entity.AuctionEntity;
using DataModel.Entity.Jobs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Extention;
using Repository.Repository.Auction;
using Repository.Repository.Jobs.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;
using SharedModel.JobsDto;
using System.Linq.Expressions;


namespace Repository.Repository.Jobs
{
    public class JobPostRepository : GenericRepository<JobPost>, IJobPostRepository
    {
        private readonly IWebHostEnvironment env;
        public JobPostRepository(AuctionDBContext context, ILogger<JobPostRepository> logger,
             IWebHostEnvironment _env) : base(context, logger)
        {
            env = _env;
        }

        public async Task<JobPostDto> GetById(int id)
        {
            try
            {
                var item = await _context.JobPost
                                         .Include(p => p.Organisation)                                    
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(s => s.ID == id);

                if (item == null) return null!;

                var jobPostDto = Mapping.Mapper.Map<JobPostDto>(item);

                return jobPostDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(JobPostRepository));
                throw new Exception($"Failed to find item with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<JobPostDto>> GetJobPosts(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var items = await _context.JobPost                                   
                                    .Include(p => p.Organisation)                                    
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .AsNoTracking()
                                    .ToListAsync();

                int ItemCount = await _context.JobPost.CountAsync();
                
                var jobPostDtos = Mapping.Mapper.Map<List<JobPostDto>>(items);

                return PagedList<JobPostDto>.ToPagedList(jobPostDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetJobPosts() method error", typeof(JobPostRepository));
                throw new Exception($"GetJobPosts method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }


        public async Task<PagedList<JobPostDto>> GetJobPostsFiltered(PagingRequestDto pagingRequestDto)
        {
            try
            {
                IQueryable<JobPost> jobPostsQuery = from d in _context.JobPost.Include(p => p.Organisation) select d;
                int ItemCount = await jobPostsQuery.CountAsync();

                jobPostsQuery = jobPostsQuery.SearchJobPost(pagingRequestDto);

                if (string.Equals(pagingRequestDto.SortOrder?.Trim(), "desc", StringComparison.OrdinalIgnoreCase))
                {
                    /* Updated the query on 17 Jun 2024. The order of excution .OrderByDecending than apply paging(Skip/Take)
                     to get recent */
                    jobPostsQuery = jobPostsQuery
                                    .OrderByDescending(GetSortProperty(pagingRequestDto))
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize);
                                   

                }
                else
                {
                    jobPostsQuery = jobPostsQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderBy(GetSortProperty(pagingRequestDto));
                }

                //var designationDtos = (from d in designationsQuery select new DesignationDto() {}).ToListAsync();
                var jobPostDtos = Mapping.Mapper.Map<List<JobPostDto>>(jobPostsQuery);

                return PagedList<JobPostDto>.ToPagedList(jobPostDtos, ItemCount, pagingRequestDto.PageNumber,
                    pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetProducts Filtered() method error", typeof(ProductRepository));
                throw new Exception($"GetProducts Filtered() method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        private static Expression<Func<JobPost, object>>
            GetSortProperty(PagingRequestDto request) => request.SortColumn?.ToLower() switch
            {
                "jobtitle" => job => job.JobTitle,
                "organisation" => job => job.Organisation,
                "city" => job => job.City,
                "isactive" => job => job.IsActived,
                "description" => job => job.Description,
                "createddate" => job=> job.CreatedDate,
                "IPAddress" => desig => desig.IPAddress,
                _ => desig => desig.ID

            };



        public async Task<JobPostDto> CreateJobPost(JobPostDto jobPostDto)
        {
            try
            {
                var jobPost = new JobPost()
                {
                    JobTitle = jobPostDto.JobTitle,
                    OrganisationID= jobPostDto.OrganisationID,
                    City = jobPostDto.City,
                    Country = jobPostDto.Country,
                    ClosingDate = jobPostDto.ClosingDate,
                    Description = jobPostDto.Description,
                    Category = jobPostDto.Category,
                    JobType = jobPostDto.JobType,
                    UserID = jobPostDto.UserID,
                    IsActived = jobPostDto.IsActive,
                    IPAddress = jobPostDto.IPAddress,
                    CreatedBy = jobPostDto.CreatedBy,
                };               


                var newItem = await Add(jobPost);
                var newJobPostDto = Mapping.Mapper.Map<JobPostDto>(newItem);
                return newJobPostDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateJobPost() method error", typeof(JobPostRepository));
                throw new Exception($"Failed to create item {nameof(jobPostDto)} in database " + $": {ex}");
            }
        }



        public async Task<JobPostDto> UpdateJobPost(JobPostDto jobPostDto)
        {
            try
            {
                var item = await Get(jobPostDto.Id);

                if (item == null)
                {
                    return null!;
                }

                item.JobTitle = jobPostDto.JobTitle;
                item.Category = jobPostDto.Category;
                item.Description = jobPostDto.Description;
                item.OrganisationID= jobPostDto.OrganisationID;
                item.ClosingDate = jobPostDto.ClosingDate;
                item.JobType   = jobPostDto.JobType;
                item.IsActived = jobPostDto.IsActive;
                item.ModifiedDate = jobPostDto.ModifiedDate;    

                var updatedItem = await UpdateAsync(item);
                var updatedItemDto = Mapping.Mapper.Map<JobPostDto>(updatedItem);
                return updatedItemDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateJobPost() method error", typeof(JobPostRepository));
                throw new Exception($"Failed to update {nameof(jobPostDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<JobPostDto> DeleteJobPost(int id)
        {
            try
            {
                var item = await _context.JobPost                                        
                                         .AsNoTracking()
                                         .FirstOrDefaultAsync(s => s.ID == id);

                if (item == null) return null!;

                var deletedItem = await DeleteAsync(item);

                if (deletedItem == null) throw new Exception("Failed to delete item  " + nameof(id));

                var deletedItemDto = Mapping.Mapper.Map<JobPostDto>(deletedItem);
        
                return deletedItemDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteJobPost() method error", typeof(JobPostRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<bool> DeleteJobPosts(List<JobPostDto> jobPostDtos)
        {
            try
            {
                var jobPosts = Mapping.Mapper.Map<List<JobPost>>(jobPostDtos);
                var deletedItemsStatus = await DeleteRangeAsync(jobPosts);
              
                return deletedItemsStatus;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteJobPosts() method error", typeof(JobPostRepository));
                throw new Exception($"Failed to delete {nameof(jobPostDtos)} in database " + $": {ex.Message}");
            }
        }


    }
}
