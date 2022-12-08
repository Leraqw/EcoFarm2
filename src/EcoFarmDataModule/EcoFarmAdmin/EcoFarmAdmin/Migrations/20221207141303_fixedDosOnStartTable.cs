using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoFarmAdmin.Migrations
{
    /// <inheritdoc />
    public partial class fixedDosOnStartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevObjectsOnLevelsStartup",
                columns: table => new
                {
                    DevObjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevObjectsOnLevelsStartup", x => new { x.DevObjectId, x.LevelId });
                    table.ForeignKey(
                        name: "FK_DevObjectsOnLevelsStartup_DevObjects_DevObjectId",
                        column: x => x.DevObjectId,
                        principalTable: "DevObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevObjectsOnLevelsStartup_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevObjectsOnLevelsStartup_LevelId",
                table: "DevObjectsOnLevelsStartup",
                column: "LevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevObjectsOnLevelsStartup");
        }
    }
}
