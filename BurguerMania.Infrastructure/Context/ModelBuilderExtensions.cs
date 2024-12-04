using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BurguerMania.Infrastructure.Context
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigureKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureEntityKey<GuidKey, Guid, User>();
            modelBuilder.ConfigureEntityKey<IntKey, int, Product>();
            modelBuilder.ConfigureEntityKey<IntKey, int, Order>();
            modelBuilder.ConfigureEntityKey<IntKey, int, Status>();
            modelBuilder.ConfigureEntityKey<IntKey, int, Category>();
        }

        public static void ConfigureRelationships(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureCategoryProductsRelationship();
            modelBuilder.ConfigureOrdersProductsRelationship();
            modelBuilder.ConfigureStatusOrdersRelationship();
            modelBuilder.ConfigureUserOrdersRelationship();
        }

        private static ValueConverter<PK, TPrimitive> GetValueConverter<PK, TPrimitive>()
            where PK: IEntityKey
        {
            return new ValueConverter<PK, TPrimitive> (
                v => (TPrimitive)v.Value,
                v => (PK)Activator.CreateInstance(typeof(PK), v)!
            );
        }

        private static void ConfigureEntityKey<PK, TPrimitive, TEntity>
            (this ModelBuilder modelBuilder)
            where PK : IEntityKey
            where TEntity : BaseEntity<PK>
        {
            var converter = GetValueConverter<PK, TPrimitive>();
            
            modelBuilder.Entity<TEntity>(entity => {
                entity.Property(e => e.Id)
                      .HasConversion(converter)
                      .ValueGeneratedOnAdd();   
            });
        }
        private static void ConfigureCategoryProductsRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasMany(c => c.Products)
                        .WithOne(p => p.Category)
                        .HasForeignKey(p => p.CategoryId);
        }

        private static void ConfigureStatusOrdersRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>()
                        .HasMany(s => s.Orders)
                        .WithOne(o => o.Status)
                        .HasForeignKey(o => o.StatusId);
        }

        private static void ConfigureUserOrdersRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(u => u.Orders)
                        .WithOne(o => o.User)
                        .HasForeignKey(o => o.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
        }

        private static void ConfigureOrdersProductsRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
                        .HasKey(op => new { op.OrderId, op.ProductId });

            modelBuilder.Entity<OrderProduct>()
                        .HasOne(op => op.Order)
                        .WithMany(o => o.OrderProducts)
                        .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderProduct>()
                        .HasOne(op => op.Product)
                        .WithMany(p => p.OrderProducts)
                        .HasForeignKey(op => op.ProductId);
        }
    }
}