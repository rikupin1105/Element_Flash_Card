using System;
using System.Collections.Generic;
using Reactive.Bindings;
using Element_Symbol_Flash_Card.View;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;
using Element_Symbol_Flash_Card.Service;
using Element_Symbol_Flash_Card.Model;

namespace Element_Symbol_Flash_Card.ViewModel
{
    internal class SettingViewModel
    {
        public ReactiveCommand PropertyChangedCommand { get; set; } = new ReactiveCommand();
        public ReactiveProperty<bool> Random { get; set; }
        public ReactiveProperty<bool> IsDisplayedElementNumber { get; set; }
        public SettingViewModel()
        {
            var setting = DependencyService.Get<ISettingService>().GetSetting();
            Random = new ReactiveProperty<bool>(setting.Random);
            IsDisplayedElementNumber = new ReactiveProperty<bool>(setting.IsDisplayedElementNumber);

            Random.Subscribe(_ => DependencyService.Get<ISettingService>().Save(Get()));
            IsDisplayedElementNumber.Subscribe(_ => DependencyService.Get<ISettingService>().Save(Get()));
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
