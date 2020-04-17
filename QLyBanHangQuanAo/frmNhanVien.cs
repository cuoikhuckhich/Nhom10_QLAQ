using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyBanHangQuanAo.Class;
using System.Data.SqlClient;

namespace QLyBanHangQuanAo
{
    public partial class frmNhanVien : Form
    {
        DataTable tblNV;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            loadDataGridView();

        }
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            chkGioitinh.Checked = false;
            txtDiachi.Text = "";
            dtpNgaysinh.Value=DateTime.Now;
            txtDienthoai.Text = "";
            txtMaCV.Text = "";
        }
        private void loadDataGridView()
        {
            string sql = "Select * from NhanVien";
            tblNV = Class.Functions.GetDataToTable(sql);
            DataGridView_NhanVien.DataSource = tblNV;
        }

        private void DataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = DataGridView_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = DataGridView_NhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (DataGridView_NhanVien.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;
            txtDienthoai.Text = DataGridView_NhanVien.CurrentRow.Cells["Dienthoai"].Value.ToString();
            txtDiachi.Text = DataGridView_NhanVien.CurrentRow.Cells["Diachi"].Value.ToString();
            dtpNgaysinh.Value=(DateTime) DataGridView_NhanVien.CurrentRow.Cells["Ngaysinh"].Value;
            txtMaCV.Text = DataGridView_NhanVien.CurrentRow.Cells["MaCV"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
           
           
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Mã CV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            sql = "UPDATE NhanVien SET  TenNV=N'" + txtTenNV.Text.Trim().ToString() + "',Diachi=N'" + txtDiachi.Text.Trim().ToString() + "',Dienthoai='" + txtDienthoai.Text.ToString() + "',Gioitinh=N'" + gt + "',Ngaysinh='" + dtpNgaysinh.Value.ToString("MM/dd/yyyy") + "',MaCV=N'" + txtMaCV.Text.Trim().ToString() + "'  WHERE MaNV=N'" + txtMaNV.Text + "'";
            Functions.RunSql(sql);
            loadDataGridView();
            ResetValues();
       }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
           
         
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (txtMaCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCV.Focus();
                return;
            }
            sql = "SELECT MaNV FROM NhanVien WHERE MaNV=N'" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            sql = "INSERT INTO NhanVien VALUES('" + txtMaNV.Text + "','" + txtTenNV.Text + "','" + gt + "',"  + dtpNgaysinh.Value.ToString("MM/dd/yyyy") +",'"+ txtDiachi.Text+"'," +txtDienthoai.Text+",'" + txtMaCV.Text + "')";
            Functions.RunSql(sql);
            loadDataGridView();
            ResetValues();
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNV=N'" + txtMaNV.Text + "'";
                Class.Functions.RunSql(sql);
                loadDataGridView();
                ResetValues();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
