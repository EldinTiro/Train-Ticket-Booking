using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZeljeznice.WinUI.Kupljene_Karte
{
    public partial class frmKupljeneKarte : Form
    {
        private readonly APIService _apiService = new APIService("putovanje");
        private readonly APIService _apiServiceZeljeznicke = new APIService("ZeljeznickeStanice");
        private readonly APIService _apiServiceProdaneKarte = new APIService("ProdaneKarte");

        private List<ProdanaKartaVM> polazne;
        private List<ProdanaKartaVM> dolazne;
        public frmKupljeneKarte()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            DateTime Datum = new DateTime(dateTimePickerDatumKarte.Value.Year, dateTimePickerDatumKarte.Value.Month, dateTimePickerDatumKarte.Value.Day);
            var PolazneSearch = new ProdaneKarteSearchRequest()
            {
                PolaznaZeljeznickaStanica = cmbZeljeznicke.SelectedIndex,
                DatumKarte = Datum
            };

            polazne = await _apiServiceProdaneKarte.Get<List<ProdanaKartaVM>>(PolazneSearch);

            dvgPolaznaPutovanja.DataSource = polazne;

            dvgPolaznaPutovanja.Columns[7].Visible = false;
            dvgPolaznaPutovanja.Columns[8].Visible = false;
            dvgPolaznaPutovanja.Columns[9].Visible = false;


            var DolaznaSearch = new ProdaneKarteSearchRequest()
            {
                OdredisnaljeznickaStanica = cmbZeljeznicke.SelectedIndex,
                DatumKarte = Datum
            };

            dolazne = await _apiServiceProdaneKarte.Get<List<ProdanaKartaVM>>(DolaznaSearch);

            dvgDolaznaPutovanja.DataSource = dolazne;

            dvgDolaznaPutovanja.Columns[7].Visible = false;
            dvgDolaznaPutovanja.Columns[8].Visible = false;
            dvgDolaznaPutovanja.Columns[9].Visible = false;

            if(dvgDolaznaPutovanja.DataSource != null && dvgPolaznaPutovanja != null)
            {
                btnPrint.Enabled = true;
            }
        }

        private async void frmKupljeneKarte_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceZeljeznicke.Get<List<ZeljeznickeStaniceVM>>();

            List<string> zeljezniceListOD = result.Select(x => x.Naziv).ToList();
            zeljezniceListOD.Insert(0, "");

            cmbZeljeznicke.DataSource = zeljezniceListOD;

            btnPrint.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportKupljeneKarte frmReportKupljeneKarte = new frmReportKupljeneKarte(polazne, dolazne);
            frmReportKupljeneKarte.Show();
        }
    }
}
