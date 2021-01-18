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
        private readonly APIService _recommenderService = new APIService("Recommender");
        private readonly APIService _pretragaOcjeneService = new APIService("Pretrage");

        public ICommand InitCommand { get; set; }
        public ICommand PovecajBrojOdraslih { get; set; }
        public ICommand SmanjiBrojOdraslih { get; set; }
        public ICommand PovecajBrojDjece { get; set; }
        public ICommand SmanjiBrojDjece { get; set; }

        public ICommand RecommenderCommand { get; set; }

        public PutovanjaVM Putovanje { get; set; }

        public ObservableCollection<PutovanjaVM> RecommenderList { get; set; } = new ObservableCollection<PutovanjaVM>();

        public string Odrasli { get; set; }
        public string Djeca { get; set; }


        double? finalnaCijenaPutovanja;

        public PutovanjeDetailViewModel()
        {
            PovecajBrojOdraslih = new Command(() => BrojOdraslih += 1);
            SmanjiBrojOdraslih = new Command(() =>
            {
                if (BrojOdraslih > 0)
                {
                    BrojOdraslih -= 1;
                }
            });
            PovecajBrojDjece = new Command(() => BrojDjece += 1);
            SmanjiBrojDjece = new Command(() =>
            {
                if (BrojDjece > 0)
                {
                    BrojDjece -= 1;
                }
            });
            InitCommand = new Command(async () => await Init());
            RecommenderCommand = new Command(async () => await Recommender());
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

        public int PutovanjeId
        {
            get { return Putovanje.PutovanjeID; }
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

        public async Task Recommender()
        {
            RecommenderList.Clear();
            List<PutovanjaVM> lista = new List<PutovanjaVM>();
            lista = await _recommenderService.GetSlicnaPutovanja<List<PutovanjaVM>>(Putovanje.PutovanjeID);

            List<PretragaVM> listaPrOcjena = new List<PretragaVM>();
            listaPrOcjena = await _pretragaOcjeneService.Get<List<PretragaVM>>(null);



            foreach (var item in lista)
            {
                int ukupno = 0;
                decimal iznos = 0;

                foreach (var item2 in listaPrOcjena)
                {
                    if (item2.RelacijaId == item.RelacijaID)
                    {
                        iznos += Convert.ToDecimal(item2.Ocjena);
                        ukupno++;
                    }
                }

                item.ProsjecnaOcjena = iznos / ukupno;

                RecommenderList.Add(item);

            }

        }
    }
}
