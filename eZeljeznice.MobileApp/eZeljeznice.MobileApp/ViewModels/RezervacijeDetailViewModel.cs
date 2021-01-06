using eZeljeznice.Model;
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

        public RezervacijeDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public RezervacijeVM Rezervacija { get; set; } = new RezervacijeVM();

    

        public async Task Init()
        {

        }
    }
}
