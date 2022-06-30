using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Element_Symbol_Flash_Card.ViewModel;

namespace Element_Symbol_Flash_Card.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FlashCard1();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FlashCard1();

        }
    }
}
