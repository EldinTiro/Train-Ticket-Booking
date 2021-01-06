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
    public class PutovanjaViewModel : BaseViewModel
    {
        private readonly APIService _putovanjaServiceAPI = new APIService("putovanje");
        private readonly APIService _zeljeznickeStaniceAPI = new APIService("zeljeznickeStanice");

        public ICommand InitCommand { get; set; }

        public ObservableCollection<PutovanjaVM> PutovanjaList { get; set; } = new ObservableCollection<PutovanjaVM>();
        public ObservableCollection<ZeljeznickeStaniceVM> ZSPolazisteList { get; set; } = new ObservableCollection<ZeljeznickeStaniceVM>();
        public ObservableCollection<ZeljeznickeStaniceVM> ZSOdredisteList { get; set; } = new ObservableCollection<ZeljeznickeStaniceVM>();


        ZeljeznickeStaniceVM _selectedZSPolaziste = null;

        ZeljeznickeStaniceVM _selectedZSOdrediste = null;

        string _selectedOdrasli = null;

        string _selectedDjeca = null;

        DateTime _selectedDatumPolaska = DateTime.Now.Date;

        double? finalnaCijenaPutovanja;

        public PutovanjaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ZeljeznickeStaniceVM SelectedZSPolaziste
        {
            get { return _selectedZSPolaziste; }
            set { 
                SetProperty(ref _selectedZSPolaziste, value);
                if(value != null)
                {
                    InitCommand.Execute(null);
                }
                
            }
        }
        public ZeljeznickeStaniceVM SelectedZSOdrediste
        {
            get { return _selectedZSOdrediste; }
            set
            {
                SetProperty(ref _selectedZSOdrediste, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public DateTime SelectedDatumpolaska
        {
            get { return _selectedDatumPolaska; }
            set
            {
                SetProperty(ref _selectedDatumPolaska, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public string SelectedOdrasli
        {
            get { return _selectedOdrasli; }
            set
            {
                SetProperty(ref _selectedOdrasli, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public string SelectedDjeca
        {
            get { return _selectedDjeca; }
            set
            {
                SetProperty(ref _selectedDjeca, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public async Task Init()
        {

            if(ZSPolazisteList.Count == 0)
            {
                var listaZ = await _zeljeznickeStaniceAPI.Get<List<ZeljeznickeStaniceVM>>(null);
                ZSPolazisteList.Clear();
                ZSPolazisteList.Add(new ZeljeznickeStaniceVM());
                foreach (var itemZ in listaZ)
                {
                    ZSPolazisteList.Add(itemZ);
                }
            }

            if (ZSOdredisteList.Count == 0)
            {
                var listaZ = await _zeljeznickeStaniceAPI.Get<List<ZeljeznickeStaniceVM>>(null);
                ZSOdredisteList.Clear();
                ZSOdredisteList.Add(new ZeljeznickeStaniceVM());
                foreach (var itemZ in listaZ)
                {
                    ZSOdredisteList.Add(itemZ);
                }
            }

            if (SelectedZSPolaziste != null || SelectedZSOdrediste!=null)
            {
                PutovanjaSearchRequest search = new PutovanjaSearchRequest();

                if(SelectedZSPolaziste != null)
                {
                    search.ZeljeznickaOdID = SelectedZSPolaziste.ZeljeznickaStanicaID.ToString();
                }

                if (SelectedZSOdrediste != null)
                {
                    search.ZeljeznickaDoID = SelectedZSOdrediste.ZeljeznickaStanicaID.ToString();
                }

                if(SelectedDatumpolaska !=null)
                {
                    search.VrijemePolaska = SelectedDatumpolaska;
                }

            var list = await _putovanjaServiceAPI.Get<IEnumerable<PutovanjaVM>>(search);
            PutovanjaList.Clear();
            foreach (var putovanje in list)
            {
                  /* var InitCijenaPutovanja = putovanje.Cijena;
                    finalnaCijenaPutovanja = InitCijenaPutovanja;

                    if (SelectedOdrasli != null && !SelectedOdrasli.Equals("0"))
                    {
                        var cijenaOdraslih = InitCijenaPutovanja * Double.Parse(SelectedOdrasli);
                        finalnaCijenaPutovanja = cijenaOdraslih;
                    }

                    if (SelectedDjeca != null && !SelectedDjeca.Equals("0"))
                    {
                        var cijenaDjece = (InitCijenaPutovanja * Double.Parse(SelectedDjeca))/2;
                        finalnaCijenaPutovanja += cijenaDjece;
                    }

                    putovanje.Cijena = finalnaCijenaPutovanja;*/

                    PutovanjaList.Add(putovanje);
            }

            }

        }
    }
}
