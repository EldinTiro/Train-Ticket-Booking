using eZeljeznice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eZeljeznice.MobileApp.ViewModels
{
    public class RezervacijeViewModel : BaseViewModel
    {
        private readonly APIService _rezervacije = new APIService("rezervacije");

        public RezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public ObservableCollection<RezervacijeVM> RezervacijeList { get; set; } = new ObservableCollection<RezervacijeVM>();

        string _imePrezimeKupca = string.Empty;

        public string SelectImePrezimeKupca
        {
            get { return _imePrezimeKupca; }
            set { SetProperty(ref _imePrezimeKupca, value); }
        }

        public async Task Init()
        {
            var listaRezervacija = await _rezervacije.Get<List<RezervacijeVM>>(Global.PrijavljeniKupac.KupacId);

            SelectImePrezimeKupca = "Prikaz svih prethodnih rezervacija za klijenta : "+listaRezervacija[0].ImePrezimeKupca;

            RezervacijeList.Clear();

            foreach (var item in listaRezervacija)
            {
                RezervacijeList.Add(item);
            }
        }
    }
}
