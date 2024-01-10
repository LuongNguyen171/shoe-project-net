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
using static Android.Provider.MediaStore;
using static shoe_project_xamarin.Views.Pages.Home;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        private Timer timer;
        public List<Banner> Banners { get => GetBanners(); }

        private ProductViewModel _viewModel;

        public Home()
        {
            InitializeComponent();
            _viewModel = new ProductViewModel();
          /*  cvBanners.ItemsSource = Banners;*/
            BindingContext = _viewModel;
            LoadData();

            List<Images> images = new List<Images>()
            {

                new Images(){Title="Image 1",Url="https://tokyolife.vn/wp/wp-content/uploads/2022/08/z3605752590998_a9af1d076b9f454e302e7080b42ceb3d-1-1024x642.jpg"},
                new Images(){Title="Image 2",Url="http://file.hstatic.net/1000326314/article/1-_b40d8dad86db43afb36cc889dbb7f723.jpg"},
                new Images(){Title="Image 3",Url="https://cdn.tgdd.vn//News/1468021//giamgia-quan-ao-giay-dep-845x414.jpg"},
                new Images(){Title="Image 3",Url="udao.jpg"},
            };

            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                Carousel.Position = (Carousel.Position + 1) % images.Count;
                return true;
            }));
            Carousel.ItemsSource = images;
        }

        private async void LoadData()
        {
            await _viewModel.LoadDataAsync();
        }

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "ADIDAS COLLECTION", Message = "40% Discount", Caption = "BEST DISCOUNT THIS SEASON", Image = "banner1.jpg" });
            bannerList.Add(new Banner { Heading = "NIKE COLLECTION", Message = "UP TO 50% OFF", Caption = "GET 50% OFF ON EVERY ITEM", Image = "banner2.jpg" });
            bannerList.Add(new Banner { Heading = "SUMMER COLLECTION", Message = "20% Discount", Caption = "UNIQUE COMBINATIONS OF ITEMS", Image = "banner3.jpg" });
            return bannerList;
        }
/*
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
*/
        public class Banner
        {
            public string Heading { get; set; }
            public string Message { get; set; }
            public string Caption { get; set; }
            public string Image { get; set; }
        }
        public class Images
        {
            public string Title { get; set; }
            public string Url { get; set; }
        }

    }
}