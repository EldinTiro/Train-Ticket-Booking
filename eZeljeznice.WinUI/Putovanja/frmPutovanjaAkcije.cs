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
    public partial class frmPutovanjaAkcije : Form
    {
        private readonly APIService _apiService = new APIService("putovanje");
        private readonly APIService _apiServiceZeljeznicke = new APIService("ZeljeznickeStanice");
        public frmPutovanjaAkcije()
        {
            InitializeComponent();
        }

        private async void btnKreirajAkciju_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new PutovanjaAkcijaRequest
                {
                    ZeljeznickaStanicaODID = (cmbxPolazisteAkcija.SelectedIndex),
                    ZeljeznickaStanicaDOID = (cmbxOdredisteAkcija.SelectedIndex),
                    AkcijaOD = datetimePickerPocetkaAkcije.Value,
                    AkcijaDO = dateTimePickerZavrsetkaAkcije.Value,
                    VrijednostAkcije = (int)comboBoxVrijednostAkcije.SelectedValue
                };

                    var result = await _apiService.Update<List<string>>(search);
                    if (result != null && result.Count!=0)
                    {
                        MessageBox.Show("Akcija kreirana uspješno za "+result.Count+" putovanja!");
                    }
                    else
                    {
                        MessageBox.Show("Za odabranu akciju nema adekvatnih putovanja");
                    }

            }

        }

        private async void frmPutovanjaAkcije_Load(object sender, EventArgs e)
        {
                var result = await _apiServiceZeljeznicke.Get<List<ZeljeznickeStaniceVM>>();

                List<string> zeljezniceListOD = result.Select(x => x.Naziv).ToList();
                zeljezniceListOD.Insert(0, "");

                List<string> zeljezniceListDO = result.Select(x => x.Naziv).ToList();
                zeljezniceListDO.Insert(0, "");

                var listOfActionValue = new List<int>();
                listOfActionValue.Add(10);
                listOfActionValue.Add(20);
                listOfActionValue.Add(30);
                listOfActionValue.Add(40);
                listOfActionValue.Add(50);

                cmbxPolazisteAkcija.DataSource = zeljezniceListOD;
                cmbxOdredisteAkcija.DataSource = zeljezniceListDO;
                comboBoxVrijednostAkcije.DataSource = listOfActionValue;
            
        }

        /*private void comboBoxVrijednostAkcije_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxVrijednostAkcije.SelectedText))
            {
                errorProvider.SetError(comboBoxVrijednostAkcije, );
                e.Cancel = true;
            }
        }*/
    }
}
