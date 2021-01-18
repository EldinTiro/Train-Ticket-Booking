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

namespace eZeljeznice.WinUI.Putovanja
{
    public partial class frmPutovanjaDetalji : Form
    {
        private readonly APIService _apiServiceZeljeznicke = new APIService("ZeljeznickeStanice");
        private readonly APIService _apiServicePutovanje = new APIService("putovanje");
        private int? _id = null;
        public frmPutovanjaDetalji(int ? putovanjeId = null)
        {
            InitializeComponent();
            _id = putovanjeId;
        }

        private async void frmPutovanjaDetalji_Load(object sender, EventArgs e)
        {
            var resultPocetne = await _apiServiceZeljeznicke.Get<List<ZeljeznickeStaniceVM>>();
            var resultKrajnje = await _apiServiceZeljeznicke.Get<List<ZeljeznickeStaniceVM>>();

            resultPocetne.Insert(0, new ZeljeznickeStaniceVM());
            resultKrajnje.Insert(0, new ZeljeznickeStaniceVM());

            cmbPocetna.DisplayMember = "Naziv";
            cmbPocetna.ValueMember = "ZeljeznickaStanicaID";
            cmbPocetna.DataSource = resultPocetne;

            cmbKrajnja.DisplayMember = "Naziv";
            cmbKrajnja.ValueMember = "ZeljeznickaStanicaID";
            cmbKrajnja.DataSource = resultKrajnje;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) 
            { 
                var request = new PutovanjaInsertRequest()
                {
                    Cijena = Convert.ToDouble(txtBoxCijena.Text),
                    ZeljeznickaStanicaDOID = cmbKrajnja.SelectedIndex,
                    ZeljeznickaStanicaODID = cmbPocetna.SelectedIndex,
                    DatumPolaska = dateTimePicker1.Value,
                    VrijemeDolaska = timePickerDolazak.Value,
                    VrijemePolaska = timePickerPolazak.Value
                };
                if (_id.HasValue)
                {
                    await _apiServicePutovanje.Update<PutovanjaVM>(_id, request);
                }
                else
                {
                    await _apiServicePutovanje.Insert<PutovanjaVM>(request);
                }
                MessageBox.Show("Operacija uspješna");
            }
        }

        private void txtBoxCijena_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxCijena.Text))
            {
                errorProvider.SetError(txtBoxCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBoxCijena, null);
            }
        }

        private void cmbPocetna_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPocetna.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbPocetna, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbPocetna, null);
            }
        }

        private void cmbKrajnja_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKrajnja.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbPocetna, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbKrajnja, null);
            }
        }
    }
}
