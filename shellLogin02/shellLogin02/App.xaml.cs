using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using shellLogin02.Services;
using shellLogin02.Views;
using System.Diagnostics;

namespace shellLogin02
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("onstart");

        }

        protected override void OnSleep()
        {
            Debug.WriteLine("onsleep");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("onresume");

        }
    }
}
