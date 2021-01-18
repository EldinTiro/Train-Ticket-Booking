using eZeljeznice.MobileApp.ViewModels;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZeljeznice.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediProfilPage : ContentPage
    {
        private KupacViewModel model = null;
        APIService _serviceklijenti = new APIService("Kupci");
        public UrediProfilPage(KupacViewModel kupacModel)
        {
            BindingContext = model = new KupacViewModel();
            InitializeComponent();
        }


        private async void Spasi_Clicked(object sender, EventArgs e)
        {

            bool dupliemail = false;

            List<KupciVM> lista = await _serviceklijenti.Get<List<KupciVM>>(null);


            foreach (var item in lista)
            {
                if (item.Email.Equals(inputEmail.Text) == true)
                {
                    dupliemail = true;
                }
            }

            if (validateRegistration() == true)
            {
                if (dupliemail == true)
                {
                    await DisplayAlert("Greska", "Korisnik sa tim emailom je vec registrovan", "OK");
                    emailError.Text = "Email vec postoji!";
                    emailError.IsVisible = true;

                }
                else
                {

                    await model.Update();
                    await Navigation.PushAsync(new MojProfil());
                    if(model.ProfilUpdatean == true)
                    await Application.Current.MainPage.DisplayAlert("Uspjeh", "Uspjesno ste se update-ali profil", "OK");

                }

            }
            else
            {
                await DisplayAlert("Greska", "Niste dobro unijeli neki od podataka", "OK");

            }


        }

        private bool validateRegistration()
        {
            bool valid = true;
            //radim odvojeno kako bi dobio odma error border za svaki pogresan unos
            if (validateIme() == false)
                valid = false;
            if (validatePrezime() == false)
                valid = false;
            if (validateEmail() == false)
                valid = false;

            if (valid == false)
            {
                return false;
            }
            else
            {
                return true;
            };
        }
        private bool validateIme()
        {
            if (inputIme.Text == "")
            {

                imeError.Text = "Ime obavezno!";
                imeError.IsVisible = true;
                return false;
            }
            else
            {

                imeError.IsVisible = false;
                imeError.Text = "";
                return true;
            }
        }

        private bool validatePrezime()
        {
            if (inputPrezime.Text == "")
            {
                prezimeError.Text = "Prezime obavezno!";
                prezimeError.IsVisible = true;
                return false;
            }
            else
            {

                prezimeError.IsVisible = false;
                prezimeError.Text = "";
                return true;
            }
        }
        private bool validateEmail()
        {

            try
            {
                MailAddress mail = new MailAddress(inputEmail.Text);

            }
            catch (Exception)
            {
                emailError.Text = "Email nije u ispravnom formatu!";
                emailError.IsVisible = true;
                return false;
            }

            if (inputEmail.Text == "")
            {

                emailError.Text = "Email obavezan!";
                emailError.IsVisible = true;
                return false;
            }
            else
            {

                emailError.IsVisible = false;
                emailError.Text = "";
                return true;
            }

        }

    }
}
