using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Element_Symbol_Flash_Card.Service;
using Element_Symbol_Flash_Card.Droid;
using Element_Symbol_Flash_Card.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(SettingService))]
namespace Element_Symbol_Flash_Card.Droid
{
    internal class SettingService : ISettingService
    {
        public void Save(Setting setting)
        {
            var prefs = Android.App.Application.Context.GetSharedPreferences("pref", FileCreationMode.Private);
            var editor = prefs.Edit();

            //Boolean型の場合
            editor.PutBoolean("Random", setting.Random);
            editor.PutBoolean("IsDisplayedElementNumber", setting.IsDisplayedElementNumber);

            editor.Commit();
        }
        public Setting GetSetting()
        {
            var prefs = Android.App.Application.Context.GetSharedPreferences("pref", FileCreationMode.Private);

            //Boolean型の場合
            bool random = prefs.GetBoolean("Random", false);
            bool isDisplayedElementNumber = prefs.GetBoolean("IsDisplayedElementNumber", true);


            var setInfo = new Setting() 
            {
                Random = random,
                IsDisplayedElementNumber = isDisplayedElementNumber
            };
            return setInfo;
        }

    }
}