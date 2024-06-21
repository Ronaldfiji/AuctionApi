using DataModel.Entity.Jobs;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.Dtos;
using SharedModel.JobsDto;

namespace Repository.Repository.Jobs.Contracts
{
    public interface IJobPostRepository : IGenericRepository<JobPost>
    {
        Task<JobPostDto> GetById(int id);
        Task<PagedList<JobPostDto>> GetJobPosts(PagingRequestDto pagingRequestDto);
        Task<PagedList<JobPostDto>> GetJobPostsFiltered(PagingRequestDto pagingRequestDto);
        Task<JobPostDto> CreateJobPost(JobPostDto jobPostDto);
        Task<JobPostDto> UpdateJobPost(JobPostDto jobPostDto);
        Task<JobPostDto> DeleteJobPost(int id);
        Task<bool> DeleteJobPosts(List<JobPostDto> jobPostDtos);
    }
}
