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
using QLyBanHangQuanAo.Class;

namespace QLyBanHangQuanAo
{
    public partial class frmtimkiemsanpham : Form
    {
        DataTable tblTKSP;
        public frmtimkiemsanpham()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            txtMaqao.Text = "";
            txtTenqao.Text = "";
            txtMaloai.Text = "";
            txtMaco.Text = "";
            txtMachatlieu.Text = "";
            txtMamua.Text = "";
            txtMadoituong.Text = "";
            txtMamua.Text = "";
            txtMaNSX.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaqao.Text == "") && (txtTenqao.Text == "") && (txtMaloai.Text == "") && (txtMaco.Text == "") && (txtMachatlieu.Text == "") && (txtMamau.Text == "") && (txtMadoituong.Text == "") && (txtMamua.Text == "") && (txtMaNSX.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM SanPham WHERE 1=1";
            if (txtMaqao.Text != "")
                sql = sql + "AND Maquanao Like N'%" + txtMaqao.Text + "%'";
            if (txtTenqao.Text != "")
                sql = sql + "AND Tenquanao Like N'%" + txtTenqao.Text + "%'";
            if (txtMaloai.Text != "")
                sql = sql + "AND Maloai Like N'%" + txtMaloai.Text + "%'";
            if (txtMaco.Text != "")
                sql = sql + "AND Maco Like N'%" + txtMaco.Text + "%'";
            if (txtMachatlieu.Text != "")
                sql = sql + "AND Machatlieu Like N'%" + txtMachatlieu.Text + "%'";
            if (txtMamau.Text != "")
                sql = sql + "AND Mamau Like N'%" + txtMamau.Text + "%'";
            if (txtMadoituong.Text != "")
                sql = sql + "AND Madoituong Like N'%" + txtMadoituong.Text + "%'";
            if (txtMamua.Text != "")
                sql = sql + "AND Mamua Like N'%" + txtMamua.Text + "%'";
            if (txtMaNSX.Text != "")
                sql = sql + "AND MaNSX Like N'%" + txtMaNSX.Text + "%'";
            tblTKSP = Functions.GetDataToTable(sql);
            if (tblTKSP.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblTKSP.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridView_tksp.DataSource = tblTKSP;
            ResetValues();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmtimkiemsanpham_Load(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView_tksp.DataSource = null;
        }

        private void DataGridView_tksp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
