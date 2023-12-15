using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace shoe_project_server.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserRole = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "favourites",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favourites", x => new { x.userId, x.productId });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    orderStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    orderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    deliveryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    customerPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.orderId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    producerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    producerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producers", x => x.producerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "productDetails",
                columns: table => new
                {
                    productDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productId = table.Column<int>(type: "int", nullable: false),
                    productSize = table.Column<int>(type: "int", nullable: false),
                    productColor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productDetails", x => x.productDetailId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "productImages",
                columns: table => new
                {
                    productImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    producId = table.Column<int>(type: "int", nullable: false),
                    productImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productImages", x => x.productImageId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    producerId = table.Column<int>(type: "int", nullable: false),
                    productName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    productPrice = table.Column<double>(type: "double", nullable: false),
                    productImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductDescribe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "purchaseHistories",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    productQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseHistories", x => new { x.orderId, x.userId });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "productId", "ProductDescribe", "producerId", "productImage", "productName", "productPrice" },
                values: new object[,]
                {
                    { 1, "Sự rạng rỡ vẫn tồn tại trong Nike Air Force 1 '07, phiên bản bóng rổ nguyên bản mang đến sự thay đổi mới mẻ về những gì bạn biết rõ nhất: lớp phủ được khâu bền, lớp hoàn thiện gọn gàng và lượng đèn flash hoàn hảo giúp bạn tỏa sáng.", 1, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b7d9211c-26e7-431a-ac24-b0540fb3c00f/air-force-1-07-shoes-WrLlWX.png", "Nike Air Force 1 '07", 2929000.0 },
                    { 2, "Sự rạng rỡ vẫn tồn tại trong Nike Air Force 1 '07, phiên bản bóng rổ nguyên bản mang đến sự thay đổi mới mẻ về những gì bạn biết rõ nhất: lớp phủ được khâu bền, lớp hoàn thiện gọn gàng và lượng đèn flash hoàn hảo giúp bạn tỏa sáng.", 1, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/c82501e4-317d-4cc4-bd10-e7c947ce31a0/gamma-force-shoes-CbTnH1.png", "Nike Gamma Force", 2649000.0 },
                    { 3, "Lần trước, LeBron đã lật ngược kịch bản trận đấu đánh giày của mình mà chỉ có Nhà vua mới có thể làm được. Bản encore thậm chí còn hay hơn. Với các bộ phận Air Zoom và đệm mềm, LeBron XXI (còn được gọi là LeBron 21) mang đến cho bạn sự linh hoạt và sức mạnh mà không cần quá nhiều trọng lượng để làm bạn chậm lại. Lý tưởng cho các cuộc chạy vòng, đột phá nhanh và chạy đua lên xuống sân, chúng giúp bạn tiếp tục chơi ở đỉnh cao của trận đấu cho đến khi tiếng còi cuối cùng vang lên. Bạn đã sẵn sàng chơi chưa?", 1, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/2b050e6a-4647-4647-babb-32b1fa8d33a6/lebron-xxi-tahitian-younger-older-basketball-shoes-Q0HDBH.png", "LeBron XXI 'Tahitian'", 4079000.0 },
                    { 4, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, chiếc AJ1 này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, như phần trên chắc chắn và đế Nike Air. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị mà bạn muốn giữ lại.", 1, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/08577b4f-c209-468f-a017-1b3eba9a90b7/air-jordan-1-low-se-older-shoes-HPgPbg.png", "Air Jordan 1 Low SE", 2809000.0 },
                    { 5, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ.", 1, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/06f07a18-b639-4297-9641-2a99f848368d/jordan-1-low-alt-se-younger-shoes-6ksx5c.png", "Jordan 1 Low Alt SE", 1789000.0 },
                    { 6, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ.", 2, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/a530b99a-cc0b-49ea-8082-db3e1e073910/air-force-1-older-shoes-lNjVW6.png", "Nike Air Force 1", 2809000.0 },
                    { 7, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ.", 2, "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/cc540e66-3b4e-4e64-a537-cf089a7ca84e/air-force-1-07-shoes-CMNWtG.png", "Nike Air Force 1'07", 3239000.0 },
                    { 8, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ.", 2, "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/cc540e66-3b4e-4e64-a537-cf089a7ca84e/air-force-1-07-shoes-CMNWtG.png", "Air Jordan XXXVIII", 3959000.0 },
                    { 9, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ.", 2, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/bf877156-a080-457b-bc96-7d7c76378165/air-jordan-xxxviii-fiba-older-shoes-jsK87k.png", "Air Jordan XXXVIII 'FIBA'", 3959000.0 },
                    { 10, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ.", 2, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/ae63e73a-f213-4734-8cf4-c57475e769e5/air-jordan-1-low-flyease-older-shoes-Pr8pJH.png", "Air Jordan 1 Low FlyEase", 2489649.0 },
                    { 11, "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ.", 3, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/35cd473e-b388-4de0-83f5-8a8f3287eef6/dunk-low-retro-shoes-Zc0601.png", "Nike Dunk Low Retro Premium", 3519000.0 },
                    { 12, "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt.", 3, "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/ae178e75-38aa-4212-ba98-3f2d45b7ac13/air-max-90-shoes-0MB5rJ.png", "Nike Air Max 90", 3829000.0 },
                    { 13, "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt.", 3, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/3251a6d3-13bd-4fc1-8874-272b554f44a1/go-flyease-easy-on-off-shoes-3svRCL.png", "Nike Go FlyEase", 3829000.0 },
                    { 14, "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt.", 3, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/767687a0-142e-4d66-b437-998dee9a0a4f/nikecourt-royale-2-next-nature-shoes-RRcr20.png", "NikeCourt Royale 2 Next Nature", 1609000.0 },
                    { 15, "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt.", 3, "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/b14aba9a-f828-45d3-9607-b687b884aa7d/revolution-7-easyon-road-running-shoes-nNqdwt.png", "Nike Revolution 7 EasyOn", 1789000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "favourites");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "producers");

            migrationBuilder.DropTable(
                name: "productDetails");

            migrationBuilder.DropTable(
                name: "productImages");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "purchaseHistories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
