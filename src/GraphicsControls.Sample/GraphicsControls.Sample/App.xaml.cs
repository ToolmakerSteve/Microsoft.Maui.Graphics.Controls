﻿using Application = Microsoft.Maui.Controls.Application;

namespace GraphicsControls.Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new CustomControlsPage();
            MainPage = new CustomNavigationPage(new MainPage());
        }
    }
}
