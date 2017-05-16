using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LockedNote
{
    public partial class Login : ContentPage
    {
        //need to save user and pass when app close
        public static string Username = "abcdef";
        public static string Password = "123456";



        public Login()
        {
            InitializeComponent();
        }

        async void LoginClicked(object sender, EventArgs args)
        {
            if (User.Text == Username)
            {
                if (Pass.Text == Password)
                {
                    await Navigation.PushAsync(new MainNote());
                    User.Text = "";
                    Pass.Text = "";
                }
            }
            else
            {
                Error.Text = "Wrong Username or Password!";
            }
        }

        async void ForgetClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Forget());
        }



        //will remove after working
        protected override void OnAppearing()
        {
            User.Text = Username;
            Pass.Text = Password;
            base.OnAppearing();
        }
    }
}
