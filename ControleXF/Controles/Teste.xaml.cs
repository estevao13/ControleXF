using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class Teste : ContentPage
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void Mudar(Object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;
            Resultado.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex.ToString();
        }
    }
}
