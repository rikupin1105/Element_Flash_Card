using ElementFlashCard.Mobile.ViewModel;

namespace ElementFlashCard.Mobile.View;

public partial class FlashCard1 : ContentPage
{
    public FlashCard1(FlashCard1ViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}