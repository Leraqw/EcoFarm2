using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoFarmAdmin.Migrations
{
    /// <inheritdoc />
    public partial class AddedConcreteIdField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DevObjectsOnLevelsStartup",
                table: "DevObjectsOnLevelsStartup");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DevObjectsOnLevelsStartup",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DevObjectsOnLevelsStartup",
                table: "DevObjectsOnLevelsStartup",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DevObjectsOnLevelsStartup_DevObjectId",
                table: "DevObjectsOnLevelsStartup",
                column: "DevObjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DevObjectsOnLevelsStartup",
                table: "DevObjectsOnLevelsStartup");

            migrationBuilder.DropIndex(
                name: "IX_DevObjectsOnLevelsStartup_DevObjectId",
                table: "DevObjectsOnLevelsStartup");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DevObjectsOnLevelsStartup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DevObjectsOnLevelsStartup",
                table: "DevObjectsOnLevelsStartup",
                columns: new[] { "DevObjectId", "LevelId" });
        }
    }
}
