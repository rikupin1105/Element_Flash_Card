using ElementFlash.Services;
using ElementFlash.ViewModels;
using ElementFlash.Views;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace ElementFlash
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
                    fonts.AddFont("NotoSansJP-Regular.ttf", "NotoJP");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<ElementService>();
            builder.Services.AddSingleton<SettingService>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<QuizViewModel>();
            builder.Services.AddTransient<SettingViewModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<QuizPage>();
            builder.Services.AddTransient<SettingsPage>();

            return builder.Build();
        }
    }
}
