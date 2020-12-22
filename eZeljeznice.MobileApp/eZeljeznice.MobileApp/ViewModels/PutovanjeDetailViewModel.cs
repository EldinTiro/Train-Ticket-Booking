using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eZeljeznice.MobileApp.ViewModels
{
    public class PutovanjeDetailViewModel : BaseViewModel
    {
        private readonly APIService _putovanjaServiceAPI = new APIService("putovanje");
        private readonly APIService _zeljeznickeStaniceAPI = new APIService("zeljeznickeStanice");

        public ICommand InitCommand { get; set; }
        public ICommand PovecajBrojOdraslih { get; set; }
        public ICommand SmanjiBrojOdraslih { get; set; }
        public ICommand PovecajBrojDjece { get; set; }
        public ICommand SmanjiBrojDjece { get; set; }

        public PutovanjaVM Putovanje { get; set; }

        public string Odrasli { get; set; }
        public string Djeca { get; set; }


        double? finalnaCijenaPutovanja;

        public PutovanjeDetailViewModel()
        {
            PovecajBrojOdraslih = new Command(() => BrojOdraslih += 1);
            SmanjiBrojOdraslih = new Command(() => BrojOdraslih -= 1);
            PovecajBrojDjece = new Command(() => BrojDjece += 1);
            SmanjiBrojDjece = new Command(() => BrojDjece -= 1);
            InitCommand = new Command(async () => await Init());
        }

        int _BrojOdraslih = 0;
        int _BrojDjece = 0;
        public double? _FinalnaCijena = 0;

        public int BrojOdraslih
        {
            get { return _BrojOdraslih; }
            set { SetProperty(ref _BrojOdraslih, value);
                if (value != null && value >= 0 && BrojDjece >= 0)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public int BrojDjece
        {
            get { return _BrojDjece; }
            set { SetProperty(ref _BrojDjece, value);
                if (value != null && value >=0 && BrojOdraslih>=0)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public double? FinalnaCijena
        {
            get { return _FinalnaCijena; }
            set { SetProperty(ref _FinalnaCijena, value); }
        }

        public async Task Init()
        {
            var InitCijenaPutovanja = Putovanje.Cijena;
            finalnaCijenaPutovanja = InitCijenaPutovanja;

            if (BrojOdraslih != null)
            {
                var cijenaOdraslih = InitCijenaPutovanja * BrojOdraslih;
                finalnaCijenaPutovanja = cijenaOdraslih;
            }

            if (BrojDjece != null && BrojDjece != 0)
            {
                var cijenaDjece = (InitCijenaPutovanja * BrojDjece) / 2;
                finalnaCijenaPutovanja += cijenaDjece;
            }

            FinalnaCijena = finalnaCijenaPutovanja;

        }
    }
}
