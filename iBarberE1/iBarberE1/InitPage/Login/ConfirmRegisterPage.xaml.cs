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
	public partial class ConfirmRegisterPage : ContentPage
	{
		public ConfirmRegisterPage ()
		{
			InitializeComponent ();
		}

        private void ConfirmButton(object sender, EventArgs args)
        {
            DisplayAlert("Press Button", "ConfirmButton", "OK");
        }

        private void SendCodeButton(object sender, EventArgs args)
        {
            DisplayAlert("Press Button", "SendCodeButton", "OK");
        }

    }
}