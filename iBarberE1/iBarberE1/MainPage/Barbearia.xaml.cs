using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using iBarberE1.Modelo;

namespace iBarberE1.MainPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Barbearia : ContentPage
	{
        public List<Endereco> Enderecos;
        public List<Endereco> EnderecosLittle;

        public Barbearia ()
		{
			InitializeComponent ();



            var tapAgendarButton = new TapGestureRecognizer();

            //Binding events
            tapAgendarButton.Tapped += Agendar_Tapped;

            //Associating tap events to the image buttons 
            AgendarButton.GestureRecognizers.Add(tapAgendarButton);
            

        }



       
        private void Agendar_Tapped(object sender, EventArgs args)
        {
            Navigation.PushAsync(new iBarberE1.Agendar.Menu());
        }
    }
}