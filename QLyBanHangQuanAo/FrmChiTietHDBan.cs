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
    public partial class FrmChiTietHDBan : Form
    {
        DataTable tblCTHDBan;
        public FrmChiTietHDBan()
        {
            InitializeComponent();
        }

        private void FrmChiTietHDBan_Load(object sender, EventArgs e)
        {
            cboSoHDB.Enabled = false;
          
            string sql;
            sql = "SELECT * from SanPham";
            Functions.FillCombo(sql, cboMaquanao, "Maquanao");
            cboMaquanao.SelectedIndex = -1;
            sql = "select * from HoaDonBan";
            Functions.FillCombo(sql, cboSoHDB, "SoHDB");
        
            loadDataToGridView();

        }
        private void loadDataToGridView()
        {
            string sql = "Select * From ChiTietHDBan";
            tblCTHDBan = Class.Functions.GetDataToTable(sql);
            dataGridView_ChiTietHDBan.DataSource = tblCTHDBan;
        }
        private void resetvalues()
        {
            txtGiamGia.Text = "";
            cboMaquanao.Text = "";
            cboSoHDB.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }
      
        private void dataGridView_ChiTietHDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Maquanao;
            string sql;
            txtGiamGia.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Giamgia"].Value.ToString();
            cboMaquanao.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Maquanao"].Value.ToString();
            cboSoHDB.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["SoHDB"].Value.ToString();
            
            //  Maquanao = dataGridView_ChiTietHDBan.CurrentRow.Cells["Maquanao"].Value.ToString();
            //  sql = "SELECT  FROM SanPham WHERE Maquanao=N'" + Maquanao + "'";
            //  cboMaquanao.Text = Functions.Duongdananh(sql);
            txtSoLuong.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Soluong"].Value.ToString();
            txtThanhTien.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Thanhtien"].Value.ToString();
            cboSoHDB.Enabled = false;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGiamGia.Text = "";
            cboMaquanao.Text = "";
            cboSoHDB.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            cboSoHDB.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ChiTietHDBan where SoHDB=N'" + cboSoHDB.Text + "'";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboSoHDB.Text.Trim().Length==0 )
            {
                MessageBox.Show("Bạn phải nhập SoHDB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSoHDB.Focus();
                return;

            }
            if (cboMaquanao.Text.Trim().Length == 0)
            { 
                MessageBox.Show("bạn cần nhập mã quần áo");
               cboMaquanao.Focus();
                return;
            }
            if (txtGiamGia.Text == "")
            {
                MessageBox.Show("bạn cần nhập mã giảm giá");
                txtGiamGia.Focus();
                return;

               
            }
            if ( txtSoLuong .Text == "")
            {
                MessageBox.Show("bạn cần nhập số lượng");
                txtSoLuong.Focus();
                return;

            }
            if (txtThanhTien .Text =="")
            {
                MessageBox.Show("Bạn cần nhập thành tiền");
                txtThanhTien.Focus();
                return;

            }
            sql = "select SoHDB from ChitietHDBan Where SoHDB=N'" + cboSoHDB.SelectedValue.ToString() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Số Hóa Đơn đã có ,bạn phải nhập Số Hóa Đơn  khác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               cboSoHDB.Focus();
                return;
            }
             sql = " Insert into ChiTietHDBan(SoHDB, Maquanao, Soluong, Giamgia, Thanhtien) values('" + cboSoHDB.SelectedValue.ToString() + "','" + cboMaquanao.SelectedValue.ToString() + "','" + txtSoLuong.Text + "','" + txtGiamGia.Text + "','" + txtThanhTien.Text + "')";


            Class.Functions.RunSql(sql);
            
            loadDataToGridView();
            resetvalues();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           string sql = "UPDATE ChiTietHDBan SET SoHDB =N'" + cboSoHDB.SelectedValue.ToString() + "',Maquanao =N'" + cboMaquanao.SelectedValue.ToString() + "',Soluong=" + txtSoLuong.Text + ",Giamgia =" + txtGiamGia.Text + ",Thanhtien =" + txtThanhTien.Text + "WHERE (SoHDB='" + cboSoHDB.SelectedValue.ToString() + "')";
            Functions.RunSql(sql);
            loadDataToGridView();
            resetvalues();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
