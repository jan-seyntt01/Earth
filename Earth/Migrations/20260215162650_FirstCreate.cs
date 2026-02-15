using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Earth.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Explaination",
                table: "EarthModel",
                newName: "Explanation");

            migrationBuilder.AddColumn<string>(
                name: "CoreValues",
                table: "AboutContents",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FoundationYear",
                table: "AboutContents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Impact",
                table: "AboutContents",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "AboutContents",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TargetAudience",
                table: "AboutContents",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutContents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoreValues", "FoundationYear", "Impact", "Purpose", "TargetAudience" },
                values: new object[] { "We are guided by scientific integrity, accessibility, and environmental responsibility. We prioritize evidence-based information, inclusive educational design, and the belief that knowledge should empower individuals to make informed environmental decisions.", 0, "HelloEarth connects thousands of learners each month to structured Earth science content, supporting academic research, classroom education, and environmental awareness initiatives worldwide.", "HelloEarth was created to transform complex Earth system science into structured, accessible knowledge for students and lifelong learners. By organizing environmental information into interconnected themes such as biodiversity, climate, oceans, and continents, the platform encourages holistic understanding of the planet rather than fragmented facts.", "HelloEarth is designed for students, educators, researchers, and environmentally conscious individuals who seek structured and reliable knowledge about Earth's systems. The platform supports both academic learning and independent exploration." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoreValues",
                table: "AboutContents");

            migrationBuilder.DropColumn(
                name: "FoundationYear",
                table: "AboutContents");

            migrationBuilder.DropColumn(
                name: "Impact",
                table: "AboutContents");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "AboutContents");

            migrationBuilder.DropColumn(
                name: "TargetAudience",
                table: "AboutContents");

            migrationBuilder.RenameColumn(
                name: "Explanation",
                table: "EarthModel",
                newName: "Explaination");
        }
    }
}
