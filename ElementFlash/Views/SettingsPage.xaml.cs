using ElementFlash.ViewModels;

namespace ElementFlash.Views;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}