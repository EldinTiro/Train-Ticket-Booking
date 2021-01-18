using eZeljeznice.MobileApp.Helper;
using eZeljeznice.MobileApp.ViewModels;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
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

        private APIService _RezervacijeService = new APIService("Rezervacije");
        private APIService _ProdaneKarteService = new APIService("ProdaneKarte");
        private APIService _PretrageService = new APIService("Pretrage");
        private APIService _KarteService = new APIService("Karte");
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
            

            //Insertanje Karte - Begin
            Random rnd = new Random();

            int brojSjedista = rnd.Next(1, 30);
            int brojVagona = rnd.Next(1, 10);

            KartaInsertRequest karta = new KartaInsertRequest();

            karta.RedniBrojSjedista = brojSjedista;
            karta.RedniBrojVagona = brojVagona;

            KarteVM karteVM = new KarteVM();

            karteVM = await _KarteService.Insert<KarteVM>(karta);
            //Insertanje Karte - End

            //Insertanje Rezervacije - Begin
            RezervacijeInsertRequest rezervacijeInsertRequest = new RezervacijeInsertRequest();

            rezervacijeInsertRequest.DatumRezervacije = DateTime.Now;
            rezervacijeInsertRequest.KartaId = karteVM.KartaId;
            rezervacijeInsertRequest.KupacId = Global.PrijavljeniKupac.KupacId; //Dorada (Ubaciti ID od kupca preko Glabal classe)
            rezervacijeInsertRequest.Kompletirana = false;
            rezervacijeInsertRequest.PutovanjeId = model.PutovanjeId;

            RezervacijeVM rezervacijeVM = new RezervacijeVM();
            rezervacijeVM = await _RezervacijeService.Insert<RezervacijeVM>(rezervacijeInsertRequest);
            //Insertanje Rezervacije - Begin

            //Insertanje Prodane karte - Begin
            string brojRacuna = BrojRacunaHelper.GenerisiBrojRacuna();

            ProdaneKarteInsertRequest prodaneKarteInsertRequest = new ProdaneKarteInsertRequest();

            prodaneKarteInsertRequest.BrojRacuna = brojRacuna;
            prodaneKarteInsertRequest.DatumProdaje = DateTime.Now;
            prodaneKarteInsertRequest.RezervacijaId = rezervacijeVM.RezervacijaId;
            prodaneKarteInsertRequest.Popust = 0;
            prodaneKarteInsertRequest.KupacId = Global.PrijavljeniKupac.KupacId; //Dorada (Ubaciti ID od kupca preko Glabal classe)
            prodaneKarteInsertRequest.KonacnaCijena = model.FinalnaCijena;

            ProdanaKartaVM prodanaKartaVM = new ProdanaKartaVM();
            prodanaKartaVM = await _ProdaneKarteService.Insert<ProdanaKartaVM>(prodaneKarteInsertRequest);
            //Insertanje Prodane karte - End

            //Insertanje Pretrage - Begin

            PretragaInsertRequest pretragaInsertRequest = new PretragaInsertRequest();

            pretragaInsertRequest.RezervacijaID = rezervacijeVM.RezervacijaId; ;
            pretragaInsertRequest.RelacijaId = model.Putovanje.RelacijaID;
            pretragaInsertRequest.KupacId = Global.PrijavljeniKupac.KupacId;

            PretragaVM pretragaVM = new PretragaVM();
            pretragaVM = await _PretrageService.Insert<PretragaVM>(pretragaInsertRequest);
            //Insertanje Pretrage -  End



            await Navigation.PushAsync(new StripePaymentGatwayPage(model.FinalnaCijena));
        }
    }
}