using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class WebView : ContentPage
    {
        public WebView()
        {
            InitializeComponent();
        }

        public void GoSite(Object sender, EventArgs args)
        {
            Navegador.Source = EnderecoSite.Text;
        }

        public void GoProximo(Object sender, EventArgs args)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }

        public void GoVoltar(Object sender, EventArgs args)
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
            }
        }

        public void ActionCarregando (Object sender, EventArgs args)
        {
            LblStatus.Text = "Carregando...";
        }

        public void ActionCarregado (Object sender, EventArgs args)
        {
            LblStatus.Text = "Finalizado";
        }
    }
}