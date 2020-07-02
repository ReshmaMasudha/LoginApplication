using LoginApplication.Classes;
using LoginApplication.Utils;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public SQLiteConnection conn = null;

        public RegisterPage()
        {
            InitializeComponent();
            conn = new SQLiteConnection(App.FilePath);
            conn.CreateTable<LoginModel>();
        }

       

        private async void RegisterButton_Clicked_1(object sender, EventArgs e)
        {
            if (!RegexUtils.ValidPasswordLenth(PasswordEntry.Text))
            {
                await DisplayAlert("error", "Password should of charachters between 5 to 12 ", "Ok");
            }
            else if (!RegexUtils.ValidCharachters(PasswordEntry.Text))
            {
                await DisplayAlert("error", "Password must be alphanumeric ", "Ok");
            }
            //else if (!RegexUtils.ValidSequenceChecker(PasswordEntry.Text,2))
            //{
            //    await DisplayAlert("error", "Password should not have sequence of characters ", "Ok");
            //}
            else
            {
               LoginModel loginModel = new LoginModel()
                    {

                        UserName = UserNameEntry.Text,
                        Password = PasswordEntry.Text,
                    };
                    conn.Insert (loginModel);
                    await this.Navigation.PopAsync();
            }
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var LoginModelInfo = this.BindingContext as LoginModel;
            UserNameEntry.Text = LoginModelInfo.UserName;
            PasswordEntry.Text = LoginModelInfo.Password;
        }
      

    }

}
