using BurguerMania.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania.Infrastructure.Context
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigureCategoryProductsRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasMany(c => c.Products)
                        .WithOne(p => p.Category)
                        .HasForeignKey(p => p.CategoryId);
        }

        public static void ConfigureStatusOrdersRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>()
                        .HasMany(s => s.Orders)
                        .WithOne(o => o.Status)
                        .HasForeignKey(o => o.StatusId);
        }

        public static void ConfigureUserOrdersRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(u => u.Orders)
                        .WithOne(o => o.User)
                        .HasForeignKey(o => o.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
        }

        public static void ConfigureOrdersProductsRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                        .HasMany(o => o.Products)
                        .WithMany(p => p.Orders)
                        .UsingEntity<Dictionary<string, object>>("OrdersProducts");
        }
    }
}