using ElementFlash.Model;

namespace ElementFlash.Services
{
    public class SettingService
    {
        private const string ShowAtomicNumberKey = "ShowAtomicNumber";
        private const string IsRandomKey = "IsRandom";

        public Setting Settings { get; private set; } = new();

        public SettingService()
        {
            Load();
        }

        public void Load()
        {
            Settings = new Setting
            {
                ShowAtomicNumber = Preferences.Get(ShowAtomicNumberKey, true),
                IsRandom = Preferences.Get(IsRandomKey, false)
            };
        }

        public void Save()
        {
            Preferences.Set(ShowAtomicNumberKey, Settings.ShowAtomicNumber);
            Preferences.Set(IsRandomKey, Settings.IsRandom);
        }

        public void Update(Setting settings)
        {
            Settings = settings;
            Save();
        }
    }
}
