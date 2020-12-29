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
    public partial class PutovanjeDetailPage : ContentPage
    {
        private PutovanjeDetailViewModel model = null;
        public PutovanjeDetailPage(Model.PutovanjaVM putovanje)
        {
            BindingContext = model = new PutovanjeDetailViewModel
            {
                Putovanje = putovanje
            };

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
            await model.Recommender();

        }

        private async void ListView_ItemsSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var PutovanjeItem = e.SelectedItem as Model.PutovanjaVM;

            model.RecommenderList.Clear();
            await Navigation.PushAsync(new PutovanjeDetailPage(PutovanjeItem));
        }

        private async void Rezervisi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StripePaymentGatwayPage());
        }
    }
}