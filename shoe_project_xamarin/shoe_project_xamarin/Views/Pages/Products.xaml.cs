using Android.Accounts;
using Newtonsoft.Json;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Products : ContentPage
    {
        private int tapCount = 0;
        readonly ApiSettings apiSettings = new ApiSettings();
        public Products()
        {
            InitializeComponent();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            string apiUrl = apiSettings.BuildApiClientHost("/Product/getAllProducts");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(apiUrl);

                    ObservableCollection<Product> products = JsonConvert.DeserializeObject<ObservableCollection<Product>>(response);

                    CVProducts.ItemsSource = products;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void FavouriteProduct_Tapped(object sender, EventArgs e)
        {
            tapCount++;
            Image imageSender = (Image)sender;
            if (tapCount % 2 == 0)
            {
                imageSender.Source = "FavouriteBlackIcon.png";
            }
            else
            {
                imageSender.Source = "FavouriteRedIcon.png";
            }
        }
    }
}