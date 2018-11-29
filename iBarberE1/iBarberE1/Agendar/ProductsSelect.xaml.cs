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
    public partial class ProductsSelect : ContentPage
    {
        private List<Produtos_Agendar> produtos;
        private List<Produtos_Agendar> produtosSelecionados;

        public ProductsSelect()
        {
            InitializeComponent();

            produtos = new List<Produtos_Agendar>();
            produtosSelecionados = new List<Produtos_Agendar>();

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


        public void ItemSelecionado(object sender, ItemTappedEventArgs args)
        {
            List<Produtos_Agendar> produtosNew = new List<Produtos_Agendar>();
            Produtos_Agendar produto = args.Item as Produtos_Agendar;


            if (produtosSelecionados.Contains(produto))
            {
                //DisplayAlert("Já tem", servico.Descricao, "Ok");
                produtosSelecionados.Remove(produto);

                produto.Check = "CheckOff.png";
            }
            else
            {
                //DisplayAlert(servico.Descricao, "Clicked", "Ok");
                produto.Check = "CheckOn.png";
                produtosSelecionados.Add(produto);
            }




            string text = "";
            foreach (Produtos_Agendar s in produtos)
            {
                text += s.Descricao + " - " + s.Check + "\n";
                produtosNew.Add(s);
            }
            //DisplayAlert("Mensagem", text, "Ok");


            ListProducts.ItemsSource = produtosNew;
        }

        public void View_DateSelect(object sender, EventArgs args){
            Navigation.PushAsync(new iBarberE1.Agendar.DateSelect());
        }
    }
}