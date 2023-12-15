using Microsoft.EntityFrameworkCore;
using shoe_project_server.Models;

namespace shoe_project_server.Data.Seeder
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Product>().HasData(
                   new Product() {
                       productId =1,
                       producerId = 1,
                       productName = "Nike Air Force 1 '07",
                       productPrice = 2929000,
                       productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b7d9211c-26e7-431a-ac24-b0540fb3c00f/air-force-1-07-shoes-WrLlWX.png",
                       ProductDescribe = "Sự rạng rỡ vẫn tồn tại trong Nike Air Force 1 '07, phiên bản bóng rổ nguyên bản mang đến sự thay đổi mới mẻ về những gì bạn biết rõ nhất: lớp phủ được khâu bền, lớp hoàn thiện gọn gàng và lượng đèn flash hoàn hảo giúp bạn tỏa sáng."
                   },
                   new Product()
                   {
                       productId = 2,
                       producerId = 1,
                       productName = "Nike Gamma Force",
                       productPrice = 2649000,
                       productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/c82501e4-317d-4cc4-bd10-e7c947ce31a0/gamma-force-shoes-CbTnH1.png",
                       ProductDescribe = "Sự rạng rỡ vẫn tồn tại trong Nike Air Force 1 '07, phiên bản bóng rổ nguyên bản mang đến sự thay đổi mới mẻ về những gì bạn biết rõ nhất: lớp phủ được khâu bền, lớp hoàn thiện gọn gàng và lượng đèn flash hoàn hảo giúp bạn tỏa sáng."
                   },
                   new Product()
                   {
                       productId = 3,
                       producerId = 1,
                       productName = "LeBron XXI 'Tahitian'",
                       productPrice = 4079000,
                       productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/2b050e6a-4647-4647-babb-32b1fa8d33a6/lebron-xxi-tahitian-younger-older-basketball-shoes-Q0HDBH.png",
                       ProductDescribe = "Lần trước, LeBron đã lật ngược kịch bản trận đấu đánh giày của mình mà chỉ có Nhà vua mới có thể làm được. Bản encore thậm chí còn hay hơn. Với các bộ phận Air Zoom và đệm mềm, LeBron XXI (còn được gọi là LeBron 21) mang đến cho bạn sự linh hoạt và sức mạnh mà không cần quá nhiều trọng lượng để làm bạn chậm lại. Lý tưởng cho các cuộc chạy vòng, đột phá nhanh và chạy đua lên xuống sân, chúng giúp bạn tiếp tục chơi ở đỉnh cao của trận đấu cho đến khi tiếng còi cuối cùng vang lên. Bạn đã sẵn sàng chơi chưa?"
                   },
                    new Product()
                    {
                        productId = 4,
                        producerId = 1,
                        productName = "Air Jordan 1 Low SE",
                        productPrice = 2809000,
                        productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/08577b4f-c209-468f-a017-1b3eba9a90b7/air-jordan-1-low-se-older-shoes-HPgPbg.png",
                        ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, chiếc AJ1 này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, như phần trên chắc chắn và đế Nike Air. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị mà bạn muốn giữ lại."
                    },
                     new Product()
                     {
                         productId = 5,
                         producerId = 1,
                         productName = "Jordan 1 Low Alt SE",
                         productPrice = 1789000,
                         productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/06f07a18-b639-4297-9641-2a99f848368d/jordan-1-low-alt-se-younger-shoes-6ksx5c.png",
                         ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ."
                     },
                     //producerId 2

                      new Product()
                      {
                          productId = 6,
                          producerId = 2,
                          productName = "Nike Air Force 1",
                          productPrice = 2809000,
                          productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/a530b99a-cc0b-49ea-8082-db3e1e073910/air-force-1-older-shoes-lNjVW6.png",
                          ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ."
                      },
                      new Product()
                      {
                          productId = 7,
                          producerId = 2,
                          productName = "Nike Air Force 1'07",
                          productPrice = 3239000,
                          productImage = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/cc540e66-3b4e-4e64-a537-cf089a7ca84e/air-force-1-07-shoes-CMNWtG.png",
                          ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ."
                      },
                      new Product()
                      {
                          productId = 8,
                          producerId = 2,
                          productName = "Air Jordan XXXVIII",
                          productPrice = 3959000,
                          productImage = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/cc540e66-3b4e-4e64-a537-cf089a7ca84e/air-force-1-07-shoes-CMNWtG.png",
                          ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ."
                      },
                       new Product()
                       {
                           productId = 9,
                           producerId = 2,
                           productName = "Air Jordan XXXVIII 'FIBA'",
                           productPrice = 3959000,
                           productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/bf877156-a080-457b-bc96-7d7c76378165/air-jordan-xxxviii-fiba-older-shoes-jsK87k.png",
                           ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ."
                       },
                       new Product()
                       {
                           productId = 10,
                           producerId = 2,
                           productName = "Air Jordan 1 Low FlyEase",
                           productPrice = 2489649,
                           productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/ae63e73a-f213-4734-8cf4-c57475e769e5/air-jordan-1-low-flyease-older-shoes-Pr8pJH.png",
                           ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ."
                       },
                        // producerId = 3,
                        new Product()
                        {
                            productId = 11,
                            producerId = 3,
                            productName = "Nike Dunk Low Retro Premium",
                            productPrice = 3519000,
                            productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/35cd473e-b388-4de0-83f5-8a8f3287eef6/dunk-low-retro-shoes-Zc0601.png",
                            ProductDescribe = "Bạn đã bao giờ nhìn vào một quả trứng cá và nghĩ, \"Ồ, tuyệt quá!\"? Với những màu sắc được kết hợp từ thiên nhiên, những cú đá này tôn vinh mọi thứ ở ngoài trời. Tất nhiên, bạn vẫn có được tất cả các đặc điểm thiết kế cổ điển, chẳng hạn như kết cấu phần trên và đế cốc chắc chắn. Và nó đi kèm với một túi dây rút có thể tháo rời — đề phòng trường hợp bạn tìm thấy một quả đấu đặc biệt thú vị để giữ."
                        },
                         new Product()
                         {
                             productId = 12,
                             producerId = 3,
                             productName = "Nike Air Max 90",
                             productPrice = 3829000,
                             productImage = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/ae178e75-38aa-4212-ba98-3f2d45b7ac13/air-max-90-shoes-0MB5rJ.png",
                             ProductDescribe = "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt."
                         },
                          new Product()
                          {
                              productId = 13,
                              producerId = 3,
                              productName = "Nike Go FlyEase",
                              productPrice = 3829000,
                              productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/3251a6d3-13bd-4fc1-8874-272b554f44a1/go-flyease-easy-on-off-shoes-3svRCL.png",
                              ProductDescribe = "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt."
                          },
                           new Product()
                           {
                               productId = 14,
                               producerId = 3,
                               productName = "NikeCourt Royale 2 Next Nature",
                               productPrice = 1609000,
                               productImage = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/767687a0-142e-4d66-b437-998dee9a0a4f/nikecourt-royale-2-next-nature-shoes-RRcr20.png",
                               ProductDescribe = "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt."
                           },
                           new Product()
                           {
                               productId = 15,
                               producerId = 3,
                               productName = "Nike Revolution 7 EasyOn",
                               productPrice = 1789000,
                               productImage = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/b14aba9a-f828-45d3-9607-b687b884aa7d/revolution-7-easyon-road-running-shoes-nNqdwt.png",
                               ProductDescribe = "Hãy thắt dây giày và cảm nhận di sản từ đôi giày chạy bộ vô địch đã giúp định hình thập niên 90 này. Được các tổng thống sử dụng, được cách mạng hóa thông qua sự hợp tác và được tôn vinh nhờ các màu sắc hiếm có, đế ngoài Waffle, đệm Nike Air có thể nhìn thấy và hình ảnh ấn tượng đã giúp nó luôn tồn tại và hoạt động tốt."
                           }
            );
          /*  modelBuilder.Entity<ProductImage>().HasData(
                  new ProductImage()
                  {
                      
                  },*/

        }
    }

}
