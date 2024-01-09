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
            cvBanners.ItemsSource = Banners;
            BindingContext = _viewModel;
            LoadData();
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