﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shellLogin02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Xamarin.Essentials.SecureStorage.SetAsync("isLogged", "2");
            await Shell.Current.GoToAsync("//page1");

            //await Shell.Current.GoToAsync("//main");

//            Application.Current.MainPage = new AppShell();
//            await Shell.Current.GoToAsync("//main");

        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}