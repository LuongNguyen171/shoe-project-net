using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shoe_project_server.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeypi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "producId",
                table: "productImages",
                newName: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_productImages_productId",
                table: "productImages",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_productImages_products_productId",
                table: "productImages",
                column: "productId",
                principalTable: "products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productImages_products_productId",
                table: "productImages");

            migrationBuilder.DropIndex(
                name: "IX_productImages_productId",
                table: "productImages");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "productImages",
                newName: "producId");
        }
    }
}
