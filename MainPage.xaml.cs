using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListMasterApp
{
    public partial class MainPage : ContentPage
    {
        List<string> lista_de_valor = new List<string>();

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageMinhaLista(lista_de_valor));
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            lista_de_valor.Add("Meu Item Adicionando");
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
