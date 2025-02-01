using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Google.Android.Material.Color;
using Android.Views;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui;

namespace Element_Symbol_Flash_Card.Droid
{
    [Activity(Label = "元素フラッシュカード", Icon = "@drawable/icon", Theme = "@style/AppTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : Microsoft.Maui.MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //DynamicColors.ApplyToActivityIfAvailable(this);
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#FEFBFF"));

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}