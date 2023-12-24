using Avtopark.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Avtopark.DataAccess
{
    public class AvtoparkDbContext : DbContext
    {
        public DbSet<Automobile> Automobiles { get; set; }
        public DbSet<AutomobileCategory> AutomobileCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<User> Users { get; set; }


        public AvtoparkDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automobile>().HasKey(x => x.Id);
            modelBuilder.Entity<Automobile>().HasIndex(x => x.ExternalId).IsUnique();

            modelBuilder.Entity<Automobile>().HasOne(x => x.AutomobileCategory)
                    .WithMany(x => x.Automobiles)
                    .HasForeignKey(x => x.AutomobileCategoryId);

            modelBuilder.Entity<Automobile>().HasOne(x => x.Shop)
                    .WithMany(x => x.Automobiles)
                    .HasForeignKey(x => x.ShopId);

            modelBuilder.Entity<AutomobileCategory>().HasKey(x => x.Id);
            modelBuilder.Entity<AutomobileCategory>().HasIndex(x => x.ExternalId).IsUnique();

            modelBuilder.Entity<Comment>().HasKey(x => x.Id);
            modelBuilder.Entity<Comment>().HasIndex(x => x.ExternalId).IsUnique();

            modelBuilder.Entity<Comment>().HasOne(x => x.User)
                    .WithMany(x => x.Comments)
                    .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Order>().HasKey(x => x.Id);
            modelBuilder.Entity<Order>().HasIndex(x => x.ExternalId).IsUnique();

            modelBuilder.Entity<Order>().HasOne(x => x.User)
                    .WithMany(x => x.Orders)
                    .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Order>().HasOne(x => x.Automobile)
                    .WithMany(x => x.Orders)
                    .HasForeignKey(x => x.AutomobileId);

            modelBuilder.Entity<Shop>().HasKey(x => x.Id);
            modelBuilder.Entity<Shop>().HasIndex(x => x.ExternalId).IsUnique();

            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().HasIndex(x => x.ExternalId).IsUnique();
        }
    }
}
