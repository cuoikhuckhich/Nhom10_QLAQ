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
            txtGiamGia.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Giamgia"].Value.ToString();
            cboMaquanao.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["Maquanao"].Value.ToString();
            cboSoHDB.Text = dataGridView_ChiTietHDBan.CurrentRow.Cells["SoHDB"].Value.ToString();
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
            double sl,slcon;
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
             
            //   kiemtra sô lương hàng còn tồn tại trong kho

            sl = Convert.ToDouble(Functions.Duongdananh("SELECT SoLuong FROM SanPham WHERE Maquanao = N'" + cboMaquanao.SelectedValue.ToString() + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }

             sql = " Insert into ChiTietHDBan(SoHDB, Maquanao, Soluong, Giamgia, Thanhtien) values('" + cboSoHDB.SelectedValue.ToString() + "','" + cboMaquanao.SelectedValue.ToString() + "','" + txtSoLuong.Text + "','" + txtGiamGia.Text + "','" + txtThanhTien.Text + "')";
            Class.Functions.RunSql(sql);
            loadDataToGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            slcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE SanPham SET Soluong =" + slcon + " WHERE Maquanao= N'" + cboMaquanao.SelectedValue.ToString() + "'";
            Functions.RunSql(sql);
            resetvalues();
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
