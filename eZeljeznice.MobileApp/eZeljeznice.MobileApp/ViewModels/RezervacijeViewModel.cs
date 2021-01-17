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

            if (listaRezervacija != null && listaRezervacija.Count != 0)
            {

                SelectImePrezimeKupca = "Prikaz svih prethodnih rezervacija za klijenta : " + listaRezervacija[0].ImePrezimeKupca;

                RezervacijeList.Clear();

                foreach (var item in listaRezervacija)
                {
                    RezervacijeList.Add(item);
                }
            }
        }

        public async Task Reminder()
        {
            var listaRezervacija = await _rezervacije.Get<List<RezervacijeVM>>(Global.PrijavljeniKupac.KupacId);

            if (listaRezervacija != null && listaRezervacija.Count !=0)
            {
                int hours;
                int minutes;

                string vrijemePolaskaString = listaRezervacija[0].VrijemePolaska;
                string[] array = vrijemePolaskaString.Split(':');

                hours = Int32.Parse(array[0]);
                minutes = Int32.Parse(array[1]);

                DateTime datum = new DateTime(listaRezervacija[0].DatumPolaska.Value.Year, listaRezervacija[0].DatumPolaska.Value.Month, listaRezervacija[0].DatumPolaska.Value.Day, hours, minutes, 0);

                if (datum > DateTime.Now)
                {
                    TimeSpan datumZaPrikaz = new TimeSpan();
                    datumZaPrikaz = datum - DateTime.Now;

                    await Application.Current.MainPage.DisplayAlert("Podsjetnik", "Vaše putovanje " + listaRezervacija[0].ImePutovanja + " polazi za " + datumZaPrikaz.Days + " dana, " + datumZaPrikaz.Hours + " sati, " + datumZaPrikaz.Minutes + " minuta", "OK");

                }
            }

        }

    }
}
