using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Earth.Migrations
{
    /// <inheritdoc />
    public partial class AddQuestionEarthModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Question",
                table: "EarthModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Question",
                table: "EarthModel");
        }
    }
}
