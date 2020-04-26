using QLyBanHangQuanAo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyBanHangQuanAo
{
    public partial class frmbaocaohdn : Form
    {
        DataTable tblBCHDN;
        public frmbaocaohdn()
        {
            InitializeComponent();
        }

        private void frmbaocaohdn_Load(object sender, EventArgs e)
        {
            txtTong.Enabled = false;
            Functions.ketnoi();
            ResetValues();
            DataGridViewBCHDN.DataSource = null;
        }
        private void ResetValues()
        {
            txtMancc.Text = "";
            txtTong.Text = "";
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            string sql;
            Double tong;
            if (txtMancc.Text == "")
            {
                MessageBox.Show("Hãy nhập mã nhà cung cấp!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT a.SoHDN, a.MaNV, a.Ngaynhap, b.Maquanao, b.Soluong, b.Dongia, b.Giamgia, b.Thanhtien, a.TongTien FROM HoaDonNhap AS a , ChiTietHDNhap AS b WHERE 1=1 AND a.SoHDN=b.SoHDN ";
            if (txtMancc.Text != "")
                sql = sql + "AND MaNCC Like N'%" + txtMancc.Text + "%'";
            tblBCHDN = Functions.GetDataToTable(sql);
            if (tblBCHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
            {
                MessageBox.Show("Có " + tblBCHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT sum(TongTien) FROM HoaDonNhap WHERE MaNCC=N'" + txtMancc.Text + "'"));
                Functions.RunSql(sql);
                txtTong.Text = tong.ToString();
            }
            DataGridViewBCHDN.DataSource = tblBCHDN;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
