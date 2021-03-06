﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eZeljeznice.MobileApp.Services;
using eZeljeznice.MobileApp.Views;

namespace eZeljeznice.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
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
