using Newtonsoft.Json;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models;
using shoe_project_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage, INotifyPropertyChanged
    {
        readonly ApiSettings apiSettings = new ApiSettings();
        private Timer timer;
        public List<Banner> Banners { get => GetBanners(); }
        public List<Product> TrendsList { get => GetTrendsList(); }
        private ObservableCollection<Product> _newProductList;
        public ObservableCollection<Product> NewProductList
        {
            get { return _newProductList; }
            set
            {
                if (_newProductList != value)
                {
                    _newProductList = value;
                    OnPropertyChanged(nameof(NewProductList));
                }
            }
        }
        public Home()
        {
            InitializeComponent();
            this.BindingContext = this;
            LoadData();
        }

        private async void LoadData()
        {
            string apiUrl = apiSettings.BuildApiClientHost("/Product/getAllProducts");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(apiUrl);

                    ObservableCollection<Product> products = JsonConvert.DeserializeObject<ObservableCollection<Product>>(response);

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        NewProductList = products;
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public new event PropertyChangedEventHandler PropertyChanged;
        protected new virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async Task<ObservableCollection<Product>> GetNewProductListAsync()
        {
            try
            {
                var newProductList = new ObservableCollection<Product>();

                // Thay đổi đường dẫn API của bạn tại đây
                string apiUrl = apiSettings.BuildApiClientHost("/Product/getAllProducts"); ;

                using (HttpClient client = new HttpClient())
                {
                    // Gọi API và lấy dữ liệu
                    var response = await client.GetStringAsync(apiUrl);

                    // Chuyển đổi JSON thành danh sách sản phẩm
                    newProductList = JsonConvert.DeserializeObject<ObservableCollection<Product>>(response);

                }
                return newProductList;
            }
            catch (Exception ex)
            {
                // Xử lý khi có lỗi không mong muốn
                // Ví dụ: Ghi log hoặc hiển thị thông báo lỗi
                await DisplayAlert("Error", $"An unexpected error occurred: {ex.Message}", "OK");

                return null;
            }
        }

        //private ObservableCollection<Product> GetNewProductList()
        //{
        //    var newProductList = new ObservableCollection<Product>();
        //    newProductList.Add(new Product() { productId = 1, producerId = 1, productName = "Nike Air Force 1", productPrice = 2300000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
        //    newProductList.Add(new Product() { productId = 2, producerId = 1, productName = "Nike Air Force 2", productPrice = 3000000, ProductDescribe = "Basketball", productImage = "shoeimg2.jpg" });
        //    newProductList.Add(new Product() { productId = 3, producerId = 1, productName = "Nike Air Force 3", productPrice = 3500000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
        //    newProductList.Add(new Product() { productId = 1, producerId = 1, productName = "Nike Air Force 4", productPrice = 2300000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
        //    newProductList.Add(new Product() { productId = 2, producerId = 1, productName = "Nike Air Force 5", productPrice = 3000000, ProductDescribe = "Basketball", productImage = "shoeimg2.jpg" });
        //    newProductList.Add(new Product() { productId = 3, producerId = 1, productName = "Nike Air Force 6", productPrice = 3500000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg" });
        //    return newProductList;
        //}

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

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "ADIDAS COLLECTION", Message = "40% Discount", Caption = "BEST DISCOUNT THIS SEASON", Image = "banner1.jpg" });
            bannerList.Add(new Banner { Heading = "NIKE COLLECTION", Message = "UP TO 50% OFF", Caption = "GET 50% OFF ON EVERY ITEM", Image = "banner2.jpg" });
            bannerList.Add(new Banner { Heading = "SUMMER COLLECTION", Message = "20% Discount", Caption = "UNIQUE COMBINATIONS OF ITEMS", Image = "banner3.jpg" });
            return bannerList;
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