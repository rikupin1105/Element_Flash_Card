using ElementFlash.ViewModels;

namespace ElementFlash.Views;

public partial class QuizPage : ContentPage
{
    public QuizPage(QuizViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        MainLabel.SizeChanged += (_, __) => AdjustFontSize();
        MainLabel.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(Label.Text))
                AdjustFontSize();
        };
    }

    void AdjustFontSize()
    {
        if (MainLabel.Width <= 0)
            return;

        double maxWidth = this.Width*0.9;

        double fontSize = 72;
        double minFontSize = 20;

        MainLabel.FontSize = fontSize;

        while (fontSize > minFontSize)
        {
            var size = MainLabel.Measure(double.PositiveInfinity, double.PositiveInfinity);

            if (size.Width <= maxWidth)
                break;

            fontSize *= 0.9;
            MainLabel.FontSize = fontSize;
        }
    }
}