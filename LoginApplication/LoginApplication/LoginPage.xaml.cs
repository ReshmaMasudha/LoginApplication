using LoginApplication.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public SQLiteConnection conn = null;
        public LoginPage()
        {
            InitializeComponent();
            conn = new SQLiteConnection(App.FilePath);
        }

        async void LoginButton_clicked(object sender, EventArgs e)
        {
            var table = conn.Table<LoginModel>();
            var userinfo = table.FirstOrDefault(x => x.UserName == this.nameEntry.Text && x.Password == this.PasswordEntry.Text);
            if (userinfo != null)
                await Navigation.PushAsync(new MainPage());
            else
                await this.DisplayAlert("error", "Invalid User", "ok");
        }

        async void RegisterButton_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}