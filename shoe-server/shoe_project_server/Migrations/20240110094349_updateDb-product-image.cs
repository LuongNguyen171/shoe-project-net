using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace shoe_project_server.Migrations
{
    /// <inheritdoc />
    public partial class updateDbproductimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "productImages",
                columns: new[] { "productImageId", "producId", "productImage" },
                values: new object[,]
                {
                    { 1, 1, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/57558712-5ebe-4abb-9984-879f9e896b4c/air-force-1-07-easyon-shoes-lpjTWM.png" },
                    { 2, 1, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/b39413f0-19c5-4721-8889-86e8156c4047/air-force-1-07-easyon-shoes-lpjTWM.png" },
                    { 3, 1, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7849b40c-9e26-4896-bf85-6d27ac98d29d/air-force-1-07-easyon-shoes-lpjTWM.png" },
                    { 4, 1, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/cc064523-78aa-4f06-b131-ef3943225168/air-force-1-07-easyon-shoes-lpjTWM.png" },
                    { 5, 2, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/c82501e4-317d-4cc4-bd10-e7c947ce31a0/gamma-force-shoes-CbTnH1.png" },
                    { 6, 2, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/af0740bf-bab6-4a1d-93ea-dd4115b936fb/gamma-force-shoes-CbTnH1.png" },
                    { 7, 2, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/9653f191-51fb-43df-aa85-398ae44d1295/gamma-force-shoes-CbTnH1.png" },
                    { 8, 2, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/53692ee7-26db-4e4f-906f-45eeebc46ec4/gamma-force-shoes-CbTnH1.png" },
                    { 9, 3, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/2b050e6a-4647-4647-babb-32b1fa8d33a6/lebron-xxi-tahitian-younger-older-basketball-shoes-Q0HDBH.png" },
                    { 10, 3, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/a56f1cff-1334-477b-926e-b07e4fcb4729/lebron-xxi-tahitian-younger-older-basketball-shoes-Q0HDBH.png" },
                    { 11, 3, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/24fc445c-b42f-42f2-b134-ae849cba631e/lebron-xxi-tahitian-younger-older-basketball-shoes-Q0HDBH.png" },
                    { 12, 3, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/6c39c260-aeb3-48cd-aaee-5f013c1b1016/lebron-xxi-tahitian-younger-older-basketball-shoes-Q0HDBH.png" },
                    { 13, 8, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/416e1d81-a6ed-4401-93d1-e5e26ea37a8d/air-force-1-07-shoes-CMNWtG.png" },
                    { 14, 8, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/df294700-a1c1-49f8-827f-8d254400a71b/air-force-1-07-shoes-CMNWtG.png" },
                    { 15, 8, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/3b6360aa-fa59-4c97-9504-28c856f79759/air-force-1-07-shoes-CMNWtG.png" },
                    { 16, 8, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/cba89489-eb3b-485a-8d12-02b01fc49f25/air-force-1-07-shoes-CMNWtG.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "productImages",
                keyColumn: "productImageId",
                keyValue: 16);
        }
    }
}
