using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;

namespace LockedNote
{

    public partial class MainNote : ContentPage
    {
        //need to save this note when app close
        public static string note;
        

        public MainNote()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            note = Editor.Text;



            base.OnDisappearing();
        }

        protected override void OnAppearing()
        {
            Editor.Text = note;
            base.OnAppearing();
            
        }

        
    }

}
