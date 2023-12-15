using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shoe_project_server.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImageField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "productImage",
                table: "productImages",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productImage",
                table: "productImages");
        }
    }
}
