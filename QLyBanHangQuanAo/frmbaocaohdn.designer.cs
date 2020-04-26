namespace QLyBanHangQuanAo
{
    partial class frmbaocaohdn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.DataGridViewBCHDN = new System.Windows.Forms.DataGridView();
            this.SoHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maquanao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBCHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // txtMancc
            // 
            this.txtMancc.Location = new System.Drawing.Point(175, 56);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(158, 26);
            this.txtMancc.TabIndex = 1;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(588, 56);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(158, 26);
            this.txtTong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền";
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(121, 366);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(111, 36);
            this.btnBaocao.TabIndex = 5;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(549, 366);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DataGridViewBCHDN
            // 
            this.DataGridViewBCHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBCHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDN,
            this.MaNV,
            this.Ngaynhap,
            this.Maquanao,
            this.Soluong,
            this.Dongia,
            this.Giamgia,
            this.Thanhtien,
            this.TongTien});
            this.DataGridViewBCHDN.Location = new System.Drawing.Point(48, 148);
            this.DataGridViewBCHDN.Name = "DataGridViewBCHDN";
            this.DataGridViewBCHDN.RowHeadersWidth = 62;
            this.DataGridViewBCHDN.RowTemplate.Height = 28;
            this.DataGridViewBCHDN.Size = new System.Drawing.Size(698, 157);
            this.DataGridViewBCHDN.TabIndex = 4;
            // 
            // SoHDN
            // 
            this.SoHDN.DataPropertyName = "SoHDN";
            this.SoHDN.HeaderText = "Số HDN";
            this.SoHDN.MinimumWidth = 8;
            this.SoHDN.Name = "SoHDN";
            this.SoHDN.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "Ngaynhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.MinimumWidth = 8;
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.Width = 150;
            // 
            // Maquanao
            // 
            this.Maquanao.DataPropertyName = "Maquanao";
            this.Maquanao.HeaderText = "Mã quần áo";
            this.Maquanao.MinimumWidth = 8;
            this.Maquanao.Name = "Maquanao";
            this.Maquanao.Width = 150;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 8;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 150;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 8;
            this.Dongia.Name = "Dongia";
            this.Dongia.Width = 150;
            // 
            // Giamgia
            // 
            this.Giamgia.DataPropertyName = "Giamgia";
            this.Giamgia.HeaderText = "Giảm giá";
            this.Giamgia.MinimumWidth = 8;
            this.Giamgia.Name = "Giamgia";
            this.Giamgia.Width = 150;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 8;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 150;
            // 
            // frmbaocaohdn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.DataGridViewBCHDN);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMancc);
            this.Controls.Add(this.label1);
            this.Name = "frmbaocaohdn";
            this.Text = "Báo cáo hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmbaocaohdn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBCHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMancc;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView DataGridViewBCHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maquanao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}