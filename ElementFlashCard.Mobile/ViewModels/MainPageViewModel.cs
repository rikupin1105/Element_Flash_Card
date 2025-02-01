using ElementFlashCard.Mobile.Service;
using ElementFlashCard.Mobile.View;
using Reactive.Bindings;

namespace ElementFlashCard.Mobile.ViewModel
{
    public class MainPageViewModel
    {
        public AsyncReactiveCommand SymbolToNameCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand NameToSymbolCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand NameToSymbolRandomCommand { get; set; } = new AsyncReactiveCommand();
        public AsyncReactiveCommand SettingCommand { get; set; } = new AsyncReactiveCommand();
        public MainPageViewModel(INavigationService navigationService)
        {
            SymbolToNameCommand.Subscribe(async _ => await navigationService.NavigateToAsync("FlashCard1"));
            NameToSymbolCommand.Subscribe(async _ => await navigationService.NavigateToAsync("FlashCard2"));
            SettingCommand.Subscribe(async _ => await navigationService.NavigateToAsync("SettingView"));
            //SymbolToNameCommand.Subscribe(async _ => await RequestSymbolToName.RaiseAsync());
            //NameToSymbolCommand.Subscribe(async _ => await RequestNameToSymbol.RaiseAsync());
            //SettingCommand.Subscribe(async _ => await RequestSetting.RaiseAsync());
        }
        //public INavigationRequest RequestSymbolToName { get; } = new NavigationRequest();
        //public INavigationRequest RequestNameToSymbol { get; } = new NavigationRequest();
        //public INavigationRequest RequestSetting { get; } = new NavigationRequest();
    }
}
