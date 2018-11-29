using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using iBarberE1.Modelo;

namespace iBarberE1.Agendar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ServicesSelect : ContentPage
	{
        private List<Servico_color> servicos;
        private List<Servico_color> servicosSelecionados;

        public ServicesSelect ()
		{
			InitializeComponent ();

            servicos = new List<Servico_color>();
            servicosSelecionados = new List<Servico_color>();

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


        public void ItemSelecionado(object sender, ItemTappedEventArgs args)
        {
            Servico_color servico = args.Item as Servico_color;

     
            if (servicosSelecionados.Contains(servico))
            {
                //DisplayAlert("Já tem", servico.Descricao, "Ok");
                servicosSelecionados.Remove(servico);

                servico.Check = "CheckOff.png";
            }
            else
            {
                //DisplayAlert(servico.Descricao, "Clicked", "Ok");
                servico.Check = "CheckOn.png";
                servicosSelecionados.Add(servico);
            }


            List<Servico_color> servicosNew = new List<Servico_color>();

            string text = "";
            foreach(Servico_color s in servicos)
            {
                text += s.Descricao + " - " + s.Check + "\n";
                servicosNew.Add(s);
            }
            //DisplayAlert("Mensagem", text, "Ok");
            


            ListServices.ItemsSource = servicosNew;
        }

      
        public void View_ProductsSelect(object sender, EventArgs args)
        {
            Navigation.PushAsync(new iBarberE1.Agendar.ProductsSelect());
        }
    }
}