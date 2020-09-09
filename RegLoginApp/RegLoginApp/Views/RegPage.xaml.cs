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
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(Object sender, System.EventArgs e) 
        {

            //Install in all the projects SQLITE-NET-PCL
            //Add here the connection to the database
            throw new NotImplementedException();

        }
    }
}