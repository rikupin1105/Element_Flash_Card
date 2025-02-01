using ElementFlashCard.Mobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElementFlashCard.Mobile.Service
{
    public interface ISettingService
    {
        void Save(Setting setting);
        Setting GetSetting();
    }
    public class SettingService : ISettingService
    {
        public Setting GetSetting()
        {
            return new Setting
            {
                Random = Preferences.Default.Get("Random", false),
                IsDisplayedElementNumber = Preferences.Default.Get("IsDisplayedElementNumber", true)
            };
        }
        public void Save(Setting setting)
        {
            Preferences.Default.Set("Random", setting.Random);
            Preferences.Default.Set("IsDisplayedElementNumber", setting.IsDisplayedElementNumber);
        }
    }
}
