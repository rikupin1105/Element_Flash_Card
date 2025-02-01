using ElementFlashCard.Mobile.Model;
using ElementFlashCard.Mobile.Service;
using ElementFlashCard.Mobile.View;
using ElementFlashCard.Mobile.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace ElementFlashCard.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular", "OpenSans-Regular");
                    fonts.AddFont("OpenSans-Semibold", "OpenSans-Semibold");
                });

            builder.Services.AddSingleton<ISettingService,SettingService>();
            builder.Services.AddSingleton<INavigationService,NavigationService>();

            builder.Services.AddTransient<FlashCard1ViewModel>();
            builder.Services.AddTransient<FlashCard2ViewModel>();
            builder.Services.AddTransient<SettingViewModel>();
            builder.Services.AddTransient<MainPageViewModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<FlashCard1>();
            builder.Services.AddTransient<FlashCard2>();
            builder.Services.AddTransient<SettingView>();

            Routing.RegisterRoute("FlashCard1", typeof(FlashCard1));
            Routing.RegisterRoute("FlashCard2", typeof(FlashCard2));
            Routing.RegisterRoute("SettingView", typeof(SettingView));
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
