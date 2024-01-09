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
using System.Runtime.Remoting.Contexts;
using Org.Apache.Commons.Logging;
using Android.Util;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRendererAndroid))]
namespace shoe_project_xamarin.Droid
{
    public class CustomPickerRendererAndroid : PickerRenderer
    {
        IElementController ElementController => Element as IElementController;
        private AlertDialog _dialog;
        public CustomPickerRendererAndroid(Android.Content.Context context) : base(context)
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
                Control.Text = null;

                Control.Click += Control_Click;

            }
        }
        protected override void Dispose(bool disposing)
        {
            Control.Click -= Control_Click;
            base.Dispose(disposing);
        }

        [Obsolete]
        private void Control_Click(object sender, EventArgs e)
        {
            Picker model = Element as CustomPicker;
            // Custom Picker
            var picker = new NumberPicker(Context);
            picker.SetTextColor(Android.Graphics.Color.Black);

            if (model.Items != null && model.Items.Any())
            {
                picker.MaxValue = model.Items.Count - 1;
                picker.MinValue = 0;

                picker.SetDisplayedValues(model.Items.ToArray());
                for (int i = 0; i < picker.ChildCount; i++)
                {
                    var child = picker.GetChildAt(i) as TextView;
                    if (child != null)
                    {
                        child.SetTextColor(Android.Graphics.Color.Black);
                    }
                }

                picker.SetBackgroundColor(Android.Graphics.Color.White);
                picker.SetDisplayedValues(model.Items.ToArray());
                picker.TextSize = 100;
                picker.WrapSelectorWheel = false;
                picker.Value = model.SelectedIndex;

            }
            var titleLayoutParams = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent, // width
                ViewGroup.LayoutParams.WrapContent // height
            );

            // Create Layout
            var titletextview = new TextView(Context)
            {
                Text = model.Title ?? " ",
                TextSize = 35,
                LayoutParameters = titleLayoutParams
            };

            titletextview.SetTextColor(Android.Graphics.Color.White);
            titletextview.SetBackgroundColor(Android.Graphics.Color.ParseColor("#2196F3"));

            var layout = new LinearLayout(Context) { Orientation = Orientation.Vertical };
            layout.AddView(titletextview);
            layout.AddView(picker);

            layout.SetBackgroundColor(Android.Graphics.Color.White);

            //Set Padding for title
            int titlePaddingInDp = 8;
            int titlePaddingInPixels = (int)TypedValue.ApplyDimension(
                ComplexUnitType.Dip, titlePaddingInDp, Resources.DisplayMetrics
            );
            titletextview.SetPadding(titlePaddingInPixels, titlePaddingInPixels, titlePaddingInPixels, titlePaddingInPixels);

            ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, true);

            // Custom Popup
            AlertDialog.Builder builder = new AlertDialog.Builder(Context);
            builder.SetView(layout);

            builder.SetTitle("");

            builder.SetNegativeButton("Cancel  ", (s, a) =>
            {
                ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
                Control?.ClearFocus();
                _dialog = null;
            });
            builder.SetPositiveButton("Ok ", (s, a) =>
            {
                ElementController.SetValueFromRenderer(Picker.SelectedIndexProperty, picker.Value);
                if (Element != null)
                {
                    if (model.Items.Count > 0 && Element.SelectedIndex >= 0)
                        Control.Text = model.Items[Element.SelectedIndex];
                    ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
                    Control?.ClearFocus();
                }
                _dialog = null;
            });

            _dialog = builder.Create();

            _dialog.Window.SetBackgroundDrawable(new ColorDrawable(Android.Graphics.Color.White));

            _dialog.DismissEvent += (sender, args) =>
            {
                ElementController?.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
            };
            _dialog.Show();
        }
    }
}