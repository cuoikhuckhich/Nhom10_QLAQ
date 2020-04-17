using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLyBanHangQuanAo.Class;
using System.Windows.Forms;

namespace QLyBanHangQuanAo
{
    public partial class FrmHDB : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable tblHDB;
        public FrmHDB()
        {
            InitializeComponent();
        }

        private void FrmHDB_Load(object sender, EventArgs e)
        {
            txtSoHDBan.Enabled = false ;
            loadDataToGridView();
        }
        private void resetvalues()
        {
            txtSoHDBan.Text = "";
            txtMaKhach.Text = "";
            txtMaNV.Text = "";
            dtpNgayban.Value = DateTime.Now;
            txtTongTien.Text = "";
            
        }
        private void loadDataToGridView()
        {
            string sql = "Select * From HoaDonBan";
            tblHDB = Class.Functions.GetDataToTable(sql);
            dataGridView_HDB.DataSource = tblHDB;
            dataGridView_HDB.Columns[0].HeaderText = " Số HD Bán";
            dataGridView_HDB.Columns[1].HeaderText = "Mã NV";
            dataGridView_HDB.Columns[2].HeaderText = "Ngày bán";
            dataGridView_HDB.Columns[3].HeaderText = "Mã Khách ";
            dataGridView_HDB.Columns[4].HeaderText = "Tổng tiền";
            dataGridView_HDB.Columns[0].Width = 100;
            dataGridView_HDB.Columns[1].Width = 150;
            dataGridView_HDB.Columns[2].Width = 150;
            dataGridView_HDB.Columns[3].Width = 150;
            dataGridView_HDB.Columns[3].Width = 150;
            dataGridView_HDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView_HDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
          
            txtSoHDBan.Text = "";
            txtMaKhach.Text = "";
            txtMaNV.Text = "";
            dtpNgayban.Value = DateTime.Now;
            txtTongTien.Text = "";
            txtSoHDBan.Enabled = true;
            loadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoHDBan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE HoaDonBan Where SoHDB=N'" + txtSoHDBan.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataToGridView();
               resetvalues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSoHDBan.Enabled = true;
            string sql = "update HoaDonBan set SoHDB=N'" +txtSoHDBan .Text +"',MaNV=N'"+ txtMaNV.Text + "',Makhach =N'" + txtMaKhach.Text + "',Ngayban=N'" + dtpNgayban.Value.ToString("MM/dd/yyyy") + "',Tongtien=N" + txtTongTien.Text + "where ( SoHDB =N'" + txtSoHDBan.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
             
           if (txtSoHDBan .Text =="")
            {
                MessageBox.Show("bạn cần nhập số HDBan");
                txtSoHDBan.Focus();
                return;
            }
            
            if (txtMaNV .Text =="")
            {
                MessageBox.Show("bạn cần nhập mã NV");
                txtMaNV.Focus();
                return;

            }
            if (txtMaKhach  .Text =="")
            {
                MessageBox.Show("bạn cần nhập mã khách");
                txtMaKhach.Focus();
                return;

            }
            if (txtTongTien .Text =="")
            {
                MessageBox.Show("Bạn cần nhập tổng tiền");
                txtTongTien.Focus();
                return;
            }
            sql = "select SoHDB from HoaDonBan Where SoHDB=N'" + txtSoHDBan.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Số Hóa Đơn đã có ,bạn phải nhập Số Hóa Đơn  khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoHDBan.Focus();
                txtSoHDBan.Text = "";
                return;
            }

            sql = "INSERT INTO HoaDonBan VALUES('" + txtSoHDBan.Text  + "','" + txtMaNV.Text + "','" + dtpNgayban.Value.ToString("MM/dd/yyyy") +
              "','" + txtMaKhach.Text+ "'," + txtTongTien.Text + ")";
                Class.Functions.RunSql(sql);
            
            loadDataToGridView();
           
            resetvalues();
           

        }

        private void dataGridView_HDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_HDB_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = dataGridView_HDB.CurrentRow.Cells["Makhach"].Value.ToString();
            txtMaNV.Text = dataGridView_HDB.CurrentRow.Cells["MaNV"].Value.ToString();
            dtpNgayban.Value = (DateTime)dataGridView_HDB.CurrentRow.Cells["Ngayban"].Value;
            txtSoHDBan.Text = dataGridView_HDB.CurrentRow.Cells["SoHDB"].Value.ToString();
            txtTongTien.Text = dataGridView_HDB.CurrentRow.Cells["Tongtien"].Value.ToString();
            txtSoHDBan.Enabled = false;
        }
    }
}
