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
    public partial class Obavjestenja : ContentPage
    {
        private ObavjestenjaViewModel model = null;
        public Obavjestenja()
        {
            InitializeComponent();
            BindingContext = model = new ObavjestenjaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}