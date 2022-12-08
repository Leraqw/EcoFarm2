using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoFarmAdmin.Migrations
{
    /// <inheritdoc />
    public partial class AddedCommentaryForLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Commentary",
                table: "Levels",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Commentary",
                table: "Levels");
        }
    }
}
