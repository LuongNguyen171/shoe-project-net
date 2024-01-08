using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shoe_project_server.Migrations
{
    /// <inheritdoc />
    public partial class updatekeypurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_purchaseHistories",
                table: "purchaseHistories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_purchaseHistories",
                table: "purchaseHistories",
                columns: new[] { "orderId", "userId", "productId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_purchaseHistories",
                table: "purchaseHistories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_purchaseHistories",
                table: "purchaseHistories",
                columns: new[] { "orderId", "userId" });
        }
    }
}
