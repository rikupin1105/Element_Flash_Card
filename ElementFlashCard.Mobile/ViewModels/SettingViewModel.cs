using ElementFlashCard.Mobile.Model;
using ElementFlashCard.Mobile.Service;
using Reactive.Bindings;

namespace ElementFlashCard.Mobile.ViewModel
{
    public class SettingViewModel
    {
        public ReactiveCommand PropertyChangedCommand { get; set; } = new ReactiveCommand();
        public ReactiveProperty<bool> Random { get; set; }
        public ReactiveProperty<bool> IsDisplayedElementNumber { get; set; }
        public SettingViewModel(ISettingService settingService)
        {
            var setting = settingService.GetSetting();

            Random = new ReactiveProperty<bool>(setting.Random);
            IsDisplayedElementNumber = new ReactiveProperty<bool>(setting.IsDisplayedElementNumber);

            Random.Subscribe(_ => settingService.Save(Get()));
            IsDisplayedElementNumber.Subscribe(_ => settingService.Save(Get()));
        }
        public Setting Get()
        {
            return new Setting()
            {
                Random = Random.Value,
                IsDisplayedElementNumber = IsDisplayedElementNumber.Value
            };
        }
    }
}
