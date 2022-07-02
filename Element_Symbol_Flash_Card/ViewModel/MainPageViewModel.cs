using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Kamishibai.Xamarin.Forms.Mvvm;
using Reactive.Bindings;

namespace Element_Symbol_Flash_Card.ViewModel
{
    internal class MainPageViewModel
    {
        public AsyncReactiveCommand SymbolToNameCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand NameToSymbolCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand NameToSymbolRandomCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand SettingCommand { get; set; } = new AsyncReactiveCommand();
        public MainPageViewModel() 
        {
            SymbolToNameCommand.Subscribe(async _ => await RequestSymbolToName.RaiseAsync());
            NameToSymbolCommand.Subscribe(async _ => await RequestNameToSymbol.RaiseAsync());
            SettingCommand.Subscribe(async _ => await RequestSetting.RaiseAsync());
        }
        public INavigationRequest RequestSymbolToName { get; } = new NavigationRequest();
        public INavigationRequest RequestNameToSymbol { get; } = new NavigationRequest();
        public INavigationRequest RequestSetting { get; } = new NavigationRequest();
    }
}
