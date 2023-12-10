using shoe_project_xamarin.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.DefaultLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Footer : ContentView
    {
        public Footer()
        {
            InitializeComponent();
        }
        private void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            if (sender is Image image && image.GestureRecognizers[0] is TapGestureRecognizer tapGestureRecognizer)
            {
                var url = (string)tapGestureRecognizer.CommandParameter;
                if (!string.IsNullOrEmpty(url))
                {
                    Device.OpenUri(new Uri(url));
                }
            }
        }
    }
}