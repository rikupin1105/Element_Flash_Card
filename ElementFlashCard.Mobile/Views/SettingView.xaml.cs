using ElementFlashCard.Mobile.ViewModel;

namespace ElementFlashCard.Mobile.View
{
    public partial class SettingView : ContentPage
    {
        public SettingView(SettingViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}