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
    public partial class frmChiTietHDNhap : Form
    {
        DataTable tblCTHDN;
        public frmChiTietHDNhap()
        {
            InitializeComponent();
        }

        private void resetvalue()
        {
            cboMaquanao.Text = "";
            cboSoHDN.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            txtSoluong.Text = "";
            txtThanhtien.Text = "";
        }
        private void loadDataGridView()
        {
            string sql = "Select * from ChiTietHDNhap";
            tblCTHDN = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblCTHDN;
        }

        private void frmChiTietHDNhap_Load(object sender, EventArgs e)
        {
            cboSoHDN.Enabled = false;
            btnThem.Enabled = true;
            string sql;
            sql = "SELECT * from SanPham";
            Functions.FillCombo(sql, cboMaquanao, "Maquanao");
            cboMaquanao.SelectedIndex = -1;
            sql = "select * from HoaDonNhap";
            Functions.FillCombo(sql, cboSoHDN, "SoHDN");
            loadDataGridView();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetvalue();
            cboSoHDN.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            cboSoHDN.Focus();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (cboSoHDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số HĐ nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSoHDN.Focus();
                return;
            }
            
            if (cboMaquanao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quần áo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaquanao.Focus();
                return;
            }

            sql = "UPDATE ChiTietHDNhap SET SoHDN =N'" + cboSoHDN.SelectedValue.ToString() + "',Maquanao =N'" + cboMaquanao.SelectedValue.ToString() +"',Soluong=" +txtSoluong.Text+ ",Dongia =" + txtDongia.Text + ",Giamgia =" + txtGiamgia.Text + ",Thanhtien =" + txtThanhtien.Text + "WHERE (SoHDN='" + cboSoHDN.SelectedValue.ToString() + "')";
            Functions.RunSql(sql);
            loadDataGridView();
            resetvalue();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
        
            if (cboSoHDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập SoHDB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSoHDN.Focus();
                return;

            }
            if (cboMaquanao.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn cần nhập mã quần áo");
                cboMaquanao.Focus();
                return;
            }
            if (txtGiamgia.Text == "")
            {
                MessageBox.Show("bạn cần nhập mã giảm giá");
                txtGiamgia.Focus();
                return;


            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("bạn cần nhập số lượng");
                txtSoluong.Focus();
                return;

            }
            if (txtThanhtien.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thành tiền");
                txtThanhtien.Focus();
                return;

            }
            sql = "select SoHDN from ChiTietHDNhap Where SoHDN=N'" + cboSoHDN.SelectedValue.ToString() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Số Hóa Đơn đã có ,bạn phải nhập Số Hóa Đơn  khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSoHDN.Focus();
                return;
            }
            sql = " Insert into ChiTietHDNhap(SoHDN, Maquanao, Soluong,Dongia, Giamgia, Thanhtien) values('" + cboSoHDN.SelectedValue.ToString() + "','" + cboMaquanao.SelectedValue.ToString() + "','" + txtSoluong.Text +"','"+txtDongia.Text+ "','" + txtGiamgia.Text + "','" + txtThanhtien.Text + "')";
            Class.Functions.RunSql(sql);

            loadDataGridView();
            resetvalue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboSoHDN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE ChiTietHDNhap Where SoHDN=N'" + cboSoHDN.SelectedValue.ToString() + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                resetvalue();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           cboMaquanao.Text = dataGridView1.CurrentRow.Cells["Maquanao"].Value.ToString();
            cboSoHDN.Text = dataGridView1.CurrentRow.Cells["SoHDN"].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDongia.Text = dataGridView1.CurrentRow.Cells["Dongia"].Value.ToString();
            txtGiamgia.Text = dataGridView1.CurrentRow.Cells["Giamgia"].Value.ToString();
            txtThanhtien.Text = dataGridView1.CurrentRow.Cells["Thanhtien"].Value.ToString();
            cboSoHDN.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}
 
