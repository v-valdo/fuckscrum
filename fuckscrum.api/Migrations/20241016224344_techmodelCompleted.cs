using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fuckscrum.api.Migrations
{
    /// <inheritdoc />
    public partial class techmodelCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectModelTechnologyModel_TechnologyModel_TechStackId",
                table: "ProjectModelTechnologyModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TechnologyModel",
                table: "TechnologyModel");

            migrationBuilder.RenameTable(
                name: "TechnologyModel",
                newName: "TechStack");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechStack",
                table: "TechStack",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectModelTechnologyModel_TechStack_TechStackId",
                table: "ProjectModelTechnologyModel",
                column: "TechStackId",
                principalTable: "TechStack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectModelTechnologyModel_TechStack_TechStackId",
                table: "ProjectModelTechnologyModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TechStack",
                table: "TechStack");

            migrationBuilder.RenameTable(
                name: "TechStack",
                newName: "TechnologyModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechnologyModel",
                table: "TechnologyModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectModelTechnologyModel_TechnologyModel_TechStackId",
                table: "ProjectModelTechnologyModel",
                column: "TechStackId",
                principalTable: "TechnologyModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
