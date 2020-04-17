using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QLyBanHangQuanAo
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {

            this.rpvkhachhang.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTaobaocao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QlyBanHangQuanAoConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BaoCaoKhachhang";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Nam", txtNam.Text));
            //khai báo dataset để chữa giữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            rpvkhachhang.ProcessingMode = ProcessingMode.Local;
            rpvkhachhang.LocalReport.ReportPath = "RptBaoCao.rdlc";
            MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            if (ds.Tables[0].Rows.Count >0)
            {
                ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DtsKhachhang";
                rds.Value = ds.Tables[0];
                rpvkhachhang.LocalReport.DataSources.Clear();
                rpvkhachhang.LocalReport.DataSources.Add(rds);
                rpvkhachhang.RefreshReport();


            }    

        }
    }
}
