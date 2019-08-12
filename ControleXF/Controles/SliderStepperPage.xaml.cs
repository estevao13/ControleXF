using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Controles
{
    public partial class SliderStepperPage : ContentPage
    {
        public SliderStepperPage()
        {
            InitializeComponent();
        }

        private void ActionValorMudou (Object sender, ValueChangedEventArgs args)
        {
            SliderResult.Text = args.NewValue.ToString();
        }

        private void ActionValorMudouStepper(Object sender, ValueChangedEventArgs args)
        {
            StepperResult.Text = args.NewValue.ToString();
        }
    }
}
