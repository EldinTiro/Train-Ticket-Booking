using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            KorisniciVM korisnik = new KorisniciVM();

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

                try
                {
                    korisnik = await _service.Insert<KorisniciVM>(request);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                if (korisnik.KorisnikId == 100)
                {
                    MessageBox.Show("Paswordi se ne slažu");
                }
                else if(korisnik.KorisnikId == 200)
                {
                    MessageBox.Show("Korisnik pod korisničkim imenom " + request.KorisnickoIme + " već postoji");
                }
                else if(korisnik.KorisnickoIme!=null && korisnik.Email!=null)
                {
                    MessageBox.Show("Korisnik je uspješno kreiran");
                }
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
                errorProvider.SetError(txtPrezime, "Obavezno polje");
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
                errorProvider.SetError(txtEmail, "Obavezno polje");
                e.Cancel = true;
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Neispravan email format");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDatumRodjenja.Text) || txtDatumRodjenja.Value>DateTime.Now)
            {
                errorProvider.SetError(txtDatumRodjenja, "Previsok datum");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDatumRodjenja, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 3)
            {
                errorProvider.SetError(txtKorisnickoIme, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
