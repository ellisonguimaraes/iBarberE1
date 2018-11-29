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
	public partial class Enderecos : ContentPage
	{
		public Enderecos ()
		{
			InitializeComponent ();

            List<Endereco> Enderecos = new List<Endereco>();

            Enderecos.Add(new Endereco { Img = "barber1.jpg", Logradouro = "Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Img = "barber2.jpg", Logradouro = "Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Img = "barber3.jpg", Logradouro = "Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Img = "barber4.jpg", Logradouro = "Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Img = "barber5.jpg", Logradouro = "Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
           
            ListEnderecos.ItemsSource = Enderecos;
		}
	}
}