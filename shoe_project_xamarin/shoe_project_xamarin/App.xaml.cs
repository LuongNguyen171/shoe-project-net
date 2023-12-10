using shoe_project_xamarin.Services;
using shoe_project_xamarin.Views;
using shoe_project_xamarin.Views.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
