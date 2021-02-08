using eZeljeznice.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZeljeznice.WinUI.Kupljene_Karte
{
    public partial class frmReportKupljeneKarte : Form
    {
        List<ProdanaKartaVM> polazne = null;
        List<ProdanaKartaVM> odlazne = null;
        public frmReportKupljeneKarte(List<ProdanaKartaVM> polazne, List<ProdanaKartaVM> odlazne)
        {
            InitializeComponent();
            this.polazne = polazne;
            this.odlazne = odlazne;
        }

        private void frmReportKupljeneKarte_Load(object sender, EventArgs e)
        {
            try
            {

                ReportDataSource rs2 = new ReportDataSource("PolazneDataSet", polazne);
                ReportDataSource rs3 = new ReportDataSource("DolazneDataSet", odlazne);

                reportViewer1.LocalReport.DataSources.Add(rs2);
                reportViewer1.LocalReport.DataSources.Add(rs3);

                reportViewer1.LocalReport.ReportEmbeddedResource = "eZeljeznice.WinUI.rptProdaneKarte.rdlc";
                //reportViewer1.LocalReport.ReportPath = "eZeljeznice.WinUI.RprtKupljeneKarte.rdlc";


                reportViewer1.Dock = DockStyle.Fill;
                this.Controls.Add(reportViewer1);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
