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
    public partial class FrmHDNhap : Form
    {
        DataTable tblNhap;
        public FrmHDNhap()
        {
            InitializeComponent();
        }

        private void FrmHDNhap_Load(object sender, EventArgs e)
        {
            txtSoHDNhap.Enabled = false;
            loadDataToGridView();
        }
        private void resetvalues()
        {
            
            txtMaNCC.Text = "";
            txtMaNV.Text = "";
            dtpNgaynhap.Value = DateTime.Now;
            txtSoHDNhap.Text = "";
            txtTongTien.Text = "";
        }
        private void loadDataToGridView()
        {
            string sql = "Select * From HoaDonNhap";
            tblNhap = Class.Functions.GetDataToTable(sql);
            dataGridView_HDNhap.DataSource = tblNhap;
            
        }

        private void dataGridView_HDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dataGridView_HDNhap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtMaNV.Text = dataGridView_HDNhap.CurrentRow.Cells["MaNV"].Value.ToString();
            dtpNgaynhap.Value =(DateTime )dataGridView_HDNhap.CurrentRow.Cells["Ngaynhap"].Value;
            txtSoHDNhap.Text = dataGridView_HDNhap.CurrentRow.Cells["SoHDN"].Value.ToString();
            txtTongTien.Text = dataGridView_HDNhap.CurrentRow.Cells["TongTien"].Value.ToString();
            txtSoHDNhap.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtMaNV.Text = "";
            dtpNgaynhap.Value =DateTime.Now;
            txtSoHDNhap.Text = "";
            txtTongTien.Text = "";
            txtSoHDNhap.Enabled = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close(); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from HoaDonNhap where SoHDN=N'" + txtSoHDNhap.Text + "'";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSoHDNhap.Enabled = true;
            string sql = "update HoaDonNhap set SoHDN=N'" +txtSoHDNhap.Text +"',MaNV=N'" + txtMaNV.Text + "',MaNCC=N'" + txtMaNCC.Text + "',Ngaynhap=N'" + dtpNgaynhap.Value.ToString("MM/dd/yyyy") + "',TongTien=N'" + txtTongTien.Text + "'where (SoHDN=N'" + txtSoHDNhap.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtSoHDNhap .Text =="")
            {
                MessageBox.Show("Bạn cần nhập SoHDN");
                txtSoHDNhap.Focus();
                return;
            }
            if (txtMaNCC .Text =="")
            {
                MessageBox.Show("Bạn cần nhập mã NCC");
                txtMaNCC.Focus();
                return;
            }
            if (txtMaNV .Text =="")
            {
                MessageBox.Show("Bạn cần nhập mã NV");
                txtMaNV.Focus();
                return;
            }
           
            if (txtTongTien.Text == "")
            {
                MessageBox.Show("bạn cần nhập tổng tiền");
                txtTongTien.Focus();
                return;
            }
            sql = "select SoHDN from HoaDonNhap Where SoHDN=N'" + txtSoHDNhap.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Số Hóa Đơn đã có ,bạn phải nhập Số Hóa Đơn  khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoHDNhap.Focus();
                txtSoHDNhap.Text = "";
                return;
            }
            sql = "insert into HoaDonNhap values(' " + txtSoHDNhap.Text + "','" + txtMaNV.Text + "','" + dtpNgaynhap.Value.ToString("MM/dd/yyyy") + "','" + txtMaNCC.Text + "','" + txtTongTien.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }
       
    }
}
