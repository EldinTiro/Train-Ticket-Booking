using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;

namespace eZeljeznice.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _apiServiceGradovi = new APIService("gradovi");

        private int? _id = null;
        public frmKorisniciDetalji(int ? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest()
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = txtDatumRodjenja.Value,
                    GradID = cbxGradovi.SelectedIndex,
                    Status = Convert.ToInt32(cboxAktivan.Checked)
                };

                if (_id.HasValue)
                {
                    await _service.Update<KorisniciVM>(_id, request);
                }
                else
                {
                    await _service.Insert<KorisniciVM>(request);
                }
                MessageBox.Show("Operacija uspješna");
            }
            
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            var gradovi = await _apiServiceGradovi.Get<List<GradoviVM>>();
            List <GradoviVM> gradoviFilter = new List<GradoviVM>();

            foreach (var item in gradovi)
            {
                if (item.Sadrzaj == null)
                    gradoviFilter.Add(item);
            }

            if (gradovi != null)
            {
                gradovi.Insert(0, new GradoviVM());
                cbxGradovi.DisplayMember = "Naziv";
                cbxGradovi.ValueMember = "GradID";
                cbxGradovi.DataSource = gradoviFilter;
            }

            if (_id.HasValue)
            {
                var korisnik = await _service.GetById<KorisniciVM>(_id);

                txtEmail.Text = korisnik.Email;
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtDatumRodjenja.Text = korisnik.DatumRodjenja.ToString();
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDatumRodjenja.Text))
            {
                errorProvider.SetError(txtDatumRodjenja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDatumRodjenja, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}
