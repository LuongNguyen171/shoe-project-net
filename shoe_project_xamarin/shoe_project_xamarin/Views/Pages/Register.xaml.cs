﻿using Newtonsoft.Json;
using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Toast;
using Newtonsoft.Json.Serialization;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models.DTOs.Auth;
using Acr.UserDialogs;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        bool isOpen = false;
        ApiSettings apiSettings = new ApiSettings();

        public Register()
        {
            InitializeComponent();
        }
        private void LabelSignIn_Tapped(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Loading Please Wait...");
            Navigation.PushModalAsync(new Login());
            UserDialogs.Instance.HideLoading();
        }

        private async void BtnRegister_Clicked(object sender, EventArgs e)

        {

            string userName = EntryUserName.Text;
            string userEmail = EntryEmail.Text;
            string userPassword = EntryPassword.Text;
            try
            {
                if (userName != null && userEmail != null && userPassword != null)
                {
                    var registerData = new
                    {
                        userName = userName,
                        userEmail = userEmail,
                        userPassword = userPassword
                    };

                    var jsonRegisterData = JsonConvert.SerializeObject(registerData);

                    using (var client = new HttpClient())
                    {
                        string apiUrl = apiSettings.BuildApiClientHost("/auth/register");

                        var content = new StringContent(jsonRegisterData, Encoding.UTF8, "application/json");

                        UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                        var response = await client.PostAsync(apiUrl, content);
                        UserDialogs.Instance.HideLoading();
                        if (response != null)
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var successContent = await response.Content.ReadAsStringAsync();
                                var registerSuccessResponse = JsonConvert.DeserializeObject<RegisterSuccessResponse>(successContent);
                                string messageRes = registerSuccessResponse.message;
                                string userNameRes = registerSuccessResponse.userName;
                                CrossToastPopUp.Current.ShowToastSuccess($"{messageRes}");

                                UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                                await Navigation.PushModalAsync(new Login());
                                UserDialogs.Instance.HideLoading();
                                return;
                            }
                            else
                            {
                                var errorContent = await response.Content.ReadAsStringAsync();
                                var registerErrorResponse = JsonConvert.DeserializeObject<RegisterErrorResponse>(errorContent);
                                string messageRes = registerErrorResponse.message;
                                string descriptionRes = registerErrorResponse.errors?.FirstOrDefault()?.Description;
                                CrossToastPopUp.Current.ShowToastError($"{messageRes} :{descriptionRes}");
                                return;
                            }
                        }
                        else
                        {
                            CrossToastPopUp.Current.ShowToastError("Registration failed! Response is empty.");
                            return;

                        }
                    }
                }
                else
                {
                    CrossToastPopUp.Current.ShowToastError("input cannot be empty!");
                    return;
                }
            }
            catch (Exception ex)
            {
                CrossToastPopUp.Current.ShowToastError("connection errors!");
                return;
            }
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