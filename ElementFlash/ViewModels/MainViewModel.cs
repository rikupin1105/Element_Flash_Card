using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ElementFlash.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isSymbolToName = true;

    [RelayCommand]
    private async Task Start(string mode)
    {
        await Shell.Current.GoToAsync(
            $"{nameof(Views.QuizPage)}?Mode={mode}");
    }

    [RelayCommand]
    private async Task OpenSettings()
    {
        await Shell.Current.GoToAsync(nameof(Views.SettingsPage));
    }
}