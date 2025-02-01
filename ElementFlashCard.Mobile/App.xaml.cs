using ElementFlashCard.Mobile.View;

namespace ElementFlashCard.Mobile
{
    public partial class App : Application
    {
        public App(MainPage mainPage)
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}