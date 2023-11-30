using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shoe_project_server.Migrations
{
    /// <inheritdoc />
    public partial class defaultRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userRole",
                table: "AspNetUsers",
                newName: "UserRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserRole",
                table: "AspNetUsers",
                newName: "userRole");
        }
    }
}
