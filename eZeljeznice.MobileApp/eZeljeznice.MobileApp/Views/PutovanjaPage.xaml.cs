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
    public partial class PutovanjaPage : ContentPage
    {
        private PutovanjaViewModel model = null;

        private readonly APIService _putovanjaServiceAPI = new APIService("putovanje");

        public PutovanjaPage()
        {
            InitializeComponent();
            BindingContext = model = new PutovanjaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var PutovanjeItem = e.SelectedItem as Model.PutovanjaVM;
            
            model.PutovanjaList.Clear();
            await Navigation.PushAsync(new PutovanjeDetailPage(PutovanjeItem,model.SelectedOdrasli,model.SelectedDjeca));
        }

        /*async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            await Navigation.PushAsync(new PutovanjeDetailPage());
        }*/
    }
}