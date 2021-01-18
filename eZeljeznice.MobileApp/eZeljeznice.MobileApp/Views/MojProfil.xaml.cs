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
    public partial class MojProfil : ContentPage
    {
        private KupacViewModel model = null;
        public MojProfil()
        {
            InitializeComponent();
            BindingContext = model = new KupacViewModel();
        }

        protected override async void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();

        }

        private async void Uredi_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new UrediProfilPage(model));
        }
    }
}