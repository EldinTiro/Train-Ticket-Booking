using eZeljeznice.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZeljeznice.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                KorisniciVM korisnik = await _service.Authenticiraj<KorisniciVM>(txtUsername.Text, txtPassword.Text);

                if (korisnik != null)
                {

                    MessageBox.Show("Dobrodosli " + korisnik.Ime + " " + korisnik.Prezime);
                    DialogResult = DialogResult.OK;
                    frmIndex frm = new frmIndex();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Pogresan username ili password", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
