using System;
using System.Collections.Generic;
using ControleXF.Modelo;
using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "Fulano", Idade = "20" });
            lista.Add(new Pessoa { Nome = "Fulano 2", Idade = "22" });
            lista.Add(new Pessoa { Nome = "Fulano 3", Idade = "24" });
            lista.Add(new Pessoa { Nome = "Fulano 4", Idade = "21" });

            ListaPessoas.ItemsSource = lista;
        }
    }
}
