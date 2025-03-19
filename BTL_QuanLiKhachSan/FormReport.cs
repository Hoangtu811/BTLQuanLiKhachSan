using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BTL_QuanLiKhachSan
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_QuanLiKhachSan.Report1.rdlc";

                ReportDataSource rds = new ReportDataSource("DataSet1", modify.getAllDichVu());
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
