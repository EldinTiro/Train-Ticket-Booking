using eZeljeznice.MobileApp.ViewModels;
using eZeljeznice.Model;
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
    public partial class RezervacijaDetailPage : ContentPage
    {
        private RezervacijeDetailViewModel model = null;
        public RezervacijaDetailPage(RezervacijeVM rezervacija)
        {
            BindingContext = model = new RezervacijeDetailViewModel
            {
                Rezervacija = rezervacija
            };

            InitializeComponent();
        }
    }
}