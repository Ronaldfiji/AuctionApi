using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {

        public RoleRepository(AuctionDBContext context, ILogger<RoleRepository> logger) : base(context, logger)
        { }

        public override async Task<Role> Get(int id)
        {
            try
            {
                var user = await _context.Role
                    .FirstOrDefaultAsync(r => r.ID == id);
                return user!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get Role by id method error", typeof(RoleRepository));
                throw new Exception($"Failed to find role with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<Role>> GetAllRoles(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var roles = await _context.Role
                                    .SearchRole(pagingRequestDto)
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();

                int ItemCount = await _context.User.CountAsync();
                return PagedList<Role>.ToPagedList(roles, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllRoles() method error", typeof(RoleRepository));
                throw new Exception($"Failed to find roles  in database " + $": {ex.Message}");
            }
        }
        public async Task<List<Role>> GetAll()
        {
            try
            {
                return await _context.Role.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllRoles_without paging() method error", typeof(RoleRepository));
                throw new Exception($"Failed to find roles  in database " + $": {ex.Message}");
            }
        }

        public async Task<Role> CreateRole(RoleToAddEditDto roleToAdd)
        {
            try
            {

                var role = new Role()
                {
                    Name = roleToAdd.Name,
                    Description = roleToAdd.Description,
                    IPAddress = roleToAdd.IPAddress,
                    CreatedBy = roleToAdd.CreatedBy,
                };

                var newRole = await Add(role);
                return newRole;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateRole method error", typeof(RoleRepository));
                throw new Exception($"Failed to create roles {nameof(RoleToAddEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Role> UpdateRole(int id, RoleToAddEditDto roleToAddEdit)
        {
            try
            {
                var role = await Get(roleToAddEdit.Id);
                if (role == null)
                {
                    return null!;
                }
                role.Name = roleToAddEdit.Name;
                role.Description = roleToAddEdit.Description;
                role.IPAddress = roleToAddEdit.IPAddress;
                role.ModifiedDate = roleToAddEdit.ModifiedDate;
                role.UpdatedBy = roleToAddEdit.UpdatedBy;
                return await UpdateAsync(role);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUser() method error", typeof(RoleRepository));
                throw new Exception($"Failed to update {nameof(RoleToAddEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Role> DeleteRole(int id)
        {
            try
            {
                var item = await Get(id);

                if (item != null)
                {
                    var deletedItem = await DeleteAsync(item);
                    return deletedItem;
                }
                return item!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteUser() method error", typeof(RoleRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Role> GetRoleByName(string name)
        {
            try
            {
                var role = await _context.Role
                                .FirstOrDefaultAsync(r => r.Name.ToLower() == name.ToLower());
                return role!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetRoleByName() method error", typeof(RoleRepository));
                throw new Exception($"Failed to get role by name. Review error logs. " + $": {ex.Message}");
            }

        }

    }
}
