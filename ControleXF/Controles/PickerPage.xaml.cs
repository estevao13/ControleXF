using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
        }

        private void MudarIndex(Object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;
            Resultado.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex.ToString();
        }
    }
}
