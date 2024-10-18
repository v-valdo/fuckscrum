using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fuckscrum.api.Migrations
{
    /// <inheritdoc />
    public partial class dbfeaturecategoryenums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Projects",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Projects");
        }
    }
}
