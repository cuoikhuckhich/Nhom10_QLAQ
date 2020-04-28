using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyBanHangQuanAo.Class;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLyBanHangQuanAo
{
    public partial class FrmBaoCaoHDB : Form
    {
        DataTable tblBaocao;
        public FrmBaoCaoHDB()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void FrmBaoCaoHDB_Load(object sender, EventArgs e)
        {
            Functions.ketnoi();
            resetvalues();
            dataGridView_BaoCao.DataSource = null;

        }
        private void resetvalues()
        {
            txtThang.Text = "";
            txtNam.Text = "";
         
            txtTongtien.Text = "0";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string sql;
            Double tong;
            sql = "select SoHDB,MaNV,Ngayban,Makhach,Tongtien from HoaDonBan WHERE 1=1 ";
            if ( txtThang .Text != "")
                sql = sql + " AND MONTH(Ngayban) =" + txtThang .Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(Ngayban) =" + txtNam.Text;
            
            tblBaocao  = Functions .GetDataToTable(sql);
            if (tblBaocao.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues ();
            }
            else
            {
                MessageBox.Show("Có " + tblBaocao .Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tong = Convert.ToDouble(Functions.Duongdananh("SELECT sum(Tongtien) FROM HoaDonBan WHERE MONTH(Ngayban)='" + txtThang.Text + "'OR YEAR(Ngayban)= '" + txtNam.Text + "'"));
                Class.Functions.RunSql(sql);   
                txtTongtien.Text = tong.ToString();
            }
            dataGridView_BaoCao.DataSource = tblBaocao;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            resetvalues();
            dataGridView_BaoCao.DataSource = null;
        }

        
    }
}
