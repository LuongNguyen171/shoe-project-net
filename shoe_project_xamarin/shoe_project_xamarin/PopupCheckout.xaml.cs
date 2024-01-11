using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Newtonsoft.Json;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using shoe_project_xamarin.Models.DTOs.Cart;
using shoe_project_xamarin.Models.DTOs.Order;

namespace shoe_project_xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupCheckout : Rg.Plugins.Popup.Pages.PopupPage
	{
        ApiSettings apiSettings = new ApiSettings();
        private List<CartItem> cartItems;


        public PopupCheckout ()
		{
			InitializeComponent ();
            GetUserInfor();
            GetCartData();
          
        }

        
        private void GetCartData()
        {
            try
            {
                string cartData = SecureStorage.GetAsync("cart").Result;
                if (!string.IsNullOrEmpty(cartData))
                {
                    cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cartData);
                }
                else
                {
                    cartItems = new List<CartItem>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting cart data: {ex.Message}");
                cartItems = new List<CartItem>();
            }
            listImg.ItemsSource = cartItems;
        }

        private async void GetUserInfor()
        {
            string accessToken = SecureStorage.GetAsync("AccessToken").Result;
            try
            {

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

                            var content = await response.Content.ReadAsStringAsync();
                            var userInfo = JsonConvert.DeserializeAnonymousType(content, new
                            {
                                id = string.Empty,
                                userName = string.Empty,
                                userEmail = string.Empty
                            });
                            name_entry.Text = userInfo.userName;
                            mail_entry.Text = userInfo.userEmail;
                        }
                        else
                        {
                            Console.WriteLine("Error!", "Tokens expire.", "OK");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error!", "The user is not logged in.", "OK");
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("user!", $"{ex.Message}", "OK");

            }
        }

        private void Checkout_btn_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Loading Please Wait...");
            HandleOrderSendmail();
            UserDialogs.Instance.HideLoading();

        }

        private async void HandleOrderSendmail()
        {
            try
            {
                string userId = SecureStorage.GetAsync("UserId").Result; 
                string orderStatus = "Processing";
                string customerPhone =phone_entry.Text;

                string cartData = await SecureStorage.GetAsync("cart");
                List<CartItem> cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cartData);

                List<ProductItem> purchaseHistoryItems = cartItems.Select(item => new ProductItem
                {
                    productId = item.productId,
                    productQuantity = item.quantity
                }).ToList();

                OrderSendMail orderSendMail = new OrderSendMail
                {
                    userId = userId,
                    orderStatus = orderStatus,
                    customerPhone = customerPhone,
                    purchaseHistoryItems = purchaseHistoryItems
                };

                await CallApiOrderSendMail(orderSendMail);


            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }

        private async Task CallApiOrderSendMail(OrderSendMail orderSendMail)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string apiUrl = apiSettings.BuildApiClientHost("/order/addOrder");

                    var jsonOrderSendMail = JsonConvert.SerializeObject(orderSendMail);
                    var content = new StringContent(jsonOrderSendMail, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        await DisplayAlert("Success", "Order placed successfully!", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Error", $"API request failed. {response.ReasonPhrase}", "OK");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }
        }
    }
}