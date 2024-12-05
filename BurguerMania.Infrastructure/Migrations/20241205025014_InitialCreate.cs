using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguerMania.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PathImage = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PathImage = table.Column<string>(type: "TEXT", nullable: false),
                    BaseDescription = table.Column<string>(type: "TEXT", nullable: false),
                    FullDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Observation = table.Column<string>(type: "TEXT", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "PathImage", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(1969), new TimeSpan(0, 0, 0, 0, 0)), "Descricao de Vegano", "Vegano", "Uploads/Images/burguer.png", null },
                    { 2, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, 0, 0, 0, 0)), "Descricao de Classico", "Clássico", "Uploads/Images/burguer.png", null },
                    { 3, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 0, 0, 0, 0)), "Descricao  de Premium", "Premium", "Uploads/Images/burguer.png", null },
                    { 4, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(2814), new TimeSpan(0, 0, 0, 0, 0)), "Descricao de Frango", "Frango", "Uploads/Images/burguer.png", null },
                    { 5, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(2815), new TimeSpan(0, 0, 0, 0, 0)), "Descricao de Peixe", "Peixe", "Uploads/Images/burguer.png", null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 344, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)), "Pendente", null },
                    { 2, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 344, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 0, 0, 0, 0)), "Em progresso", null },
                    { 3, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 344, DateTimeKind.Unspecified).AddTicks(5165), new TimeSpan(0, 0, 0, 0, 0)), "Completo", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "UpdatedAt" },
                values: new object[] { new Guid("b3143bd0-26cc-4c13-a16e-6cf409265dc7"), new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 346, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 0, 0, 0, 0)), "vitor@email.com", "Vitor Pires", "password", null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "Observation", "Quantity", "StatusId", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 346, DateTimeKind.Unspecified).AddTicks(4136), new TimeSpan(0, 0, 0, 0, 0)), "Alguma observacao", 0, 1, null, new Guid("b3143bd0-26cc-4c13-a16e-6cf409265dc7") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BaseDescription", "CategoryId", "CreatedAt", "FullDescription", "Name", "PathImage", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Pão vegano, hambúrguer de grão-de-bico, alface, tomate, fatias de manga, molho especial", 1, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 0, 0, 0, 0)), "Uma explosão de sabores naturais! O X-Fruta combina o frescor das frutas com a crocância do hambúrguer vegano de grão-de-bico, criando uma experiência saudável e deliciosa.", "X-Fruta", "Uploads/Images/burguer.png", 15m, null },
                    { 2, "Pão com gergelim, hambúrguer de carne bovina, queijo cheddar, alface, tomate, ketchup e maionese", 2, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 0, 0, 0, 0)), "O clássico que nunca sai de moda! Um hambúrguer saboroso e equilibrado, perfeito para quem busca o tradicional com um toque especial.", "X-Tradicional", "Uploads/Images/burguer.png", 12.50m, null },
                    { 3, "Pão brioche, hambúrguer artesanal, queijo gouda, fatias de bacon crocante, cebola caramelizada, rúcula e molho barbecue", 3, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 0, 0, 0, 0)), "Uma experiência gourmet com bacon crocante e queijo gouda. O X-Bacon Premium é perfeito para os amantes de um sabor robusto e marcante.", "X-Bacon Premium", "Uploads/Images/burguer.png", 25m, null },
                    { 4, "Pão com gergelim, peito de frango empanado, queijo prato, alface americana, maionese temperada", 4, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(9272), new TimeSpan(0, 0, 0, 0, 0)), "Delicioso e leve, o X-Frango Crocante combina um frango empanado crocante com a suavidade da maionese temperada.", "X-Frango Crocante", "Uploads/Images/burguer.png", 18m, null },
                    { 5, "Pão integral, hambúrguer de salmão grelhado, cream cheese, alface e molho de dill", 5, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(9274), new TimeSpan(0, 0, 0, 0, 0)), "Elegante e saudável, o X-Salmão traz um toque de sofisticação com salmão grelhado e um molho de dill único.", "X-Salmão", "Uploads/Images/burguer.png", 28m, null },
                    { 6, "Pão vegano, tofu grelhado, cogumelos salteados, rúcula, molho de tahine", 1, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(9275), new TimeSpan(0, 0, 0, 0, 0)), "O X-Tofu Especial é uma escolha refinada e saudável, com tofu grelhado e cogumelos que encantam os paladares mais exigentes.", "X-Tofu Especial", "Uploads/Images/burguer.png", 20m, null },
                    { 7, "Pão de hambúrguer, hambúrguer de carne bovina, queijo cheddar duplo, molho especial", 2, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(9276), new TimeSpan(0, 0, 0, 0, 0)), "Para os fãs de queijo, o X-Queijo Duplo é uma explosão de sabor com camadas generosas de cheddar e um molho irresistível.", "X-Queijo Duplo", "Uploads/Images/burguer.png", 16m, null },
                    { 8, "Pão ciabatta, hambúrguer de cordeiro, queijo feta, tomate seco, rúcula e molho de hortelã", 3, new DateTimeOffset(new DateTime(2024, 12, 5, 2, 50, 13, 345, DateTimeKind.Unspecified).AddTicks(9278), new TimeSpan(0, 0, 0, 0, 0)), "Uma criação exclusiva com cordeiro suculento, queijo feta e um toque refrescante de hortelã para uma experiência inesquecível.", "X-Cordeiro Gourmet", "Uploads/Images/burguer.png", 30m, null }
                });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
