using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fuckscrum.api.Migrations
{
    /// <inheritdoc />
    public partial class techM2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechnologyModel_Projects_ProjectModelId",
                table: "TechnologyModel");

            migrationBuilder.DropIndex(
                name: "IX_TechnologyModel_ProjectModelId",
                table: "TechnologyModel");

            migrationBuilder.DropColumn(
                name: "ProjectModelId",
                table: "TechnologyModel");

            migrationBuilder.CreateTable(
                name: "ProjectModelTechnologyModel",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "int", nullable: false),
                    TechStackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectModelTechnologyModel", x => new { x.ProjectsId, x.TechStackId });
                    table.ForeignKey(
                        name: "FK_ProjectModelTechnologyModel_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectModelTechnologyModel_TechnologyModel_TechStackId",
                        column: x => x.TechStackId,
                        principalTable: "TechnologyModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectModelTechnologyModel_TechStackId",
                table: "ProjectModelTechnologyModel",
                column: "TechStackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectModelTechnologyModel");

            migrationBuilder.AddColumn<int>(
                name: "ProjectModelId",
                table: "TechnologyModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TechnologyModel_ProjectModelId",
                table: "TechnologyModel",
                column: "ProjectModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_TechnologyModel_Projects_ProjectModelId",
                table: "TechnologyModel",
                column: "ProjectModelId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
