using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iBarberE1.InitPage.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Register(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Login.RegisterPage());
        }

        private void LoginButton(object sender, EventArgs args)
        {
            DisplayAlert("Press Button", "LoginButton", "OK");
        }

        private void RecoveryButton(object sender, EventArgs args)
        {
            DisplayAlert("Press Button", "RecoveryButton", "OK");
        }

        private void ConfirmButton(object sender, EventArgs args)
        {
            DisplayAlert("Press Button", "ConfirmButton", "OK");
        }


    }
}