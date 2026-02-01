using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Earth.Migrations
{
    /// <inheritdoc />
    public partial class AddExploreTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExploreTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FullContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyFacts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExploreTopics", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutContents",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ExploreTopics",
                columns: new[] { "Id", "CreatedDate", "FullContent", "ImagePath", "KeyFacts", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biodiversity refers to the variety of life on Earth. It includes different plants, animals, and microorganisms, as well as the ecosystems they form.", "/images/bio.jpg", "• Earth has 8.7 million species\n• Rainforests contain 50% of world's species\n• 1 million species face extinction", "Discover the incredible variety of life on Earth.", "Biodiversity" },
                    { 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Climate is the long-term pattern of weather in a particular area. Earth's climate is influenced by the atmosphere, oceans, and land.", "/images/climate.jpg", "• Global temperature rose 1.1°C since 1880\n• CO2 levels are highest in 3 million years\n• Sea levels rising 3.3 mm per year", "Learn about Earth's climate systems and weather patterns.", "Climate" },
                    { 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oceans are large bodies of salt water that cover most of Earth's surface. They regulate climate and support marine life.", "/images/oceans.jpg", "• Oceans cover 71% of Earth\n• Average depth is 3,688 meters\n• Oceans produce 50-80% of Earth's oxygen", "Explore the vast oceans covering 71% of Earth's surface.", "Oceans" },
                    { 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Continents are large land masses on Earth. There are seven continents: Asia, Africa, North America, South America, Antarctica, Europe, and Australia.", "/images/continents.jpg", "• Asia is the largest continent\n• Africa is the 'cradle of humankind'\n• Antarctica holds 90% of world's ice", "Discover Earth's seven continents and their features.", "Continents" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExploreTopics");

            migrationBuilder.UpdateData(
                table: "AboutContents",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
