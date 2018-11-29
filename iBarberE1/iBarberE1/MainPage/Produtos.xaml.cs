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
	public partial class Produtos : ContentPage
	{
		public Produtos ()
		{
			InitializeComponent();

            List<Produtos_Agendar> produtos = new List<Produtos_Agendar>();

            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 1", Valor = "R$ 30,00", Img = "prod1.jpg", Check = "CheckOff.png" });
            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 2", Valor = "R$ 15,00", Img = "prod2.jpg", Check = "CheckOff.png" });
            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 3", Valor = "R$ 20,00", Img = "prod3.jpg", Check = "CheckOff.png" });
            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 4", Valor = "R$ 15,00", Img = "prod4.jpg", Check = "CheckOff.png" });

            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 5", Valor = "R$ 200,00", Img = "prod1.jpg", Check = "CheckOff.png" });
            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 6", Valor = "R$ 85,00", Img = "prod2.jpg", Check = "CheckOff.png" });
            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 7", Valor = "R$ 30,00", Img = "prod3.jpg", Check = "CheckOff.png" });
            produtos.Add(new Produtos_Agendar() { Descricao = "Produto 8", Valor = "R$ 10,00", Img = "prod4.jpg", Check = "CheckOff.png" });

            ListProducts.ItemsSource = produtos;
    }
	}
}