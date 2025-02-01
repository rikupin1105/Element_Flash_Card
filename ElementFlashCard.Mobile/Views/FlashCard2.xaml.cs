using ElementFlashCard.Mobile.ViewModel;

namespace ElementFlashCard.Mobile.View
{
    public partial class FlashCard2 : ContentPage
    {
        public FlashCard2(FlashCard2ViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}