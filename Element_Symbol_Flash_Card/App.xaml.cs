﻿using Element_Symbol_Flash_Card.Model;
using Element_Symbol_Flash_Card.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Element_Symbol_Flash_Card
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
