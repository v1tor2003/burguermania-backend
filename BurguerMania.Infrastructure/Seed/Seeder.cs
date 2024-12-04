using BurguerMania.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania.Infrastructure.Seed
{
    public static class Seeder
    {
        public static void SeedAll(ModelBuilder modelBuilder)
        {
            SeedStatuses(modelBuilder);
            SeedCategories(modelBuilder);    
            SeedBurguers(modelBuilder);
            SeedUsers(modelBuilder);
        }

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id  = 1, Name = "Vegano" },
                new Category { Id  = 2, Name = "Clássico" },
                new Category { Id  = 3, Name = "Premium" },
                new Category { Id  = 4, Name = "Frango" },
                new Category { Id  = 5, Name = "Peixe" }
            );
        }

        private static void SeedStatuses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Pendente" },
                new Status { Id = 2, Name = "Em progresso" },
                new Status { Id = 3, Name = "Completo" }
            );
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), Name = "Vitor Pires", Email = "vitor@example.com" },
                new User { Id = Guid.NewGuid(), Name = "Valter Daspaty", Email = "valter@example.com" }
            );
        }

        private static void SeedBurguers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id = 1, 
                    Category = new Category { Id = 1 }, 
                    Name = "X-Fruta",
                    Price = 15m,
                    BaseDescription = "Pão vegano, hambúrguer de grão-de-bico, alface, tomate, fatias de manga, molho especial",
                    FullDescription = "Uma explosão de sabores naturais! O X-Fruta combina o frescor das frutas com a crocância do hambúrguer vegano de grão-de-bico, criando uma experiência saudável e deliciosa."
                },
                new Product
                {
                    Id = 2,
                    Name = "X-Tradicional",
                    BaseDescription = "Pão com gergelim, hambúrguer de carne bovina, queijo cheddar, alface, tomate, ketchup e maionese",
                    Price = 12.50m,
                    Category = new Category { Id = 2 },
                    FullDescription = "O clássico que nunca sai de moda! Um hambúrguer saboroso e equilibrado, perfeito para quem busca o tradicional com um toque especial."
                },
                new Product
                {
                    Id = 3,
                    Name = "X-Bacon Premium",
                    BaseDescription = "Pão brioche, hambúrguer artesanal, queijo gouda, fatias de bacon crocante, cebola caramelizada, rúcula e molho barbecue",
                    Price = 25,
                    Category = new Category { Id = 3 },
                    FullDescription = "Uma experiência gourmet com bacon crocante e queijo gouda. O X-Bacon Premium é perfeito para os amantes de um sabor robusto e marcante."
                },
                new Product
                {
                    Id = 4,
                    Name = "X-Frango Crocante",
                    BaseDescription = "Pão com gergelim, peito de frango empanado, queijo prato, alface americana, maionese temperada",
                    Price = 18,
                    Category = new Category { Id = 4 },
                    FullDescription = "Delicioso e leve, o X-Frango Crocante combina um frango empanado crocante com a suavidade da maionese temperada."
                },
                new Product
                {
                    Id = 5,
                    Name = "X-Salmão",
                    BaseDescription = "Pão integral, hambúrguer de salmão grelhado, cream cheese, alface e molho de dill",
                    Price = 28,
                    Category = new Category { Id = 5 },
                    FullDescription = "Elegante e saudável, o X-Salmão traz um toque de sofisticação com salmão grelhado e um molho de dill único."
                },
                new Product
                {
                    Id = 6,
                    Name = "X-Tofu Especial",
                    BaseDescription = "Pão vegano, tofu grelhado, cogumelos salteados, rúcula, molho de tahine",
                    Price = 20,
                    Category = new Category { Id = 1 },
                    FullDescription = "O X-Tofu Especial é uma escolha refinada e saudável, com tofu grelhado e cogumelos que encantam os paladares mais exigentes."
                },
                new Product
                {
                    Id = 7,
                    Name = "X-Queijo Duplo",
                    BaseDescription = "Pão de hambúrguer, hambúrguer de carne bovina, queijo cheddar duplo, molho especial",
                    Price = 16,
                    Category = new Category { Id = 2 },
                    FullDescription = "Para os fãs de queijo, o X-Queijo Duplo é uma explosão de sabor com camadas generosas de cheddar e um molho irresistível."
                },
                new Product
                {
                    Id = 8,
                    Name = "X-Cordeiro Gourmet",
                    BaseDescription = "Pão ciabatta, hambúrguer de cordeiro, queijo feta, tomate seco, rúcula e molho de hortelã",
                    Price = 30,
                    Category = new Category { Id = 3 },
                    FullDescription = "Uma criação exclusiva com cordeiro suculento, queijo feta e um toque refrescante de hortelã para uma experiência inesquecível."
                }
            );
        }
    }
}