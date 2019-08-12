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
            Detail = new NavigationPage(new Controles.Teste());
            IsPresented = false;
        }

        private void GoSearchBarPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SearchBarPage());
            IsPresented = false;
        }

        private void GoSliderStepperPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SliderStepperPage());
            IsPresented = false;
        }

        private void GoSwitchPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SwitchPage());
            IsPresented = false;
        }

        private void GoImagePage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ImagePage());
            IsPresented = false;
        }

        private void GoListViewPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ListViewPage());
            IsPresented = false;
        }

        private void GoListTablePage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TableView());
            IsPresented = false;
        }

        private void GoWebViewPage(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.WebView());
            IsPresented = false;
        }
    }
}
