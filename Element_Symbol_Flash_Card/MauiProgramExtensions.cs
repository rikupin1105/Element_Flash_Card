using Element_Symbol_Flash_Card.Views;

namespace Element_Symbol_Flash_Card;

public static class MauiProgramExtensions
{
    public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
    {
        builder
            .UseMauiApp<App>();

        // TODO: Add the entry points to your Apps here.
        // See also: https://learn.microsoft.com/dotnet/maui/fundamentals/app-lifecycle
        builder.Services.AddTransient<AppShell, AppShell>();


        return builder;
    }
}
