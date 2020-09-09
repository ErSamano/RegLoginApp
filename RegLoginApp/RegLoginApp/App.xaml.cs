using System;
using RegLoginApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegLoginApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegPage();
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
