using Android.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Products()
        {
            InitializeComponent();
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