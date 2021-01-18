using eZeljeznice.MobileApp.Views;
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
    public class KupacViewModel : BaseViewModel
    {
        private readonly APIService _kupci = new APIService("kupci");

        public KupacViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public KupciVM KupacProfil { get; set; } = new KupciVM();

        string _imeKupca = string.Empty;
        string _korisnickoImeKupca = string.Empty;
        string _prezimeKupca = string.Empty;
        string _email = string.Empty;
        public int _BrojRezervacija = 0;
        DateTime? _DatumRegistracije;

        bool _profilUpdatean;

        public bool ProfilUpdatean
        {
            get { return _profilUpdatean; }
            set
            {
                SetProperty(ref _profilUpdatean, value);
            }
        }

        public string ImeKupca
        {
            get { return _imeKupca; }
            set
            {
                SetProperty(ref _imeKupca, value);
            }
        }
        public string KorisnickoImeKupca
        {
            get { return _korisnickoImeKupca; }
            set
            {
                SetProperty(ref _korisnickoImeKupca, value);
            }
        }

        public string PrezimeKupca
        {
            get { return _imeKupca; }
            set
            {
                SetProperty(ref _imeKupca, value);
            }
        }

        public string Email
        {
            get { return _imeKupca; }
            set
            {
                SetProperty(ref _imeKupca, value);
            }
        }

        public int BrojRezervacija
        {
            get { return _BrojRezervacija; }
            set
            {
                SetProperty(ref _BrojRezervacija, value);
            }
        }

        public DateTime? DatumRegistracije
        {
            get { return _DatumRegistracije; }
            set
            {
                SetProperty(ref _DatumRegistracije, value);
            }
        }


        string _UrediIme = string.Empty;
        public string UrediIme
        {
            get { return _UrediIme; }
            set { SetProperty(ref _UrediIme, value); }
        }
        string _UrediPrezime = string.Empty;
        public string UrediPrezime
        {
            get { return _UrediPrezime; }
            set { SetProperty(ref _UrediPrezime, value); }
        }
        string _UrediEmail = string.Empty;
        public string UrediEmail
        {
            get { return _UrediEmail; }
            set { SetProperty(ref _UrediEmail, value); }
        }


        public async Task Init()
        {
            var Kupac = await _kupci.GetContactById<KupciVM>(Global.PrijavljeniKupac.KupacId);

            if( Kupac != null)
            {
                KupacProfil = Kupac;
            }

            ImeKupca = KupacProfil.Ime;
            PrezimeKupca = KupacProfil.Prezime;
            KorisnickoImeKupca = KupacProfil.KorisnickoIme;
            Email = KupacProfil.Email;
            DatumRegistracije = KupacProfil.DatumRegistracije;
            BrojRezervacija = KupacProfil.BrojRezervacija;

        }

        public async Task Update()
        {
            KupciUpdateRequest updateRequest = new KupciUpdateRequest();

            KupciVM kupciVM = new KupciVM();

            updateRequest.Email = UrediEmail;
            updateRequest.Ime = UrediIme;
            updateRequest.Prezime = UrediPrezime;

            kupciVM = await _kupci.Update<KupciVM>(Global.PrijavljeniKupac.KupacId, updateRequest);

            if(kupciVM != null)
            {
                ProfilUpdatean = true;
            }

        }
    }
}
