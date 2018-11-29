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
    public partial class Menu : ContentPage
    {
        public List<Agendamento> Agendamentos;
        public List<Agendamento> AgendamentosLittle;

        public Menu()
        {
            InitializeComponent();

            Agendamentos = new List<Agendamento>();

            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Walter O'Brian", Valor = "R$94,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Paige", Valor = "R$54,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Happy", Valor = "R$123,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Tobby", Valor = "R$64,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Walter O'Brian", Valor = "R$94,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Paige", Valor = "KkR$54,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Happy", Valor = "R$123,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Tobby", Valor = "R$64,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Sly" , Valor = "R$44,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Higor" , Valor = "R$154,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Walter O'Brian", Valor = "R$94,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Paige", Valor = "R$54,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Sly" , Valor = "R$44,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Higor" , Valor = "R$154,90" });
            Agendamentos.Add(new Agendamento() { Data = "20/10/2018 às 18:30", Funcionario = "Happy", Valor = "R$123,90" });
            

            VerifyListCount4();
        }
        

        public void VerifyListCount4()
        {
            if(Agendamentos.Count <= 4)
            {
                ViewMore.IsVisible = false;
                ListAgendamento.ItemsSource = Agendamentos;
            }
            else
            {
                ViewMore.IsVisible = true;

                AgendamentosLittle = ShortList(Agendamentos);
                ListAgendamento.ItemsSource = AgendamentosLittle;
            }
        }


        public List<Agendamento> ShortList(List<Agendamento> lista)
        {
            List<Agendamento> newList = new List<Agendamento>();

            for (int i = 0; i < 4; i++)
            {
                newList.Add(lista[i]);
            }

            return newList;
        }



        public void ButtonViewMore(object sender, EventArgs args)
        {
            if(ListAgendamento.ItemsSource == Agendamentos)
            {
                ListAgendamento.HeightRequest = AgendamentosLittle.Count * 50 + 20;
                ListAgendamento.ItemsSource = AgendamentosLittle;
                ViewMore.Text = "VER MAIS";
            }
            else
            {
                ListAgendamento.HeightRequest = Agendamentos.Count * 50 + 20;
                ListAgendamento.ItemsSource = Agendamentos;
                ViewMore.Text = "OCULTAR";
            }
        }


        public void View_ServicesSelect(object sender, EventArgs args)
        {
            Navigation.PushAsync(new iBarberE1.Agendar.ServicesSelect());
        }
    }
}