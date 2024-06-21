using DataModel.DB;
using DataModel.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.Logging;
using Repository.Config;
using Repository.Contracts;
using Repository.Extention;
using SharedModel.Dtos;


namespace Repository.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly IWebHostEnvironment env;
        private readonly IPayrollConfiguration configuration;
        public UserRepository(AuctionDBContext context, ILogger<UserRepository> logger, IWebHostEnvironment _env,
            IPayrollConfiguration _configuration
            ) : base(context, logger)
        {
            env = _env;
            configuration = _configuration;
        }

        public  async Task<UserDto?> GetById(int id)
        {
            try
            {
                var user = await _context.User                 
                    .Include(u => u.UserType)
                    .Include(u => u.UserRoles)
                        .ThenInclude(u => u.Role)
                    .Where(u => u.ID == id)
                    .FirstOrDefaultAsync();               
                var userDto = user?.ConvertToDto();
                return userDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get user method error", typeof(UserRepository));
                throw new Exception($"Failed to find user with {nameof(id)} in database " + $": {ex.Message}");
            }
        }


        public async Task<PagedList<UserDto>> GetAllUsers(PagingRequestDto pagingRequestDto)
        {
            try
            {
                   var users = await _context.User                              
                                .Include(u => u.UserType)
                                .Include(u => u.UserRoles)
                                    .ThenInclude(u => u.Role)
                                 .SearchUser(pagingRequestDto)
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                var usersDtos = users.ConvertToDto();

                int ItemCount = await _context.User.CountAsync();
                return PagedList<UserDto>.ToPagedList(usersDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllUsers() method error", typeof(UserRepository));
                throw new Exception($"Failed to find user  in database " + $": {ex.Message}");
            }

        }


       
        public async Task<UserDto> CreateUser(UserToAddDto userToAddDto)
        {
            try
            {
                var savedImages = await SaveImagesToLocalDirectory(userToAddDto.UserPicturesToAddEditDto,
                                      userToAddDto.Phone, "Profile");
                var user = new User()
                {
                    FirstName = userToAddDto.FirstName,
                    LastName = userToAddDto.LastName,
                    DOB = userToAddDto.DOB,
                    Email = userToAddDto.Email,
                    Phone = userToAddDto.Phone,
                    Gender = (DataModel.Entity.Genders)userToAddDto.Gender,
                    AddressLine1 = userToAddDto.AddressLine1,
                    AddressLine2 = userToAddDto.AddressLine2,
                    State = userToAddDto.State,
                    PostalCode = userToAddDto.PostalCode,
                    City = userToAddDto.City,
                    Country = userToAddDto.Country,
                    Password = BCrypt.Net.BCrypt.HashPassword(userToAddDto.Password),
                    UserTypeID = userToAddDto.UserTypeId,
                    IPAddress = userToAddDto.IPAddress,
                    CreatedBy = userToAddDto.CreatedBy,

                };
                if (savedImages != null)
                {
                    user.ImagePath = savedImages.First().Path.ToString();                    
                    /*user.UserPictures = (from img in savedImages
                                         select new UserPictures
                                         {
                                             Name = img.Name,
                                             Description = img.Description,
                                             Path = img.Path
                                         }).ToList();*/

                }
                foreach (var role in userToAddDto.Roles)
                {
                    user.UserRoles.Add(new UserRole
                    {
                        RoleId = role.Id,
                        CreatedBy = userToAddDto.FirstName,
                        IPAddress = userToAddDto.IPAddress
                    });
                }
                var newUser = await Add(user);
                return newUser.ConvertToDto();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateUser() method error", typeof(UserRepository));
                throw new Exception($"Failed to create user  in database " + $": {ex.Message}");
            }
        }

        public async Task<UserDto> UpdateUser(int id, UserToEditDto userToEditDto)
        {
            try
            {
                var imgsToUpdate = (from ImgDto in userToEditDto.UserPicturesDto
                                    select new UserPicturesToAddEditDto
                                    {
                                        Base64data = ImgDto.Base64data,
                                        ContentType = ImgDto.ContentType,
                                        FileName = ImgDto.FileName,
                                    }).ToList();

                var savedImages = new List<UserPicturesDto>();

                //var newPics = userToEditDto.UserPicturesDto?.FirstOrDefault()?.FileName ?? string.Empty;

                if (!string.IsNullOrEmpty(userToEditDto.UserPicturesDto?.FirstOrDefault()?.FileName))
                {
                    savedImages = await SaveImagesToLocalDirectory(imgsToUpdate, userToEditDto.Phone, "Profile");
                }

                var user = await _context.User
                                        .Include(u => u.UserPictures)
                                        .Include(u => u.UserType)                    
                                        .Where(u => u.ID == id)
                                        .FirstOrDefaultAsync();
                if (user == null)
                {
                    return null!;
                }
                user.FirstName = userToEditDto.FirstName;
                user.LastName = userToEditDto.LastName;
                user.DOB = userToEditDto.DOB;
                user.Gender = (DataModel.Entity.Genders)userToEditDto.Gender;
                user.Phone = userToEditDto.Phone;
                user.AddressLine1 = userToEditDto.AddressLine1;
                user.AddressLine2 = userToEditDto.AddressLine2;
                user.City = userToEditDto.City;
                user.State = userToEditDto.State;
                user.PostalCode = userToEditDto.PostalCode;
                user.Country = userToEditDto.Country;
                user.UpdatedBy = userToEditDto.UpdatedBy;
                user.ModifiedDate = userToEditDto.ModifiedDate;
                user.IPAddress = userToEditDto.IPAddress;
                user.UserTypeID = userToEditDto.UserTypeId;
                

                if (savedImages != null && savedImages.Count > 0)
                {
                    user.ImagePath = savedImages.First().Path;

                    /*user.UserPictures = (from img in savedImages                               
                                             select new UserPictures
                                             {
                                                 Name = img.Name,
                                                 Description = img.Description,
                                                 Path = img.Path
                                             }).ToList();    */              
                   
                }
                var updatedUser = await UpdateAsync(user);
                return updatedUser.ConvertToDto();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUserAsync method error",
                  typeof(UserRepository));
                throw new Exception($"Failed to update {nameof(UserToEditDto)} in database " +
                    $": {ex.Message}");
            }
        }
        public async Task<UserDto> UpdateUserWithStatus(int id, UserToEditDto userToEditDto)
        {
            try
            {
                var imgsToUpdate = (from ImgDto in userToEditDto.UserPicturesDto
                                    select new UserPicturesToAddEditDto
                                    {
                                        Base64data = ImgDto.Base64data,
                                        ContentType = ImgDto.ContentType,
                                        FileName = ImgDto.FileName,
                                    }).ToList();

                var savedImages = new List<UserPicturesDto>();

                //var newPics = userToEditDto.UserPicturesDto?.FirstOrDefault()?.FileName ?? string.Empty;

                if (!string.IsNullOrEmpty(userToEditDto.UserPicturesDto?.FirstOrDefault()?.FileName))
                {
                    savedImages = await SaveImagesToLocalDirectory(imgsToUpdate, userToEditDto.Phone, "Profile");
                }

                var user = await _context.User
                                        .Include(u => u.UserPictures)
                                        .Include(u => u.UserType)
                                        .Where(u => u.ID == id)
                                        .FirstOrDefaultAsync();
                if (user == null)
                {
                    return null!;
                }
                user.FirstName = userToEditDto.FirstName;
                user.LastName = userToEditDto.LastName;
                user.DOB = userToEditDto.DOB;
                user.Gender = (DataModel.Entity.Genders)userToEditDto.Gender;
                user.Phone = userToEditDto.Phone;
                user.AddressLine1 = userToEditDto.AddressLine1;
                user.AddressLine2 = userToEditDto.AddressLine2;
                user.City = userToEditDto.City;
                user.State = userToEditDto.State;
                user.PostalCode = userToEditDto.PostalCode;
                user.Country = userToEditDto.Country;
                user.UpdatedBy = userToEditDto.UpdatedBy;
                user.ModifiedDate = userToEditDto.ModifiedDate;
                user.IPAddress = userToEditDto.IPAddress;
                user.UserTypeID = userToEditDto.UserTypeId;
                user.IsActive = userToEditDto.IsActive;


                if (savedImages != null && savedImages.Count > 0)
                {
                    user.ImagePath = savedImages.First().Path;

                    /*user.UserPictures = (from img in savedImages                               
                                             select new UserPictures
                                             {
                                                 Name = img.Name,
                                                 Description = img.Description,
                                                 Path = img.Path
                                             }).ToList();    */

                }
                var updatedUser = await UpdateAsync(user);
                return updatedUser.ConvertToDto();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUserWithStatus method error",
                  typeof(UserRepository));
                throw new Exception($"Failed to update {nameof(UserToEditDto)} in database " +
                    $": {ex.Message}");
            }
        }

        public async Task<UserDto> UpdateUserWithRoles(int id, UserToEditDto userToEditDto)
        {
            try
            {
                var imgsToUpdate = (from ImgDto in userToEditDto.UserPicturesDto
                                    select new UserPicturesToAddEditDto
                                    {
                                        Base64data = ImgDto.Base64data,
                                        ContentType = ImgDto.ContentType,
                                        FileName = ImgDto.FileName,
                                    }).ToList();

                var savedImages = new List<UserPicturesDto>();
               
                if (!string.IsNullOrEmpty(userToEditDto.UserPicturesDto?.FirstOrDefault()?.FileName))
                {
                    savedImages = await SaveImagesToLocalDirectory(imgsToUpdate, userToEditDto.Phone, "Profile");
                }

                //var user = await Get(userToEditDto.Id);
                var user = await _context.User                    
                    .Include(u => u.UserType)
                    .Include(u => u.UserRoles)
                        .ThenInclude(u => u.Role)
                    .Where(u => u.ID == id)
                    .FirstOrDefaultAsync();

                if (user == null)
                {
                    return null!;
                }
                user.FirstName = userToEditDto.FirstName;
                user.LastName = userToEditDto.LastName;
                user.DOB = userToEditDto.DOB;
                user.Gender = (DataModel.Entity.Genders)userToEditDto.Gender;
                user.Phone = userToEditDto.Phone;
                user.AddressLine1 = userToEditDto.AddressLine1;
                user.AddressLine2 = userToEditDto.AddressLine2;
                user.City = userToEditDto.City;
                user.State = userToEditDto.State;
                user.PostalCode = userToEditDto.PostalCode;
                user.Country = userToEditDto.Country;
                user.UpdatedBy = userToEditDto.UpdatedBy;
                user.ModifiedDate = userToEditDto.ModifiedDate;
                user.IPAddress = userToEditDto.IPAddress;
                user.UserTypeID = userToEditDto.UserTypeId;               

                if (userToEditDto.Roles.Count > 0)
                {
                    user.UserRoles.Clear();
                    user.UserRoles = (from roles in userToEditDto.Roles
                                      select new UserRole
                                      {
                                          RoleId = roles.Id,
                                          CreatedBy = userToEditDto.CreatedBy,
                                          UpdatedBy = userToEditDto.UpdatedBy,
                                          IPAddress = userToEditDto.IPAddress,

                                      }).ToList();                    
                }

                if (savedImages != null && savedImages.Count > 0)
                {
                    
                    user.ImagePath = savedImages.First().Path.ToString();                   
                }
                var updatedUser = await UpdateAsync(user);

                return updatedUser.ConvertToDto()  ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUserWithRoleAsync method error",
                  typeof(UserRepository));
                throw new Exception($"Failed to update {nameof(UserToEditDto)} in database " +
                    $": {ex.Message}");
            }
        }

        public async Task<UserDto> DeleteUser(int id)
        {
            var item = await Get(id);
            if (item == null)
            {
                return default(UserDto)!;
            }
            var deletedItem = await DeleteAsync(item);
            if (deletedItem != null)
            {
                var status = await DeleteImageFolder("Profile", deletedItem.Phone);
                return deletedItem.ConvertToDto();
            }
            else
            {
                return default(UserDto)!;
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
                _logger.LogError(ex, "{Repo} DeleteImageFolder() method error, failed to delete image folder!!", typeof(UserRepository));
                throw new Exception($"Failed to delete images folder on server. " + $": {ex.Message}");
            }
        }

        public async Task<UserDto?> GetUserByEmail(string email)
        {
            // return await appDbContext.Employees
            //    .FirstOrDefaultAsync(e => e.Email == email);
            try
            {
                var user = await _context.User
                                .Include(u => u.UserPictures)
                                .Include(u => u.UserType)
                                .Include(u => u.UserRoles)
                                    .ThenInclude(u => u.Role)
                                .FirstOrDefaultAsync(c => c.Email.ToLower() == email.ToLower());

                return user?.ConvertToDto();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "{Repo} GetUserByEmail() method error", typeof(UserRepository));
                throw new Exception($"Failed to get user by email address. Review error logs. " + $": {ex.Message}");
            }

        }

        public async Task<ServiceResponse<UserDto>> AssignRole(int userId, List<UserRoleDto> userRoleList)
        {
            try
            {
                var res = new ServiceResponse<UserDto>();

                var user = await _context.User
                                           .Include(u => u.UserType)
                                           .Include(u => u.UserRoles)
                                           .Where(u => u.ID == userId)
                                           .FirstOrDefaultAsync();
                if (user == null)
                {
                    res.Data = new UserDto();
                    res.StatusCode = 404;
                    return res;
                }

                if (userRoleList.Count > 0)
                {
                    user.UserRoles.Clear();

                    foreach (var role in userRoleList)
                    {
                        if (role != null && role.RoleId > 0)
                            user?.UserRoles.Add(new UserRole
                            {
                                RoleId = role.RoleId,
                                CreatedBy = role.CreatedBy,
                                UpdatedBy = role.UpdatedBy,
                                IPAddress = role.IPAddress,
                            });
                    }
                }
                var updated = await UpdateAsync(user ?? new User());
                if (updated != null)
                {                
                    res.Data = updated.ConvertToDto();
                    res.StatusCode = 200;
                    return res;
                }
                return res;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "{Repo} AssignRole() method error", typeof(UserRepository));             
                throw new Exception($"Failed to assign role to user {userId}. Review error logs. " + $": {ex.Message}");
                
            }

        }

        public async Task<List<UserPicturesDto>> SaveImagesToLocalDirectory(List<UserPicturesToAddEditDto> appUserImageList,
       string userId, string primaryFolderName)
        {
            if (!appUserImageList.Any() || string.IsNullOrEmpty(appUserImageList?.FirstOrDefault()?.Base64data.ToString()))
            {
                return null!;
            }
            try
            {
                var prodImagesSaved = new List<UserPicturesDto>();
                foreach (var file in appUserImageList)
                {
                    var buf = Convert.FromBase64String(file.Base64data);
                    var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}", userId);
                    var pathToSave = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory()
                    System.IO.Directory.CreateDirectory(pathToSave);
                    await System.IO.File.WriteAllBytesAsync(pathToSave + Path.DirectorySeparatorChar
                        + $"{userId}" + file.FileName, buf);

                    prodImagesSaved.Add(new UserPicturesDto
                    {
                        Name = file.FileName,
                        Path = "Static/" + primaryFolderName + "/" + userId + "/" + $"{userId}" + file.FileName,
                        Description = "Full path of image: " + pathToSave
                    });
                }
                return prodImagesSaved;
            }
            catch (Exception)
            {
                throw;
            }
        }





    }
}


//var model = JsonSerializer.Serialize(newUser, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("New Roles are: " + model);