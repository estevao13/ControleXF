using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void ActionTrocou(Object sender, ToggledEventArgs args)
        {
            Result.Text = DateTime.Now.ToString("HH:mm") + " - " + args.Value;
        }
    }
}
