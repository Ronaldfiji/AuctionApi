using DataModel.DB.SeedData;
using DataModel.Entity.AuctionEntity;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataModel.DB
{
    public class AuctionDBContext: DbContext
    {
        //protected readonly IConfiguration Configuration;

        public AuctionDBContext(DbContextOptions<AuctionDBContext> options) : base(options)
        {
            //Configuration = configuration;
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("MSSQLPayrolDB") ??
            throw new InvalidOperationException("Connection string 'MSSQLPayrolDB' not found."));/*, ServiceLifetime.Transient*/
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                    .HasIndex(p => p.Email)
                    .IsUnique();
            modelBuilder.Entity<UserRole>()
              .HasKey(ur => new { ur.UserId, ur.RoleId });
            
            modelBuilder.Entity<UserType>()
               .HasIndex(c => new { c.Code })
               .IsUnique(true);

            modelBuilder.Entity<Category>()
             .HasIndex(c => new { c.Code })
             .IsUnique(true);


            ModelBuilderExt.SeedRole(modelBuilder);
            ModelBuilderExt.SeedUser(modelBuilder);
            ModelBuilderExt.SeedUserType(modelBuilder);
            ModelBuilderExt.SeedUserRoles(modelBuilder);
  

            // Seed Auction data tables.
            ModelBuilderExtAuction.SeedCategory(modelBuilder);
            ModelBuilderExtAuction.SeedItemCondition(modelBuilder);
            ModelBuilderExtAuction.SeedDesignation(modelBuilder);

        }

        public virtual DbSet<User> User { get; set; } = null!;
        public virtual DbSet<Role> Role { get; set; } = null!;
        public virtual DbSet<UserPictures> UserPictures { get; set; } = null!;
        public virtual DbSet<RefreshToken> RefreshToken { get; set; } = null!;
        public virtual DbSet<UserType> UserType { get; set; } = null!;

        //// Auction specific entity      

        public virtual DbSet<Product> Product { get; set; } = null!;
        public virtual DbSet<Category> Category { get; set; } = null!;
        public virtual DbSet<ItemCondition> ItemCondition { get; set; } = null!;
        public virtual DbSet<Bid> Bid { get; set; } = null!;
        public virtual DbSet<ProductPictures> ProductPictures { get; set; } = null!;
        public virtual DbSet<Designation> Designation { get; set; } = null!;

    }
}
