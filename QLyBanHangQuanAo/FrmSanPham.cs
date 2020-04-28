﻿using System;
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
    public partial class FrmSanPham : Form
    {
        DataTable tblSP;
        public FrmSanPham()
        {
            InitializeComponent();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetvalues();
            txtMaquanao.Enabled = true;


        }
        private void resetvalues()
        {
            txtMaquanao.Text = "";
            txtTenquanao.Text = "";
            cboMaloai.Text = "";
            cboMaco.Text = "";
            cboMachatlieu.Text = "";
            cboMamua.Text = "";
            cboMadoituong.Text = "";
            cboMamua.Text = "";
            cboMaNSX.Text = "";
            txtSoluong.Text = "";
            txtAnh.Text = "";
            txtĐongiaban.Text = "";
            txtĐongianhap.Text = "";
        }
        private void loadDataGridView()
        {
            string sql = "Select * from SanPham";
            tblSP = Class.Functions.GetDataToTable(sql);
            DataGridView_SanPham.DataSource = tblSP;
           
        }


        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            txtMaquanao.Enabled = false;
            string sql;
            sql = "SELECT * from TheLoai";
            Functions.FillCombo(sql, cboMaloai, "Maloai");
            sql = "SELECT * from Co";
            Functions.FillCombo(sql, cboMaco, "Maco");
            sql = "SELECT * from ChatLieu";
            Functions.FillCombo(sql, cboMachatlieu, "Machatlieu");
            sql = "SELECT * from Mua";
            Functions.FillCombo(sql, cboMamua, "Mamua");
            sql = "SELECT * from DoiTuong";
            Functions.FillCombo(sql, cboMadoituong, "Madoituong");
            sql = "SELECT * from Mau";
            Functions.FillCombo(sql, cboMamau, "Mamau");
            sql = "SELECT * from NoiSanXuat";
            Functions.FillCombo(sql, cboMaNSX, "MaNSX");
            cboMaloai.SelectedIndex = -1;
            loadDataGridView();
        }

        private void DataGridView_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaquanao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = " UPDATE SanPham SET Maquanao=N'" + txtMaquanao.Text.Trim() + "',Tenquanao =N'" + txtTenquanao.Text.Trim() + "',Maloai =N'" + cboMaloai.SelectedValue.ToString() +
                   "' ,Maco =N'" + cboMaco.SelectedValue.ToString() + "',Machatlieu =N'" + cboMachatlieu.SelectedValue.ToString() + "',Mamau =N'" + cboMamau.SelectedValue.ToString() + "',Madoituong =N'" + cboMadoituong.SelectedValue.ToString()+
                     "' ,Mamua =N'" + cboMamua.SelectedValue.ToString() + "',MaNSX =N'" + cboMaNSX.SelectedValue.ToString() + "',Soluong =N'" + txtSoluong.Text + "',Anh =N'" + txtAnh.Text.Trim() + "',Đongianhap =N'" + txtĐongianhap.Text + "',Đongiaban =N'" + txtĐongiaban.Text +
                    "' Where (Maquanao=N'" + txtMaquanao.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            loadDataGridView();



        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaquanao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quần áo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaquanao.Focus();
                return;
            }

            if (txtTenquanao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quần áo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenquanao.Focus();
                return;
            }
            if (cboMaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               cboMaloai.Focus();
                return;
            }
            if(cboMaco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaco.Focus();
                return;
            }
            if (cboMachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMachatlieu.Focus();
                return;
            }
            if (cboMadoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã đối tượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMadoituong.Focus();
                return;
            }
            if (cboMamua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Mùa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMamua.Focus();
                return;
            }
            if (cboMamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Màu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMamau.Focus();
                return;
            }
            if (cboMaNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã nhà sản xuất ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNSX.Focus();
                return;
            }

            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnMo.Focus();
                return;
            }
            sql = "SELECT Maquanao FROM SanPham WHERE Maquanao=N'" + txtMaquanao.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã quần áo này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaquanao.Focus();
                return;
            }
            sql = "insert into SanPham(Maquanao,Tenquanao,Maloai,Maco,Machatlieu,Mamau,Madoituong,Mamua,MaNSX,Soluong,Anh,Đongianhap,Đongiaban) values(N'" + txtMaquanao.Text.Trim() +"',N'"+ txtTenquanao.Text.Trim()
                +"',N'"+cboMaloai.SelectedValue.ToString()+ "',N'" + cboMaco.SelectedValue.ToString() + "',N'" + cboMachatlieu.SelectedValue.ToString() + "',N'" + cboMamau.SelectedValue.ToString() + "',N'" + cboMadoituong.SelectedValue.ToString() + "',N'" + cboMamua.SelectedValue.ToString() + "',N'" + cboMaNSX.SelectedValue.ToString() 
                + "','" + txtSoluong.Text + "',N'" + txtAnh.Text.Trim() + "','" + txtĐongianhap.Text + "','" + txtĐongiaban.Text.Trim() +"')";

            Functions.RunSql(sql);
            loadDataGridView();
            resetvalues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaquanao.Enabled = false;
        }





        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaquanao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có Muốn xóa bản ghi không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE SanPham Where Maquanao=N'" + txtMaquanao.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();

            }

        }

        private void DataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaquanao.Text = DataGridView_SanPham.CurrentRow.Cells["Maquanao"].Value.ToString();
            txtTenquanao.Text = DataGridView_SanPham.CurrentRow.Cells["Tenquanao"].Value.ToString();
            cboMaloai.Text = DataGridView_SanPham.CurrentRow.Cells["Maloai"].Value.ToString();
           cboMaco.Text = DataGridView_SanPham.CurrentRow.Cells["Maco"].Value.ToString();
            cboMachatlieu.Text = DataGridView_SanPham.CurrentRow.Cells["Machatlieu"].Value.ToString();
            cboMamau.Text = DataGridView_SanPham.CurrentRow.Cells["Mamau"].Value.ToString();
            cboMadoituong.Text = DataGridView_SanPham.CurrentRow.Cells["Madoituong"].Value.ToString();
            cboMamau.Text = DataGridView_SanPham.CurrentRow.Cells["Mamua"].Value.ToString();
            cboMaNSX.Text = DataGridView_SanPham.CurrentRow.Cells["MaNSX"].Value.ToString();
            txtSoluong.Text = DataGridView_SanPham.CurrentRow.Cells["Soluong"].Value.ToString();
            sql = "select Anh from SanPham Where Maquanao=N'" + txtMaquanao.Text + "'";
            txtAnh.Text = Functions.Duongdananh(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            txtĐongianhap.Text = DataGridView_SanPham.CurrentRow.Cells["Đongianhap"].Value.ToString();
            txtĐongiaban.Text = DataGridView_SanPham.CurrentRow.Cells["Đongiaban"].Value.ToString();
            txtMaquanao.Enabled = false;
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog duonglink = new OpenFileDialog();
            duonglink.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All fies(*.*)|*.*";
            duonglink.FilterIndex = 2;
            duonglink.Title = "Chọn ảnh cho sản phẩm ";
            if(duonglink.ShowDialog()==DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(duonglink.FileName);
                txtAnh.Text = duonglink.FileName;
            }    
        }

        private void txtĐongianhap_TextChanged(object sender, EventArgs e)
        {
            double dgn, dgb;
            if (txtĐongianhap.Text == "") dgn = 0;
            else dgn = Convert.ToDouble(txtĐongianhap.Text);
            dgb = dgn * 1.1;
            txtĐongiaban.Text = dgb.ToString();
            loadDataGridView();
        }
    }
}
   

