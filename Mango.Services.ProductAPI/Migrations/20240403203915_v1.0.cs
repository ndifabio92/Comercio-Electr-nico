using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLocalPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "Created", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price", "Updated" },
                values: new object[,]
                {
                    { 1, "Appetizer", new DateTime(2024, 4, 3, 20, 39, 15, 75, DateTimeKind.Utc).AddTicks(4567), " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", null, "https://placehold.co/603x403", "Samosa", 15.0, null },
                    { 2, "Appetizer", new DateTime(2024, 4, 3, 20, 39, 15, 75, DateTimeKind.Utc).AddTicks(4603), " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", null, "https://placehold.co/602x402", "Paneer Tikka", 13.99, null },
                    { 3, "Dessert", new DateTime(2024, 4, 3, 20, 39, 15, 75, DateTimeKind.Utc).AddTicks(4725), " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", null, "https://placehold.co/601x401", "Sweet Pie", 10.99, null },
                    { 4, "Entree", new DateTime(2024, 4, 3, 20, 39, 15, 75, DateTimeKind.Utc).AddTicks(4734), " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", null, "https://placehold.co/600x400", "Pav Bhaji", 15.0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
