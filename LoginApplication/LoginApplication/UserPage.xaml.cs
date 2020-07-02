using LoginApplication.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
 
        public UserPage()
        {
            InitializeComponent();
        }
       

        private async void Button_Clicked(object loginModel, EventArgs e)
        {
            await this.Navigation.PushAsync(new RegisterPage() { BindingContext = loginModel });
        }
    }
}