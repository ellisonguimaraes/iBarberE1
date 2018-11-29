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
	public partial class Main2 : ContentPage
	{
        public List<Endereco> Enderecos;
        public List<Endereco> EnderecosLittle;

        public Main2 ()
		{
			InitializeComponent ();

            //List<Servico> servicos = new List<Servico>();
            Enderecos = new List<Endereco>();


            var tapAgendarButton = new TapGestureRecognizer();

            //Binding events
            tapAgendarButton.Tapped += Agendar_Tapped;

            //Associating tap events to the image buttons 
            AgendarButton.GestureRecognizers.Add(tapAgendarButton);

            
            /*
            servicos.Add(new Servico() { Descricao = "Corte de tesoura", Valor = "R$ 30,00" });
            servicos.Add(new Servico() { Descricao = "Corte de máquina", Valor = "R$ 15,00" });
            servicos.Add(new Servico() { Descricao = "Corte de tesoura + máquina", Valor = "R$ 20,00" });
            servicos.Add(new Servico() { Descricao = "Barba", Valor = "R$ 15,00" });
            ServiceList.ItemsSource = servicos;
            */
            /*
            Enderecos.Add(new Endereco { Unidade = "UNIDADE I", Logradouro = "Endereço: Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Unidade = "UNIDADE II", Logradouro = "Endereço: Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Unidade = "UNIDADE III", Logradouro = "Endereço: Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Unidade = "UNIDADE IV", Logradouro = "Endereço: Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Unidade = "UNIDADE V", Logradouro = "Endereço: Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });
            Enderecos.Add(new Endereco { Unidade = "UNIDADE VI", Logradouro = "Endereço: Rua F, nº 99, Bairro Jardim Grapiuna. Itabuna/BA", Telefones = "(73) 3211-2566 / (73) 8899-5544" });

            VerifyListCount1();*/
        }

        public void VerifyListCount1()
        {
            if (Enderecos.Count <= 1)
            {
                MoreView.IsVisible = false;
                EnderecoListView.ItemsSource = Enderecos;
            }
            else
            {
                MoreView.IsVisible = true;

                EnderecosLittle = ShortList(Enderecos);
                EnderecoListView.ItemsSource = EnderecosLittle;
            }
        }


        public List<Endereco> ShortList(List<Endereco> lista)
        {
            List<Endereco> newList = new List<Endereco>();

            newList.Add(lista[0]);

            return newList;
        }


        public void ButtonViewMore(object sender, EventArgs args)
        {
            if (EnderecoListView.ItemsSource == Enderecos)
            {
                EnderecoListView.HeightRequest = EnderecosLittle.Count * 120 + 20;
                EnderecoListView.ItemsSource = EnderecosLittle;
                MoreView.Text = "VER MAIS";
            }
            else
            {
                EnderecoListView.HeightRequest = Enderecos.Count * 120 + 20;
                EnderecoListView.ItemsSource = Enderecos;
                MoreView.Text = "OCULTAR";
            }
        }

        private void Agendar_Tapped(object sender, EventArgs args)
        {
            Navigation.PushAsync(new iBarberE1.Agendar.Menu());
        }

    }
}