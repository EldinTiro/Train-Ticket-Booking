using eZeljeznice.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReportPutovanja : Form
    {
        List<PutovanjaVM> putovanja = null;
        public frmReportPutovanja(List<PutovanjaVM> putovanja)
        {
            InitializeComponent();
            this.putovanja = putovanja;
        }

        private void frmReportPutovanja_Load(object sender, EventArgs e)
        {

            try
            {
                ReportDataSource rs2 = new ReportDataSource("PutovanjaDataSet", putovanja);
                reportViewer1.LocalReport.DataSources.Add(rs2);

                reportViewer1.LocalReport.ReportEmbeddedResource = "eZeljeznice.WinUI.rptPutovanja.rdlc";

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
