using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegLoginApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false); //Removes the navigation bar at the top of the page
            InitializeComponent();
        }

        async private void Logout_Handler(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}