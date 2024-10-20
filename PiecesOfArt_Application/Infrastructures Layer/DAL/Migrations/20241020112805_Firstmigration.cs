using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PiecesOfArt_Application.Migrations
{
    /// <inheritdoc />
    public partial class Firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loyaltyCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loyaltyCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    LoyaltyCardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_loyaltyCards_LoyaltyCardId",
                        column: x => x.LoyaltyCardId,
                        principalTable: "loyaltyCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "pieceOfArts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pieceOfArts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pieceOfArts_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pieceOfArts_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A 19th-century art movement...", "Impressionism" },
                    { 2, "A period in European history...", "Renaissance" },
                    { 3, "Art that uses shapes and colors...", "Abstract" },
                    { 4, "Artistic work from late 19th century...", "Modern" },
                    { 5, "Art from ancient civilizations...", "Ancient" }
                });

            migrationBuilder.InsertData(
                table: "loyaltyCards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "10% Off", "Bronze" },
                    { 2, "20% Off", "Silver" },
                    { 3, "30% Off", "Gold" },
                    { 4, "40% Off", "Platinum" },
                    { 5, "50% Off", "Crystal" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Age", "Email", "LoyaltyCardId", "Name" },
                values: new object[,]
                {
                    { 1, 26, "nourhan@example.com", 1, "Nourhan" },
                    { 2, 35, "ahmed@example.com", 2, "Ahmed" },
                    { 3, 30, "mona@example.com", 3, "Mona" },
                    { 4, 22, "ali@example.com", 4, "Ali" },
                    { 5, 28, "sara@example.com", 5, "Sara" }
                });

            migrationBuilder.InsertData(
                table: "pieceOfArts",
                columns: new[] { "Id", "CategoryId", "Price", "PublicationDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 100000.0, new DateTime(1889, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starry Night", 1 },
                    { 2, 2, 500000.0, new DateTime(1503, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mona Lisa", 2 },
                    { 3, 3, 120000.0, new DateTime(1923, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Composition VIII", 3 },
                    { 4, 4, 200000.0, new DateTime(1931, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Persistence of Memory", 4 },
                    { 5, 5, 150000.0, new DateTime(2560, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Pyramid", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_pieceOfArts_CategoryId",
                table: "pieceOfArts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_pieceOfArts_UserId",
                table: "pieceOfArts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_users_LoyaltyCardId",
                table: "users",
                column: "LoyaltyCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pieceOfArts");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "loyaltyCards");
        }
    }
}
