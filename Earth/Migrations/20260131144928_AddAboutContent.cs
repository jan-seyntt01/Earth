using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Earth.Migrations
{
    /// <inheritdoc />
    public partial class AddAboutContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutContents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AboutContents",
                columns: new[] { "Id", "ImagePath", "Introduction", "LastUpdated", "Mission", "Vision" },
                values: new object[] { 1, "/images/earth.jpg", "HelloEarth is an educational website that helps users explore and understand our planet.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To educate and inspire people to learn about Earth's systems, environments, and life.", "A future where everyone understands and cares for our planet." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutContents");
        }
    }
}
