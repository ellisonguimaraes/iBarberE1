﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iBarberE1.InitPage.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}


        private void Cadastrar(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Login.ConfirmRegisterPage());
        }

    }
}