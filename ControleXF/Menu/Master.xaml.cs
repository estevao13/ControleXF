using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControleXF.Menu
{
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoActivityIndicatorPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ActivityIndicatorPage());
            IsPresented = false;
        }

        private void GoProgressBarPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ProgressBarPage());
            IsPresented = false;
        }

        private void GoBoxViewPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.BoxViewPage());
            IsPresented = false;
        }

        private void GoLabelPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.LabelPage());
            IsPresented = false;
        }

        private void GoButtonPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ButtonPage());
            IsPresented = false;
        }

        private void GoEntryEditorPage(Object sende, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.EntryEditorPage());
            IsPresented = false;
        }

        private void GoDatePickerPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.DatePickerPage());
            IsPresented = false;
        }

        private void GoTimePickerPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TimePickerPage());
            IsPresented = false;
        }

        private void GoPickerPage(Object sender, EventArgs args)
        {
            //Detail = new NavigationPage(new Controles.Picker());
            //IsPresented = false;
        }
    }
}

