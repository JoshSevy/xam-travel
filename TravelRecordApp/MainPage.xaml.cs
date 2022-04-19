using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void loginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            // Need to add more form validation for user login
            // 
            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEmpty && isPasswordEmpty)
            {
                DisplayAlert("No Entry", "Please enter a valid email and password", "Ok");
            }

            if (isEmailEmpty)
            {
                DisplayAlert("No Entry", "Please enter a valid email", "Ok");
            }

            if (isPasswordEmpty)
            {
                DisplayAlert("No Entry", "Please enter a password!","Ok");
            }
            else
            {
                Navigation.PushAsync(new Homepage());
            }
        }

        void registerButton_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Preview", "Coming Soon!", "Ok");
        }
    }
}
