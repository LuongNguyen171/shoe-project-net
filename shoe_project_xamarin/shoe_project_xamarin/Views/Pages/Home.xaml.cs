using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        private Timer timer;
        public List<Banner> Banners { get => GetBanners(); }
        public List<Product> NewProductList { get => GetNewProductList(); }
        public List<Product> TrendsList { get => GetTrendsList(); }
        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "ADIDAS COLLECTION", Message = "40% Discount", Caption = "BEST DISCOUNT THIS SEASON", Image = "banner1.jpg" });
            bannerList.Add(new Banner { Heading = "NIKE COLLECTION", Message = "UP TO 50% OFF", Caption = "GET 50% OFF ON EVERY ITEM", Image = "banner2.jpg" });
            bannerList.Add(new Banner { Heading = "SUMMER COLLECTION", Message = "20% Discount", Caption = "UNIQUE COMBINATIONS OF ITEMS", Image = "banner3.jpg" });
            return bannerList;
        }
        private List<Product> GetNewProductList()
        {
            var newProductList = new List<Product>();
            newProductList.Add(new Product() { productId = 1, producerId = 1, productName = "Nike Air Force 1", productPrice = 2300000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            newProductList.Add(new Product() { productId = 2, producerId = 1, productName = "Nike Air Force 2", productPrice = 3000000, ProductDescribe = "Basketball", productImage = "shoeimg2.jpg" });
            newProductList.Add(new Product() { productId = 3, producerId = 1, productName = "Nike Air Force 3", productPrice = 3500000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            newProductList.Add(new Product() { productId = 4, producerId = 1, productName = "Nike Air Force 1", productPrice = 2300000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            newProductList.Add(new Product() { productId = 5, producerId = 1, productName = "Nike Air Force 2", productPrice = 3000000, ProductDescribe = "Basketball", productImage = "shoeimg2.jpg" });
            newProductList.Add(new Product() { productId = 6, producerId = 1, productName = "Nike Air Force 3", productPrice = 3500000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            return newProductList;
        }
        private List<Product> GetTrendsList()
        {
            var trendsList = new List<Product>();
            trendsList.Add(new Product() { productId = 1, producerId = 1, productName = "Nike Air Force 1", productPrice = 2300000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            trendsList.Add(new Product() { productId = 2, producerId = 1, productName = "Nike Air Force 2", productPrice = 3000000, ProductDescribe = "Basketball", productImage = "shoeimg2.jpg" });
            trendsList.Add(new Product() { productId = 3, producerId = 1, productName = "Nike Air Force 3", productPrice = 3500000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            trendsList.Add(new Product() { productId = 1, producerId = 1, productName = "Nike Air Force 4", productPrice = 2300000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            trendsList.Add(new Product() { productId = 2, producerId = 1, productName = "Nike Air Force 5", productPrice = 3000000, ProductDescribe = "Basketball", productImage = "shoeimg2.jpg" });
            trendsList.Add(new Product() { productId = 3, producerId = 1, productName = "Nike Air Force 6", productPrice = 3500000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
            return trendsList;
        }

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(3).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvBanners.Position == 2)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;
            });
        }

        public class Banner
        {
            public string Heading { get; set; }
            public string Message { get; set; }
            public string Caption { get; set; }
            public string Image { get; set; }
        }
    }
}