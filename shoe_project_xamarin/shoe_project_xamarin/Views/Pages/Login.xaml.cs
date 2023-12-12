using Newtonsoft.Json;
using Plugin.Toast;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models;
using shoe_project_xamarin.Models.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        bool isOpen = false;
        ApiSettings apiSettings = new ApiSettings();

        public Login()
        {
            InitializeComponent();
        }

        async private void BtnLogin_Clicked(object sender, EventArgs e)
        {

            string userName = EntryUserName.Text;
            string userPassword = EntryPassword.Text;
            try
            {

                var loginData = new
                {
                    userName = userName,
                    userPassword = userPassword
                };

                var jsonLoginData = JsonConvert.SerializeObject(loginData);

                using (var client = new HttpClient())
                {
                    string apiUrl = apiSettings.BuildApiClientHost("/auth/login");

                    var content = new StringContent(jsonLoginData, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiUrl, content);

                    if (response != null)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var successContent = await response.Content.ReadAsStringAsync();
                            var loginSuccessResponse = JsonConvert.DeserializeObject<LoginSuccessResponse>(successContent);
                            string messageRes = loginSuccessResponse.message;
                            string userNameRes = loginSuccessResponse.userName;
                            /* CrossToastPopUp.Current.ShowToastSuccess($"{messageRes} : welcome : {userNameRes}");*/

                            DisplayAlert("Thông báo!", $"{messageRes} : {userNameRes}", "OK");

                            MainPage mainPage = new MainPage();
                            NavigationPage navigationPage = new NavigationPage(mainPage);
                            App.Current.MainPage = navigationPage;

                        }
                        else
                        {
                            var errorContent = await response.Content.ReadAsStringAsync();
                            var errorResponse = JsonConvert.DeserializeObject<LoginErrorResponse>(errorContent);
                            string errorMessage = errorResponse.message;
                            string errorDescription = errorResponse.errors?.FirstOrDefault();

                            CrossToastPopUp.Current.ShowToastError($"{errorMessage}: {errorDescription}");
                        }
                    }
                    else
                    {
                        CrossToastPopUp.Current.ShowToastError("Login failed! Response is empty.");
                    }
                }
            }
            catch (Exception ex)
            {
                CrossToastPopUp.Current.ShowToastError($"Login failed: {ex.Message}");
            }

        }


        private async void LabelSignUp_Tapped(object sender, EventArgs e)
        {
            Register register = new Register();
            NavigationPage navigationPage = new NavigationPage(register);
            App.Current.MainPage = navigationPage;
        }

        private void EyePassword_Tapped(object sender, EventArgs e)
        {

            Image imageSender = (Image)sender;
            if (isOpen)
            {
                imageSender.Source = "https://static-00.iconduck.com/assets.00/eye-password-hide-icon-2048x2048-c8pmhg0p.png";
                EntryPassword.IsPassword = true;
                isOpen = false;
            }
            else
            {
                imageSender.Source = "https://cdn-icons-png.flaticon.com/512/65/65000.png";
                EntryPassword.IsPassword = false;
                isOpen = true;

            }
        }


    }
}