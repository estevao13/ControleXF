using System;
using System.Collections.Generic;
using ControleXF.Controles;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            InitializeComponent();
        }

        private void Modificar(Object sender, EventArgs agrs)
        {
            Bar1.Progress = 1;
            Bar2.ProgressTo(1, 5000, Easing.Linear);
            Bar3.ProgressTo(1, 5000, Easing.SpringIn);
        }
    }
}
