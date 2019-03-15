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

        int valor = 0;

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            valor++;

            //lista_de_valor.Add(valor.ToString("D"));
            lista_de_valor.Add(valor.ToString().PadLeft(2, '0'));
        }
       
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageMinhaLista(lista_de_valor));
        }
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {

            lista_de_valor.Add(valor_digitado.Text);
        }
    }
}
