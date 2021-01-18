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
    public class ObavjestenjaViewModel : BaseViewModel
    {
        private readonly APIService _obavjestenja = new APIService("gradovi");

        public ObavjestenjaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public ObservableCollection<GradoviVM> ObavjestenjaList { get; set; } = new ObservableCollection<GradoviVM>();

        string _nazivObavjestenja = string.Empty;

        public string SelectNazivObavjestenja
        {
            get { return _nazivObavjestenja; }
            set { SetProperty(ref _nazivObavjestenja, value); }
        }

        public async Task Init()
        {
            var listaObavijestenja = await _obavjestenja.Get<List<GradoviVM>>(null);

            ObavjestenjaList.Clear();

            foreach (var item in listaObavijestenja)
            {
                ObavjestenjaList.Add(item);
            }
        }
    }
}
