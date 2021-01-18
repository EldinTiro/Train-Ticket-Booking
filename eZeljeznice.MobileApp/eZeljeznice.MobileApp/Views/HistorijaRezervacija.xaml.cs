using eZeljeznice.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZeljeznice.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistorijaRezervacija : ContentPage
    {

        private RezervacijeViewModel model = null;
        public HistorijaRezervacija()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var RezervacijaItem = e.SelectedItem as Model.RezervacijeVM;

            model.RezervacijeList.Clear();
            await Navigation.PushAsync(new RezervacijaDetailPage(RezervacijaItem));
        }
    }
}