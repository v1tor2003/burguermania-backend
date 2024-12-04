﻿// <auto-generated />
using System;
using BurguerMania.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurguerMania.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241204124307_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("BurguerMania.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9076), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            Name = "Vegano",
                            PathImage = ""
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            Name = "Clássico",
                            PathImage = ""
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            Name = "Premium",
                            PathImage = ""
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9371), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            Name = "Frango",
                            PathImage = ""
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            Name = "Peixe",
                            PathImage = ""
                        });
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 479, DateTimeKind.Unspecified).AddTicks(49), new TimeSpan(0, 0, 0, 0, 0)),
                            StatusId = 1,
                            UserId = new Guid("8d401fa8-8555-4f89-8ced-51f2101b3ab7"),
                            Value = 52.50m
                        });
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            OrderId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            OrderId = 1,
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BaseDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseDescription = "Pão vegano, hambúrguer de grão-de-bico, alface, tomate, fatias de manga, molho especial",
                            CategoryId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "Uma explosão de sabores naturais! O X-Fruta combina o frescor das frutas com a crocância do hambúrguer vegano de grão-de-bico, criando uma experiência saudável e deliciosa.",
                            Name = "X-Fruta",
                            PathImage = "",
                            Price = 15m
                        },
                        new
                        {
                            Id = 2,
                            BaseDescription = "Pão com gergelim, hambúrguer de carne bovina, queijo cheddar, alface, tomate, ketchup e maionese",
                            CategoryId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "O clássico que nunca sai de moda! Um hambúrguer saboroso e equilibrado, perfeito para quem busca o tradicional com um toque especial.",
                            Name = "X-Tradicional",
                            PathImage = "",
                            Price = 12.50m
                        },
                        new
                        {
                            Id = 3,
                            BaseDescription = "Pão brioche, hambúrguer artesanal, queijo gouda, fatias de bacon crocante, cebola caramelizada, rúcula e molho barbecue",
                            CategoryId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "Uma experiência gourmet com bacon crocante e queijo gouda. O X-Bacon Premium é perfeito para os amantes de um sabor robusto e marcante.",
                            Name = "X-Bacon Premium",
                            PathImage = "",
                            Price = 25m
                        },
                        new
                        {
                            Id = 4,
                            BaseDescription = "Pão com gergelim, peito de frango empanado, queijo prato, alface americana, maionese temperada",
                            CategoryId = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "Delicioso e leve, o X-Frango Crocante combina um frango empanado crocante com a suavidade da maionese temperada.",
                            Name = "X-Frango Crocante",
                            PathImage = "",
                            Price = 18m
                        },
                        new
                        {
                            Id = 5,
                            BaseDescription = "Pão integral, hambúrguer de salmão grelhado, cream cheese, alface e molho de dill",
                            CategoryId = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5320), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "Elegante e saudável, o X-Salmão traz um toque de sofisticação com salmão grelhado e um molho de dill único.",
                            Name = "X-Salmão",
                            PathImage = "",
                            Price = 28m
                        },
                        new
                        {
                            Id = 6,
                            BaseDescription = "Pão vegano, tofu grelhado, cogumelos salteados, rúcula, molho de tahine",
                            CategoryId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5321), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "O X-Tofu Especial é uma escolha refinada e saudável, com tofu grelhado e cogumelos que encantam os paladares mais exigentes.",
                            Name = "X-Tofu Especial",
                            PathImage = "",
                            Price = 20m
                        },
                        new
                        {
                            Id = 7,
                            BaseDescription = "Pão de hambúrguer, hambúrguer de carne bovina, queijo cheddar duplo, molho especial",
                            CategoryId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "Para os fãs de queijo, o X-Queijo Duplo é uma explosão de sabor com camadas generosas de cheddar e um molho irresistível.",
                            Name = "X-Queijo Duplo",
                            PathImage = "",
                            Price = 16m
                        },
                        new
                        {
                            Id = 8,
                            BaseDescription = "Pão ciabatta, hambúrguer de cordeiro, queijo feta, tomate seco, rúcula e molho de hortelã",
                            CategoryId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 0, 0, 0, 0)),
                            FullDescription = "Uma criação exclusiva com cordeiro suculento, queijo feta e um toque refrescante de hortelã para uma experiência inesquecível.",
                            Name = "X-Cordeiro Gourmet",
                            PathImage = "",
                            Price = 30m
                        });
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(1826), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Pendente"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(2567), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Em progresso"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Completo"
                        });
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d401fa8-8555-4f89-8ced-51f2101b3ab7"),
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(8521), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "vitor@email.com",
                            Name = "Vitor Pires",
                            Password = "password"
                        });
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Order", b =>
                {
                    b.HasOne("BurguerMania.Domain.Entities.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurguerMania.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.OrderProduct", b =>
                {
                    b.HasOne("BurguerMania.Domain.Entities.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurguerMania.Domain.Entities.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Product", b =>
                {
                    b.HasOne("BurguerMania.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurguerMania.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
