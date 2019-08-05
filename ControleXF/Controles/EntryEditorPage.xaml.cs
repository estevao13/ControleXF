using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();



            Txt_Idade.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                Lbl_Duplicado.Text = args.NewTextValue;
            };

            Txt_Comentario.Completed += delegate (object sender, EventArgs args)
            {
                Lbl_QtdCaracteres.Text = Txt_Comentario.Text.Length.ToString();
            };
        }
    }
}
