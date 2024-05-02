using DataModel.Entity;
using SharedModel.Dtos;

namespace Repository.Extention
{
    public static class DtoConversions
    {
        public static UserDto ConvertToDto(this User user)
        {
            var userRoles = new List<RoleDto>();
            var userType = new UserTypeDto();
            foreach (var role in user.UserRoles)
            {
                if (role.Role != null)
                {
                    userRoles.Add(new RoleDto()
                    {
                        Id = role.RoleId,
                        Name = role.Role.Name,
                        Description = role.Role.Description,
                    });
                }
            }
            if (user.UserType != null)
            {
                userType = new UserTypeDto { Id = user.UserType.ID, Name = user.UserType.Name, Description = user.UserType.Description };

            }

            return new UserDto
            {
                Id = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender.ToString(),
                Email = user.Email,
                Phone = user.Phone,
                DOB = user.DOB,
                AddressLine1 = user.AddressLine1,
                AddressLine2 = user.AddressLine2,
                City = user.City,
                State = user.State,
                PostalCode = user.PostalCode,
                Country = user.Country,
                ImagePath= user.ImagePath,
                IsActive = user.IsActive,
                Roles = userRoles,
                CreatedDate = user.CreatedDate,
                ModifiedDate = user.ModifiedDate,
                CreatedBy = user.CreatedBy,
                UpdatedBy = user.UpdatedBy,
                IPAddress = user.IPAddress,
                /*UserPictures = (from pics in user.UserPictures
                                select new UserPicturesDto()
                                {
                                    Id = pics.ID,
                                    Name = pics.Name,
                                    Description = pics.Description,
                                    Path = pics.Path,
                                }).ToList(),*/
                UserType = userType,

            };
        }


        public static IEnumerable<UserDto> ConvertToDto(this IEnumerable<User> Users)
        {

            return (from user in Users
                    select new UserDto
                    {
                        Id = user.ID,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Gender = user.Gender.ToString(),
                        Email = user.Email,
                        Phone = user.Phone,
                        DOB = user.DOB,
                        AddressLine1 = user.AddressLine1,
                        AddressLine2 = user.AddressLine2,
                        City = user.City,
                        State = user.State,
                        PostalCode = user.PostalCode,
                        Country = user.Country,
                        ImagePath = user.ImagePath,
                        IsActive = user.IsActive,
                        Roles = (from role in user.UserRoles
                                 select new RoleDto
                                 {
                                     Id = role.RoleId,
                                     Name = role.Role.Name,
                                     Description = role.Role.Description,

                                 }).ToList(),

                        /*UserPictures = (from pics in user.UserPictures
                                        select new UserPicturesDto()
                                        {
                                            Id = pics.ID,
                                            Name = pics.Name,
                                            Description = pics.Description,
                                            Path = pics.Path,
                                        }).ToList(),*/


                        UserType = user.UserType != null ? new UserTypeDto()
                        {
                            Id = user.UserType.ID,
                            Name = user.UserType.Name,
                            Description = user.UserType.Description,
                            CreatedDate = user.CreatedDate,
                            ModifiedDate = user.ModifiedDate,
                            CreatedBy = user.CreatedBy,
                            UpdatedBy = user.UpdatedBy,
                            IPAddress = user.IPAddress,
                        } : new UserTypeDto(),

                        CreatedDate = user.CreatedDate,
                        ModifiedDate = user.ModifiedDate,
                        CreatedBy = user.CreatedBy,
                        UpdatedBy = user.UpdatedBy,
                        IPAddress = user.IPAddress,

                    }).ToList();

        }

        public static UserTypeDto ConvertToDto(this UserType userType)
        {
            return new UserTypeDto
            {
                Id = userType.ID,
                Name = userType.Name,
                Code = userType.Code,
                Description = userType.Description,
                CreatedDate = userType.CreatedDate,
                CreatedBy = userType.CreatedBy,
                UpdatedBy = userType.UpdatedBy,
                IPAddress = userType.IPAddress,
            };
        }

        public static IEnumerable<UserTypeDto> ConvertToDto(this IEnumerable<UserType> UserTypes)
        {
            return (
            from userType in UserTypes
            select new UserTypeDto
            {
                Id = userType.ID,
                Code = userType.Code,
                Name = userType.Name,
                Description = userType.Description,
                CreatedDate = userType.CreatedDate,
                CreatedBy = userType.CreatedBy,
                UpdatedBy = userType.UpdatedBy,
                IPAddress = userType.IPAddress,

            }).ToList();

        }
    }
}
