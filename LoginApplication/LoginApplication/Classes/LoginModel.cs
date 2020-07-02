using LoginApplication.Utils;
using SQLite;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginApplication.Classes
{
    public class LoginModel
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //get
        //{
        //    return Password;
        //}
        //set
        //{
        //    Password = value;
        //    //PropertyChaned(this, new PropertyChangedEventArgs("Password"));
        //    RegexUtils.ValidPasswordLenth().IsMatch(value) ? "password must be atleast 5 to 12 charachters in length" : "Password is matching charachter length");
        //}
        public LoginModel()
        {

        }
    }
}
