using Android.Net;
using Newtonsoft.Json;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace shoe_project_xamarin.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        readonly ApiSettings apiSettings = new ApiSettings();
        private ObservableCollection<Product> _newProductList;
        private ObservableCollection<Product> _trendsList;
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
        public ObservableCollection<Product> TrendsList
        {
            get { return _trendsList; }
            set
            {
                if (_trendsList != value)
                {
                    _trendsList = value;
                    OnPropertyChanged(nameof(TrendsList));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public async Task LoadDataAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = apiSettings.BuildApiClientHost("/product/getAllProducts");
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    string content = await response.Content.ReadAsStringAsync();

                    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(content);

                    int skipCount = Math.Max(0, products.Count - 5);
                    List<Product> selectedProducts = products.Skip(skipCount).Take(5).ToList();
                    NewProductList = new ObservableCollection<Product>(selectedProducts);

                    TrendsList = new ObservableCollection<Product>(products.Take(5));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
