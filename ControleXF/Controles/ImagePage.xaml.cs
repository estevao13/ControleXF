using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            Image imgUSB = new Image();
            imgUSB.Source = ImageSource.FromFile("usb.jpg");

            Container.Children.Add(imgUSB);
        }
    }
}
