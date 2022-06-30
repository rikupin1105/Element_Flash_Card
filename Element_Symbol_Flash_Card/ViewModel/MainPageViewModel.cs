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
        public AsyncReactiveCommand SymbolToNameRandomCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand NameToSymbolCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand NameToSymbolRandomCommand { get; set; } = new AsyncReactiveCommand();
        public MainPageViewModel() 
        {
            SymbolToNameCommand.Subscribe(async _ => await RequestSymbolToName.RaiseAsync(false));
            SymbolToNameRandomCommand.Subscribe(async _ => await RequestSymbolToName.RaiseAsync(true));

            NameToSymbolCommand.Subscribe(async _ => await RequestNameToSymbol.RaiseAsync(false));
            NameToSymbolRandomCommand.Subscribe(async _ => await RequestNameToSymbol.RaiseAsync(param: true));
        }
        public INavigationRequest<bool> RequestSymbolToName { get; } = new NavigationRequest<bool>();
        public INavigationRequest<bool> RequestNameToSymbol { get; } = new NavigationRequest<bool>();
    }
}
