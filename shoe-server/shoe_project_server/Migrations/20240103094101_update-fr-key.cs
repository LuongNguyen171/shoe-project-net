using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shoe_project_server.Migrations
{
    /// <inheritdoc />
    public partial class updatefrkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_purchaseHistories_productId",
                table: "purchaseHistories",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseHistories_products_productId",
                table: "purchaseHistories",
                column: "productId",
                principalTable: "products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_purchaseHistories_products_productId",
                table: "purchaseHistories");

            migrationBuilder.DropIndex(
                name: "IX_purchaseHistories_productId",
                table: "purchaseHistories");
        }
    }
}
