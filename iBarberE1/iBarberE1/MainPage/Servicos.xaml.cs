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
	public partial class Servicos : ContentPage
	{
		public Servicos ()
		{
			InitializeComponent ();

            List<Servico_color> servicos = new List<Servico_color>();

            servicos.Add(new Servico_color() { Descricao = "Corte de tesoura", Valor = "R$ 30,00", Check = "CheckOff.png" });
            servicos.Add(new Servico_color() { Descricao = "Corte de máquina", Valor = "R$ 15,00", Check = "CheckOff.png" });
            servicos.Add(new Servico_color() { Descricao = "Corte de tesoura + máquina", Valor = "R$ 20,00", Check = "CheckOff.png" });
            servicos.Add(new Servico_color() { Descricao = "Barba", Valor = "R$ 15,00", Check = "CheckOff.png" });

            servicos.Add(new Servico_color() { Descricao = "Progressiva", Valor = "R$ 200,00", Check = "CheckOff.png" });
            servicos.Add(new Servico_color() { Descricao = "Alisamento", Valor = "R$ 85,00", Check = "CheckOff.png" });
            servicos.Add(new Servico_color() { Descricao = "Sobrancelha", Valor = "R$ 30,00", Check = "CheckOff.png" });
            servicos.Add(new Servico_color() { Descricao = "Pé do cabelo", Valor = "R$ 10,00", Check = "CheckOff.png" });

            ListServices.ItemsSource = servicos;
        }
	}
}