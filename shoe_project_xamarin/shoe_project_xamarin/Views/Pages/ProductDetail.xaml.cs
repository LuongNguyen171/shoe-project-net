using Acr.UserDialogs;
using Android.Telephony.Data;
using Newtonsoft.Json;
using Plugin.Toast;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models;
using shoe_project_xamarin.Models.DTOs.Cart;
using shoe_project_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetail : ContentPage
    {
        ApiSettings apiSettings = new ApiSettings();
        private Product selectedProduct;

        public ProductDetail(Product product)
        {
            InitializeComponent();
            GetProductImagesByProductIdAsync(product.productId);
            selectedProduct = product;

            /*List<Product> products = new List<Product>()
            {
                new Product {productId = 1,productImage = "shoeimg.jpg"},
                new Product {productId = 2,productImage = "shoeimg2.jpg"},
                new Product {productId = 3,productImage = "shoesImage.jpg"},
                new Product {productId = 4,productImage = "shoeimg.jpg"},
            };

            listImg.ItemsSource = products;*/

            productNameLabel.Text = product.productName;
            tagLabel.Text = "Tag: basketball";
            priceLabel.Text = $"Giá: {product.productPrice:C0}";
            productDescriptionLabel.Text = product.productDescribe;
        }

        public async void GetProductImagesByProductIdAsync(int productId)
        {
            string apiUrl = apiSettings.BuildApiClientHost($"/product/getProductImagesByProductId/{productId}");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(apiUrl);

                    ObservableCollection<ProductImage> productImages = JsonConvert.DeserializeObject<ObservableCollection<ProductImage>>(response);

                   
                    listImg.ItemsSource = productImages;

                    if (productImages.Count > 0)
                    {
                        ImageSample.Source = productImages[0].productImage;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is ProductImage selectedProduct)
            {
                ImageSample.Source = selectedProduct.productImage;
            }
        }

        private async void add_cart_btn_Clicked(object sender, EventArgs e)
        {
            decimal qt = selectedProduct.productPrice * int.Parse(quantityLabel.Text);
            await DisplayAlert("Cart Information", qt.ToString(), "OK");

            try
            {
             string accessToken = SecureStorage.GetAsync("AccessToken").Result;
                if (!string.IsNullOrEmpty(accessToken))
                {
                    using (var client = new HttpClient())
                    {
                        string apiUrl = apiSettings.BuildApiClientHost("/auth/GetUserInfo");

                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                        UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                        var response = await client.GetAsync(apiUrl);
                        UserDialogs.Instance.HideLoading();

                        if (response.IsSuccessStatusCode)
                        {
                            string existingCartData = await SecureStorage.GetAsync("cart");
                            List<CartItem> cartItems = string.IsNullOrEmpty(existingCartData)
                                ? new List<CartItem>()
                                : JsonConvert.DeserializeObject<List<CartItem>>(existingCartData);

                            if (!cartItems.Any(item => item.productId == selectedProduct?.productId))
                            {
                                CartItem cartItem = new CartItem
                                {
                                    productId = selectedProduct.productId,
                                    productImage = selectedProduct?.productImage,
                                    productPrice = selectedProduct != null ? selectedProduct.productPrice : 0,
                                    quantity = int.Parse(quantityLabel.Text),
                                    productName = selectedProduct?.productName,
                                    totalPriceItem = selectedProduct.productPrice * int.Parse(quantityLabel.Text),
                                };

                                cartItems.Add(cartItem);

                                string updatedCartData = JsonConvert.SerializeObject(cartItems);
                                await SecureStorage.SetAsync("cart", updatedCartData);

                                CrossToastPopUp.Current.ShowToastSuccess("Add to cart successfully!");
                            }
                            else
                            {
                                CrossToastPopUp.Current.ShowToastWarning("Product already exists in the cart!");
                            }


                        }
                        else
                        {
                            CrossToastPopUp.Current.ShowToastError("Login session expired!");
                            UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                            await Navigation.PushModalAsync(new Login());
                            UserDialogs.Instance.HideLoading();
                        }
                    }

                }
                else
                {
                    CrossToastPopUp.Current.ShowToastError("You have not logged in yet!");
                    UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                    await Navigation.PushModalAsync(new Login());
                    UserDialogs.Instance.HideLoading();
                }

            }
            catch (Exception ex)
            {

               
                DisplayAlert("Notification!", $"{ex.Message}", "OK");

            }
        }
    }
}