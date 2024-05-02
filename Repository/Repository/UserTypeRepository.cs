using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Repository.Extention;
using Repository.Repository.Contracts;
using SharedModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserTypesRepository : GenericRepository<UserType>, IUserTypesRepository
    {
        public UserTypesRepository(AuctionDBContext context, ILogger<UserRepository> logger) : base(context, logger)
        { 
        }

        public async Task<UserTypeDto?> GetUserType(int id)
        {
            try
            {
              
                var userTypess = await _context.UserType
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(s => s.ID == id);

                return userTypess?.ConvertToDto(); 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(UserTypesRepository));
                throw new Exception($"Failed to find user type with {nameof(id)} in database " + $": {ex.Message}");
            }
        }


        public async Task<PagedList<UserTypeDto>> GetUserTypes(PagingRequestDto pagingRequestDto)
        {
            try
            {

                var userTypes = await _context.UserType                                      
                                       .AsNoTracking()
                                       .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                       .Take(pagingRequestDto.PageSize)
                                       .ToListAsync();

                int ItemCount = await _context.Designation.CountAsync();

                var userTypesDtos = Mapping.Mapper.Map<List<UserTypeDto>>(userTypes);           

                return PagedList<UserTypeDto>.ToPagedList(userTypesDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

              
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetUserTypes() method error", typeof(UserTypesRepository));
                throw new Exception($"GetUserTypes menthod() => Failed to fetch user types data  in database " + $": {ex.Message}");
            }
        }




    }
}
