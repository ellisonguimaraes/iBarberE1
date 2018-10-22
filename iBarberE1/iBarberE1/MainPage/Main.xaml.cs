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
	public partial class Main : ContentPage
	{
		public Main ()
		{
			InitializeComponent ();

            
            var tapAgendarButton = new TapGestureRecognizer();

            //Binding events
            tapAgendarButton.Tapped += Agendar_Tapped;

            //Associating tap events to the image buttons 
            AgendarButton.GestureRecognizers.Add(tapAgendarButton);



            List<Servico> servicos = new List<Servico>();
            servicos.Add(new Servico() { Descricao = "Corte de tesoura", Valor = "R$ 30,00"});
            servicos.Add(new Servico() { Descricao = "Corte de máquina", Valor = "R$ 15,00" });
            servicos.Add(new Servico() { Descricao = "Corte de tesoura + máquina", Valor = "R$ 20,00" });
            servicos.Add(new Servico() { Descricao = "Barba", Valor = "R$ 15,00" });

            ServiceList.ItemsSource = servicos;


        }

        private void Agendar_Tapped(object sender, EventArgs args)
        {
            DisplayAlert("Agendar", "Agendar_Tapped", "OK");
        }


        private void LbLerMais(object sender, EventArgs args)
        {
            if (!End2.IsVisible)
            {
                End2.IsVisible = true;
                End3.IsVisible = true;

                MoreView.Text = "Ocultar";
            }
            else
            {
                End2.IsVisible = false;
                End3.IsVisible = false;

                MoreView.Text = "Ver mais";
            }
            

            //LblText.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ";
        }

    }
}