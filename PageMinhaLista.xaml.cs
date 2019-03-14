using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListMasterApp
{
    public partial class PageMinhaLista : ContentPage
    {
        List<string> lista_conteudo = new List<string>(new string[]{
            "Item 01",
            "Item 02",
            "Item 03"
        });

        public PageMinhaLista(List<string> listaOregemDesconhecida)
        {
            InitializeComponent();
            minhaLista.ItemsSource = listaOregemDesconhecida;
        }
    }
}
