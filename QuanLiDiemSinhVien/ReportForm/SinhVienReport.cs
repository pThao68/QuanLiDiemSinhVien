using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemSinhVien.ReportForm
{
    public partial class SinhVienReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDiem"].ConnectionString;
        ReportDocument cryrpt = new ReportDocument();
        public SinhVienReport()
        {
            InitializeComponent();
        }

        private void SinhVienReport_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\ADO.NET\QuanLiDiemSinhVien\QuanLiDiemSinhVien\Report\SinhVien.rpt");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet data = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_SinhVIen", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
        }
    }
}
