using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Earth.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAboutContentSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutContents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImagePath", "Introduction", "LastUpdated", "Mission", "Vision" },
                values: new object[] { "/images/about-hero.jpg", "Founded in 2026, HelloEarth began as a small project to bridge the gap between complex planetary science and everyday curiosity. We believe that understanding Earth is the first step toward protecting it. Our platform provides immersive data, historical context, and real-time insights into the systems that sustain life.", new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To empower global citizens with accessible, science-based knowledge about Earth's changing environments.", "A world where environmental literacy is universal, leading to a sustainable and thriving future for all." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutContents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImagePath", "Introduction", "LastUpdated", "Mission", "Vision" },
                values: new object[] { "/images/earth.jpg", "HelloEarth is an educational website that helps users explore and understand our planet.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To educate and inspire people to learn about Earth's systems, environments, and life.", "A future where everyone understands and cares for our planet." });
        }
    }
}
