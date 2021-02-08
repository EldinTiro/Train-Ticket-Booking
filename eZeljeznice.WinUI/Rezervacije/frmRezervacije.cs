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

namespace eZeljeznice.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _apiServiceNekompletiraneRez = new APIService("StatusRezervacije");

        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceNekompletiraneRez.Get<List<NekompletiraneRezervacijeResponse>>(null);

            dvgRezervacije.DataSource = result;
            dvgRezervacije.AutoResizeColumns();
            buttonPotvrdi.Enabled = false;

            dvgRezervacije.Columns[6].Visible = false;
            dvgRezervacije.Columns[7].Visible = false;
            dvgRezervacije.Columns[8].Visible = false;
            dvgRezervacije.Columns[9].Visible = false;
            dvgRezervacije.Columns[10].Visible = false;
            dvgRezervacije.Columns[11].Visible = false;
        }

        private void dvgRezervacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCijena.Text = dvgRezervacije.SelectedRows[0].Cells[4].Value.ToString();
            textBoxDatumPolaska.Text = dvgRezervacije.SelectedRows[0].Cells[1].Value.ToString();
            textBoxKupac.Text = dvgRezervacije.SelectedRows[0].Cells[7].Value.ToString();
            textBoxRelacija.Text = dvgRezervacije.SelectedRows[0].Cells[0].Value.ToString();
            if(textBoxCijena.Text == null || textBoxRelacija.Text == null)
            {
                buttonPotvrdi.Enabled = false;
            }else
                buttonPotvrdi.Enabled = true;
        }

        private async void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            int rezervacijaID = Int32.Parse(dvgRezervacije.SelectedRows[0].Cells[11].Value.ToString());

            RezervacijeVM rezervacijeVM = new RezervacijeVM();
            rezervacijeVM.RezervacijaId = rezervacijaID;

            try
            {
                await _apiServiceNekompletiraneRez.Update<RezervacijeVM>(rezervacijeVM);
                MessageBox.Show("Rezervacija je procesirana!");
                frmRezervacije_Load(sender, e);
                textBoxCijena.Text = null;
                textBoxDatumPolaska.Text = null;
                textBoxKupac.Text = null;
                textBoxRelacija.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
