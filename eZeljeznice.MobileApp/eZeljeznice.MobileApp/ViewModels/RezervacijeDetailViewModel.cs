using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eZeljeznice.MobileApp.ViewModels
{
    public class RezervacijeDetailViewModel:BaseViewModel
    {

        private readonly APIService _rezervacije = new APIService("rezervacije");
        private readonly APIService _pretrage = new APIService("pretrage");


        public RezervacijeDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());

            OcijeniSa1Command = new Command(async () => await Ocijeni(1));
            OcijeniSa2Command = new Command(async () => await Ocijeni(2));
            OcijeniSa3Command = new Command(async () => await Ocijeni(3));
            OcijeniSa4Command = new Command(async () => await Ocijeni(4));
            OcijeniSa5Command = new Command(async () => await Ocijeni(5));
        }

        public ICommand InitCommand { get; set; }
        public ICommand OcijeniSa1Command { get; set; }
        public ICommand OcijeniSa2Command { get; set; }
        public ICommand OcijeniSa3Command { get; set; }
        public ICommand OcijeniSa4Command { get; set; }
        public ICommand OcijeniSa5Command { get; set; }

        public RezervacijeVM Rezervacija { get; set; } = new RezervacijeVM();


        public async Task Init()
        {

        }

        public async Task Ocijeni(int ocjena)
        {
            PretragaInsertRequest pretragaInsertRequest = new PretragaInsertRequest
            {
                Ocjena = ocjena,
                RezervacijaID = Rezervacija.RezervacijaId
            };

            PretragaVM response = new PretragaVM();

            response = await _pretrage.Update<PretragaVM>(Rezervacija.RezervacijaId,pretragaInsertRequest);
            
            if(response != null)
            {
                await App.Current.MainPage.DisplayAlert("Uspješno ocijenjeno", "", "OK");
            }

        }
    }
}
