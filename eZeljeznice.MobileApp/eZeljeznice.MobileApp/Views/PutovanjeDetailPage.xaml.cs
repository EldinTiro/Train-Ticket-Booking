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
        public PutovanjeDetailPage(Model.PutovanjaVM putovanje,string odrasli, string djeca)
        {
            BindingContext = model = new PutovanjeDetailViewModel
            {
                Putovanje = putovanje,
                Odrasli = odrasli,
                Djeca = djeca
            };

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
            await model.Recommender();



        }
    }
}