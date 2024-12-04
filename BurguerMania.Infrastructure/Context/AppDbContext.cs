using BurguerMania.Domain.Entities;
using BurguerMania.Infrastructure.Seed;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureCategoryProductsRelationship();
            modelBuilder.ConfigureOrdersProductsRelationship();
            modelBuilder.ConfigureStatusOrdersRelationship();
            modelBuilder.ConfigureUserOrdersRelationship();

            Seeder.SeedAll(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}