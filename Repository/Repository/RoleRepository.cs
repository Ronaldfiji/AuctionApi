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

        public async Task<RoleDto> GetById(int id)
        {
            try
            {
                var user = await _context.Role
                    .FirstOrDefaultAsync(r => r.ID == id);
                return user?.ConvertToDto()!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get Role by id method error", typeof(RoleRepository));
                throw new Exception($"Failed to find role with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<RoleDto>> GetAllRoles(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var roles = await _context.Role
                                    .SearchRole(pagingRequestDto)
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();

                int ItemCount = await _context.User.CountAsync();
                return PagedList<RoleDto>.ToPagedList(roles.ConvertToDto(), ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllRoles() method error", typeof(RoleRepository));
                throw new Exception($"Failed to find roles  in database " + $": {ex.Message}");
            }
        }
        public async Task<List<RoleDto>> GetAll()
        {
            try
            {
                var userRoles = await _context.Role.ToListAsync();
                return userRoles.ConvertToDto().ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllRoles_without paging() method error", typeof(RoleRepository));
                throw new Exception($"Failed to find roles  in database " + $": {ex.Message}");
            }
        }

        public async Task<RoleDto> CreateRole(RoleToAddEditDto roleToAdd)
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
                return newRole.ConvertToDto();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateRole method error", typeof(RoleRepository));
                throw new Exception($"Failed to create roles {nameof(RoleToAddEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<RoleDto> UpdateRole(int id, RoleToAddEditDto roleToAddEdit)
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
                var updatedRole = await UpdateAsync(role);
                return updatedRole.ConvertToDto();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUser() method error", typeof(RoleRepository));
                throw new Exception($"Failed to update {nameof(RoleToAddEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<RoleDto> DeleteRole(int id)
        {
            try
            {
                var item = await Get(id);

                if (item != null)
                {
                    var deletedItem = await DeleteAsync(item);
                    return deletedItem.ConvertToDto();
                }
                return item.ConvertToDto()!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteUser() method error", typeof(RoleRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<RoleDto> GetRoleByName(string name)
        {
            try
            {
                var role = await _context.Role
                                .FirstOrDefaultAsync(r => r.Name.ToLower() == name.ToLower());
                return role?.ConvertToDto()!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetRoleByName() method error", typeof(RoleRepository));
                throw new Exception($"Failed to get role by name. Review error logs. " + $": {ex.Message}");
            }

        }

    }
}
