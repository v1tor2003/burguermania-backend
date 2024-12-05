using BurguerMania.Domain.Common;
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
            SeedProducts(modelBuilder);
            SeedUsersAndOrders(modelBuilder);
            SeedOrderProducts(modelBuilder);
        }

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id  = new IntKey(1), Name = "Vegano", Description = "Descricao de Vegano", PathImage = "Uploads/Images/burguer.png" },
                new Category { Id  = new IntKey(2), Name = "Clássico", Description = "Descricao de Classico", PathImage = "Uploads/Images/burguer.png" },
                new Category { Id  = new IntKey(3), Name = "Premium", Description = "Descricao  de Premium", PathImage = "Uploads/Images/burguer.png" },
                new Category { Id  = new IntKey(4), Name = "Frango", Description = "Descricao de Frango", PathImage = "Uploads/Images/burguer.png" },
                new Category { Id  = new IntKey(5), Name = "Peixe", Description = "Descricao de Peixe",PathImage = "Uploads/Images/burguer.png" }
            );
        }

        private static void SeedStatuses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = new IntKey(1), Name = "Pendente" },
                new Status { Id = new IntKey(2), Name = "Em progresso" },
                new Status { Id = new IntKey(3), Name = "Completo" }
            );
        }

        private static void SeedUsersAndOrders(ModelBuilder modelBuilder)
        {
            var userId = new GuidKey(Guid.NewGuid());

            User user = new() 
            { 
                Id = userId, 
                Name = "Vitor Pires", 
                Email = "vitor@email.com", 
                Password = "password" 
            };

            modelBuilder.Entity<User>().HasData(
                user
            );

            modelBuilder.Entity<Order>().HasData(
                new Order 
                {
                    Id = new IntKey(1),
                    UserId = userId,
                    StatusId = new IntKey(1), 
                    Observation = "Alguma observacao"
                }
            );
        }

        private static void SeedOrderProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct { OrderId = new IntKey(1), ProductId = new IntKey(1) },
                new OrderProduct { OrderId = new IntKey(1), ProductId = new IntKey(2) },
                new OrderProduct { OrderId = new IntKey(1), ProductId = new IntKey(3) }
            );
        }

        private static void SeedProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id = new IntKey(1), 
                    CategoryId = new IntKey(1), 
                    Name = "X-Fruta",
                    Price = 15m,
                    PathImage = "Uploads/Images/burguer.png",
                    BaseDescription = "Pão vegano, hambúrguer de grão-de-bico, alface, tomate, fatias de manga, molho especial",
                    FullDescription = "Uma explosão de sabores naturais! O X-Fruta combina o frescor das frutas com a crocância do hambúrguer vegano de grão-de-bico, criando uma experiência saudável e deliciosa."
                },
                new Product
                {
                    Id = new IntKey(2),
                    CategoryId = new IntKey(2), 
                    Name = "X-Tradicional",
                    BaseDescription = "Pão com gergelim, hambúrguer de carne bovina, queijo cheddar, alface, tomate, ketchup e maionese",
                    Price = 12.50m,
                    PathImage = "Uploads/Images/burguer.png",
                    FullDescription = "O clássico que nunca sai de moda! Um hambúrguer saboroso e equilibrado, perfeito para quem busca o tradicional com um toque especial."
                },
                new Product
                {
                    Id = new IntKey(3),
                    CategoryId = new IntKey(3), 
                    Name = "X-Bacon Premium",
                    BaseDescription = "Pão brioche, hambúrguer artesanal, queijo gouda, fatias de bacon crocante, cebola caramelizada, rúcula e molho barbecue",
                    Price = 25,
                    PathImage = "Uploads/Images/burguer.png",
                    FullDescription = "Uma experiência gourmet com bacon crocante e queijo gouda. O X-Bacon Premium é perfeito para os amantes de um sabor robusto e marcante."
                },
                new Product
                {
                    Id = new IntKey(4),
                    CategoryId = new IntKey(4), 
                    Name = "X-Frango Crocante",
                    BaseDescription = "Pão com gergelim, peito de frango empanado, queijo prato, alface americana, maionese temperada",
                    Price = 18,
                    PathImage = "Uploads/Images/burguer.png",
                    FullDescription = "Delicioso e leve, o X-Frango Crocante combina um frango empanado crocante com a suavidade da maionese temperada."
                },
                new Product
                {
                    Id = new IntKey(5),
                    CategoryId = new IntKey(5), 
                    Name = "X-Salmão",
                    BaseDescription = "Pão integral, hambúrguer de salmão grelhado, cream cheese, alface e molho de dill",
                    Price = 28,
                    PathImage = "Uploads/Images/burguer.png",
                    FullDescription = "Elegante e saudável, o X-Salmão traz um toque de sofisticação com salmão grelhado e um molho de dill único."
                },
                new Product
                {
                    Id = new IntKey(6),
                    CategoryId = new IntKey(1), 
                    Name = "X-Tofu Especial",
                    BaseDescription = "Pão vegano, tofu grelhado, cogumelos salteados, rúcula, molho de tahine",
                    Price = 20,
                    PathImage = "Uploads/Images/burguer.png",
                    FullDescription = "O X-Tofu Especial é uma escolha refinada e saudável, com tofu grelhado e cogumelos que encantam os paladares mais exigentes."
                },
                new Product
                {
                    Id = new IntKey(7),
                    CategoryId = new IntKey(2), 
                    Name = "X-Queijo Duplo",
                    BaseDescription = "Pão de hambúrguer, hambúrguer de carne bovina, queijo cheddar duplo, molho especial",
                    Price = 16,
                    PathImage = "Uploads/Images/burguer.png",
                    FullDescription = "Para os fãs de queijo, o X-Queijo Duplo é uma explosão de sabor com camadas generosas de cheddar e um molho irresistível."
                },
                new Product
                {
                    Id = new IntKey(8),
                    CategoryId = new IntKey(3), 
                    Name = "X-Cordeiro Gourmet",
                    BaseDescription = "Pão ciabatta, hambúrguer de cordeiro, queijo feta, tomate seco, rúcula e molho de hortelã",
                    Price = 30,
                    PathImage = "Uploads/Images/burguer.png",
                    FullDescription = "Uma criação exclusiva com cordeiro suculento, queijo feta e um toque refrescante de hortelã para uma experiência inesquecível."
                }
            );
        }
    }
}