using Android.Webkit;
using shoe_project_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        private Timer timer;
        public List<Banner> Banners = new List<Banner>
        {
                new Banner { Heading = "ADIDAS COLLECTION", Message = "40% Discount", Caption = "BEST DISCOUNT THIS SEASON", Image = "banner1.jpg" },
                new Banner { Heading = "NIKE COLLECTION", Message = "UP TO 50% OFF", Caption = "GET 50% OFF ON EVERY ITEM", Image = "banner2.jpg" },
                new Banner { Heading = "SUMMER COLLECTION", Message = "20% Discount", Caption = "UNIQUE COMBINATIONS OF ITEMS", Image = "banner3.jpg" }
        };
        public List<Category> Categories = new List<Category>
        {
                new Category { Name = "Men", Image = "men_shoe_icon" },
                new Category { Name = "Women", Image = "women_shoe_icon" },
                new Category { Name = "Running", Image = "running_shoe_icon" },
                new Category { Name = "Football", Image = "football_shoe_icon" },
                new Category { Name = "Sneaker", Image = "sneaker_shoe_icon" },
                new Category { Name = "Sandals", Image = "sandals_shoe_icon" },
        };

        private readonly ProductViewModel _viewModel;

        public Home()
        {
            InitializeComponent();
            _viewModel = new ProductViewModel();
            cvBanners.ItemsSource = Banners;
            cvCategories.ItemsSource = Categories;
            BindingContext = _viewModel;
            LoadData();
        }

        private async void LoadData()
        {
            await _viewModel.LoadDataAsync();
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

        public class Category
        {
            public string Name { get; set; }
            public string Image { get; set; }
        }

    }
}
