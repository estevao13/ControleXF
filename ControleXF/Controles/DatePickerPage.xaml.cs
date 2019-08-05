using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
        }

        public void ActionDateSelect(Object sender, DateChangedEventArgs args)
        {
            Lbl_resultado.Text = args.OldDate.ToString("dd/MM/yyyy") + " > " + args.NewDate.ToString("dd/MM/yyyy");
        }
    }
}
