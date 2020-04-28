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
using QLyBanHangQuanAo.Class;

namespace QLyBanHangQuanAo
{
    public partial class FrmTimHDB : Form
    {
        DataTable tblTKHDB;
        public FrmTimHDB()
        {
            InitializeComponent();
        }
        
        private void FrmTimHDB_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string sql;
            sql = "SELECT * from HoaDonBan";
            Functions.FillCombo(sql, cboMaNV, "MaNV");
            sql = "SELECT * from HoaDonBan";
            Functions.FillCombo(sql, cboMakhach, "Makhach");
            sql = "SELECT * from ChiTietHDBan";
            Functions.FillCombo(sql, cboMaquanao, "Maquanao");

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaNV.Text == "") && (cboMakhach.Text == "") && (cboMaquanao.Text == ""))
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm!", "Yeu cau...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            sql = "select a.SoHDB, b.SoHDB, b.Maquanao from HoaDonBan as a, ChiTietHDBan as b where a.SoHDB= b.SoHDB";
            sql = "select * from HoaDonBan where 1=1";
            /*   if (cboMaquanao.Text != "")
               {
                   sql = sql + "AND Maquanao Like N'%" + cboMaquanao.Text + "%'";
               }*/


            if (cboMaNV.Text != "")
            {
                sql = sql + "AND MaNV Like N'%" + cboMaNV.Text + "%'";
            }

            if (cboMakhach.Text != "")
            {
                sql = sql + "AND Makhach Like N'%" + cboMakhach.Text + "%'";
            }

            tblTKHDB = Functions.GetDataToTable(sql);
            if (tblTKHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Có" + tblTKHDB.Rows.Count + "bản ghi thỏa mãn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = tblTKHDB;
            loadDataToGridView();
        }
        private void loadDataToGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Số HĐB";
            dataGridView1.Columns[1].HeaderText = "Mã NV";
            dataGridView1.Columns[2].HeaderText = "Ngày bán";
            dataGridView1.Columns[3].HeaderText = "Mã khách";
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
