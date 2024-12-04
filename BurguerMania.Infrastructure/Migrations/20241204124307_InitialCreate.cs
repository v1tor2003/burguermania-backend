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
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
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
                    { 1, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9076), new TimeSpan(0, 0, 0, 0, 0)), "", "Vegano", "", null },
                    { 2, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 0, 0, 0, 0)), "", "Clássico", "", null },
                    { 3, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 0, 0, 0, 0)), "", "Premium", "", null },
                    { 4, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9371), new TimeSpan(0, 0, 0, 0, 0)), "", "Frango", "", null },
                    { 5, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 0, 0, 0, 0)), "", "Peixe", "", null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(1826), new TimeSpan(0, 0, 0, 0, 0)), "Pendente", null },
                    { 2, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(2567), new TimeSpan(0, 0, 0, 0, 0)), "Em progresso", null },
                    { 3, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 477, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 0, 0, 0, 0)), "Completo", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password", "UpdatedAt" },
                values: new object[] { new Guid("8d401fa8-8555-4f89-8ced-51f2101b3ab7"), new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(8521), new TimeSpan(0, 0, 0, 0, 0)), "vitor@email.com", "Vitor Pires", "password", null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "StatusId", "UpdatedAt", "UserId", "Value" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 479, DateTimeKind.Unspecified).AddTicks(49), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new Guid("8d401fa8-8555-4f89-8ced-51f2101b3ab7"), 52.50m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BaseDescription", "CategoryId", "CreatedAt", "FullDescription", "Name", "PathImage", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Pão vegano, hambúrguer de grão-de-bico, alface, tomate, fatias de manga, molho especial", 1, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)), "Uma explosão de sabores naturais! O X-Fruta combina o frescor das frutas com a crocância do hambúrguer vegano de grão-de-bico, criando uma experiência saudável e deliciosa.", "X-Fruta", "", 15m, null },
                    { 2, "Pão com gergelim, hambúrguer de carne bovina, queijo cheddar, alface, tomate, ketchup e maionese", 2, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 0, 0, 0, 0)), "O clássico que nunca sai de moda! Um hambúrguer saboroso e equilibrado, perfeito para quem busca o tradicional com um toque especial.", "X-Tradicional", "", 12.50m, null },
                    { 3, "Pão brioche, hambúrguer artesanal, queijo gouda, fatias de bacon crocante, cebola caramelizada, rúcula e molho barbecue", 3, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), "Uma experiência gourmet com bacon crocante e queijo gouda. O X-Bacon Premium é perfeito para os amantes de um sabor robusto e marcante.", "X-Bacon Premium", "", 25m, null },
                    { 4, "Pão com gergelim, peito de frango empanado, queijo prato, alface americana, maionese temperada", 4, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 0, 0, 0, 0)), "Delicioso e leve, o X-Frango Crocante combina um frango empanado crocante com a suavidade da maionese temperada.", "X-Frango Crocante", "", 18m, null },
                    { 5, "Pão integral, hambúrguer de salmão grelhado, cream cheese, alface e molho de dill", 5, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5320), new TimeSpan(0, 0, 0, 0, 0)), "Elegante e saudável, o X-Salmão traz um toque de sofisticação com salmão grelhado e um molho de dill único.", "X-Salmão", "", 28m, null },
                    { 6, "Pão vegano, tofu grelhado, cogumelos salteados, rúcula, molho de tahine", 1, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5321), new TimeSpan(0, 0, 0, 0, 0)), "O X-Tofu Especial é uma escolha refinada e saudável, com tofu grelhado e cogumelos que encantam os paladares mais exigentes.", "X-Tofu Especial", "", 20m, null },
                    { 7, "Pão de hambúrguer, hambúrguer de carne bovina, queijo cheddar duplo, molho especial", 2, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 0, 0, 0, 0)), "Para os fãs de queijo, o X-Queijo Duplo é uma explosão de sabor com camadas generosas de cheddar e um molho irresistível.", "X-Queijo Duplo", "", 16m, null },
                    { 8, "Pão ciabatta, hambúrguer de cordeiro, queijo feta, tomate seco, rúcula e molho de hortelã", 3, new DateTimeOffset(new DateTime(2024, 12, 4, 12, 43, 7, 478, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 0, 0, 0, 0)), "Uma criação exclusiva com cordeiro suculento, queijo feta e um toque refrescante de hortelã para uma experiência inesquecível.", "X-Cordeiro Gourmet", "", 30m, null }
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
