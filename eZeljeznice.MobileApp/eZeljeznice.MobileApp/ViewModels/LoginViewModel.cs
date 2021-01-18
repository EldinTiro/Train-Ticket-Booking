using eZeljeznice.MobileApp.Views;
using eZeljeznice.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eZeljeznice.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupci");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;

            try
            {

                KupciVM kupac = await _service.Authenticiraj<KupciVM>(Username, Password);


                if (kupac != null)
                {
                    Global.PrijavljeniKupac = kupac;

                    await Application.Current.MainPage.DisplayAlert("Uspjeh", "Dobrodosli " + kupac.Ime + " " + kupac.Prezime, "OK");
                    Application.Current.MainPage = new MainPage();

                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Pogresno unesen username ili password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", ex.Message, "OK");
            }

        }
    }
}
