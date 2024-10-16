using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fuckscrum.api.Migrations
{
    /// <inheritdoc />
    public partial class m2mprojectmember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Members_MemberModelId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_MemberModelId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "MemberModelId",
                table: "Projects");

            migrationBuilder.CreateTable(
                name: "MemberModelProjectModel",
                columns: table => new
                {
                    MembersId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberModelProjectModel", x => new { x.MembersId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_MemberModelProjectModel_Members_MembersId",
                        column: x => x.MembersId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberModelProjectModel_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberModelProjectModel_ProjectsId",
                table: "MemberModelProjectModel",
                column: "ProjectsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberModelProjectModel");

            migrationBuilder.AddColumn<int>(
                name: "MemberModelId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_MemberModelId",
                table: "Projects",
                column: "MemberModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Members_MemberModelId",
                table: "Projects",
                column: "MemberModelId",
                principalTable: "Members",
                principalColumn: "Id");
        }
    }
}
