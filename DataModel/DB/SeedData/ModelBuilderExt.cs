using DataModel.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataModel.DB
{
    public static class ModelBuilderExt
    {
        // Seed role 
        public static void SeedRole(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 1,//new Random().Next(),
                    Name = "User",
                    Description = "User role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });
           
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 2,//new Random().Next(),
                    Name = "Admin",
                    Description = "Admin role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   ID = 3,//new Random().Next(),
                   Name = "HOD",
                   Description = "HOD role",
                   CreatedDate = DateTime.UtcNow.AddHours(12)
               });
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 4,//new Random().Next(),
                    Name = "Manager",
                    Description = "Manager role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   ID = 5,//new Random().Next(),
                   Name = "MasterAdmin",
                   Description = "Master Admin role",
                   CreatedDate = DateTime.UtcNow.AddHours(12)
               });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   ID = 6,//new Random().Next(),
                   Name = "HROffice",
                   Description = "HR Admin",
                   CreatedDate = DateTime.UtcNow.AddHours(12)
               });
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 7,//new Random().Next(),
                    Name = "Director",
                    Description = "Director role",
                    CreatedDate = DateTime.UtcNow.AddHours(12)
                });
           
        }

        // Seed user 
        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            DateTime dt ;
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    ID = 1,//new Random().Next(),                    
                    FirstName = "Admin", LastName = "Limited", Email = "admin@admin.com", DOB = DateTime.TryParse("21-07-1956", out dt) ? dt :  DateTime.Now,
                    Gender = (Genders)(3), Password = BCrypt.Net.BCrypt.HashPassword("123"), Country = "Fiji", City = "Levuka", State = "BlackWater",
                    AddressLine1 = "First Road X road", AddressLine2 = "10 , Fox Street", Phone = "9090337", PostalCode = "0123",
                    CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Manager-up",
                    IPAddress = "107.23.365.369", UserTypeID = 1,
                },
                new User()
                {
                    ID = 2,//new Random().Next(),                    
                    FirstName = "John", LastName = "Smith", Email = "john@mail.com", DOB = DateTime.TryParse("29-07-1979", out dt) ? dt :  DateTime.Now,
                    Gender = (Genders)(1),Password = BCrypt.Net.BCrypt.HashPassword("123"), Country = "Samoa", City = "Apia", State = "North",
                    AddressLine1 = "Fula Fula Road", AddressLine2 = "10, Black street", Phone = "74789699", PostalCode = "458",
                    CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up",
                    IPAddress = "107.23.365.369", UserTypeID = 1,
                },
                new User()
                {
                    ID = 3,//new Random().Next(),                    
                    FirstName = "Peter", LastName = "Gates", Email = "peter@mail.com", DOB = DateTime.TryParse("30-09-1983", out dt) ? dt :  DateTime.Now,
                    Gender = (Genders)(3), Password = BCrypt.Net.BCrypt.HashPassword("123"), Country = "Vanuatu", City = "Port Vila", State = "Ocean",
                    AddressLine1 = "Rock line Island", AddressLine2 = "29, Bush mount road", Phone = "8890337", PostalCode = "889",
                    CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up",
                    IPAddress = "107.23.365.369", UserTypeID = 1,
                },
                new User()
                {
                    ID = 4,//new Random().Next(),                    
                    FirstName = "Monika", LastName = "Kumar", Email = "monika@mail.com", DOB = DateTime.TryParse("30-09-1983", out dt) ? dt :  DateTime.Now,
                    Gender = (Genders)(2), Password = BCrypt.Net.BCrypt.HashPassword("123"), Country = "New zealand", City = "Auckland", State = "North",
                    AddressLine1 = "Manukau Cresent", AddressLine2 = "41, Black place", Phone = "9090337", PostalCode = "064",
                    CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up",
                    IPAddress = "107.23.365.369", UserTypeID = 1,
                }); 
        }

        //Seed user type table
        public static void SeedUserType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserType>().HasData(
                new UserType
                {
                    ID = 1,//new Random().Next(),
                    Code = "C",
                    Name = "Client",
                    Description = "Organisation or Individual who receives service.",
                    CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new UserType
                {
                    ID = 2,//new Random().Next(),
                    Code = "B",
                    Name = "Enterprise",
                    Description = "Service provider",
                    CreatedDate = DateTime.UtcNow.AddHours(12),
                });

        }
        // Seed user role.
        public static void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<UserRole>().HasData(
                new UserRole() { UserId = 1, RoleId = 1, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 1, RoleId = 5, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 1, RoleId = 7, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 2, RoleId = 1, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 3, RoleId = 1, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 3, RoleId = 2, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 3, RoleId = 5, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" },
                new UserRole() { UserId = 4, RoleId = 1, CreatedDate = DateTime.UtcNow.AddHours(12), CreatedBy = "Admin-cr", UpdatedBy = "Admin-up", IPAddress = "107.23.365.369" });
        }

    }
}
