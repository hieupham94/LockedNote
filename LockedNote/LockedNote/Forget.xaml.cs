using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LockedNote
{
    public partial class Forget : ContentPage
    {
        public static string A1 = "forget";
        public static string A2 = "pass";

        public Forget()
        {
            InitializeComponent();
        }

        void SubmitClicked(object sender, EventArgs args)
        {
            if (Q1.Text == A1)
            {
                if (Q2.Text == A2)
                {
                    if (newU.Text.Length >= 5 & newP.Text.Length >= 5)
                    {
                        Login.Username = newU.Text;
                        Login.Password = newP.Text;
                        Error.Text = "Changed!";
                    }
                    else
                    {
                        Error.Text = "User or Pass too short!";
                    }
                }
            }
            else
            {
                Error.Text = "Wrong security question!";
            }
        }
    }
}
