using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZeljeznice.WinUI.Putovanja
{
    public partial class frmPutovanja : Form
    {
        private readonly APIService _apiService = new APIService("putovanje");
        private readonly APIService _apiServiceZeljeznicke = new APIService("ZeljeznickeStanice");
        public frmPutovanja()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new PutovanjaSearchRequest()
            {
                ZeljeznickaOdID = (cmbOD.SelectedIndex).ToString(),
                ZeljeznickaDoID = (cmbDO.SelectedIndex).ToString(),
                WindowsIndikator = "X"
            };

            var result = await _apiService.Get<List<PutovanjaVM>>(search);

            dgvPutovanja.DataSource = result;

            dgvPutovanja.Columns[0].Visible = false;
            dgvPutovanja.Columns[1].Visible = false;

        }

        private async void frmPutovanja_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceZeljeznicke.Get<List<ZeljeznickeStaniceVM>>();

            List<string> zeljezniceListOD = result.Select(x => x.Naziv).ToList();
            zeljezniceListOD.Insert(0, "");

            List<string> zeljezniceListDO = result.Select(x => x.Naziv).ToList();
            zeljezniceListDO.Insert(0, "");

            cmbOD.DataSource = zeljezniceListOD;
            cmbDO.DataSource = zeljezniceListDO;
        }

        private void cmbOD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
