using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using Java.Lang;
using shoe_project_xamarin.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using shoe_project_xamarin;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRendererAndroid))]
namespace shoe_project_xamarin.Droid
{
    public class CustomPickerRendererAndroid : PickerRenderer
    {
        public CustomPickerRendererAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                // Add Down Arrow Image
                Drawable customDrawable = Context.GetDrawable(Resource.Drawable.down_arrow); 

                int width = 40; 
                int height = 40; 
                customDrawable.SetBounds(0, 0, width, height);

                Control.SetCompoundDrawablesRelative(null, null, customDrawable, null);
                
                // Set Background Border 
                Control.Background = null;
                // Set Padding
                Control.SetPadding(0, 0, 0, 0);
            }
        }
    }
}