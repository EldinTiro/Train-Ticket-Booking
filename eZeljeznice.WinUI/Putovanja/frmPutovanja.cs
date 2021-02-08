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

        private List<PutovanjaVM> putovanja;
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

            putovanja = await _apiService.Get<List<PutovanjaVM>>(search);

            dgvPutovanja.DataSource = putovanja;
            dgvPutovanja.AutoResizeColumns();

            dgvPutovanja.Columns[0].Visible = false;
            dgvPutovanja.Columns[1].Visible = false;
            dgvPutovanja.Columns[8].Visible = false;

            if (dgvPutovanja.DataSource != null)
            {
                btnPrint.Enabled = true;
            }

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

            buttonIzmjeni.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void dgvPutovanja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxDestOD.Text = dgvPutovanja.SelectedRows[0].Cells[2].Value.ToString();
            textBoxDestDO.Text = dgvPutovanja.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePickerDatumPolaska.Value = Convert.ToDateTime(dgvPutovanja.SelectedRows[0].Cells[4].Value.ToString());
            dateTimePickerPolazak.Value = Convert.ToDateTime(dgvPutovanja.SelectedRows[0].Cells[6].Value.ToString());
            dateTimePickerDolazak.Value = Convert.ToDateTime(dgvPutovanja.SelectedRows[0].Cells[7].Value.ToString());
            textBoxCijena.Text = dgvPutovanja.SelectedRows[0].Cells[5].Value.ToString();

            if (textBoxDestOD.Text == null || textBoxCijena.Text == null)
            {
                buttonIzmjeni.Enabled = false;
            }
            else
                buttonIzmjeni.Enabled = true;
        }

        private async void buttonIzmjeni_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var updatePutovanja = new PutovanjaInsertRequest()
                {
                    Cijena = Convert.ToDouble(textBoxCijena.Text),
                    DatumPolaska = dateTimePickerDatumPolaska.Value,
                    VrijemeDolaska = dateTimePickerDolazak.Value,
                    VrijemePolaska = dateTimePickerPolazak.Value,
                    RelacijaId = Convert.ToInt32(dgvPutovanja.SelectedRows[0].Cells[0].Value.ToString())
                };

                try
                {
                    await _apiService.Update<PutovanjaVM>(updatePutovanja.RelacijaId, updatePutovanja);
                    MessageBox.Show("Putovanje je uspješno uređeno!");

                    frmPutovanja_Load(sender, e);

                    textBoxDestOD.Text = null;
                    textBoxDestDO.Text = null;
                    textBoxCijena.Text = null;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        private void textBoxCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportPutovanja frmReportPutovanja = new frmReportPutovanja(putovanja);
            frmReportPutovanja.Show();
        }

    }
}
