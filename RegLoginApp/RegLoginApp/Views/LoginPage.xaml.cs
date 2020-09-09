using RegLoginApp.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegLoginApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Signup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            //Ue the database connection to check if the user in the DB
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            //Now the connection has been stablished, we need to check if the user name and password provided exists
            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            //If the uery is not null will navigate to the home page
            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else 
            {
                Device.BeginInvokeOnMainThread(async () =>
                    {
                        var result = await this.DisplayAlert("Error", "Failed User and/or Password","Yes","Cancel");

                        // If user press YES
                        if (result) 
                        {
                            await Navigation.PushAsync(new LoginPage());
                        }
                        // Else user press Cancel
                        else
                        {
                            await Navigation.PushAsync(new LoginPage());
                        }

                    });
            }

        }
    }
}