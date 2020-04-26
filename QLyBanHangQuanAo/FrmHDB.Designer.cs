namespace QLyBanHangQuanAo
{
    partial class FrmHDB
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoHDBan = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_HDB = new System.Windows.Forms.DataGridView();
            this.SoHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(202, 451);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(369, 451);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(880, 451);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(550, 451);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(716, 451);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số HDBán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Khách";
            // 
            // txtSoHDBan
            // 
            this.txtSoHDBan.Location = new System.Drawing.Point(294, 66);
            this.txtSoHDBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoHDBan.Name = "txtSoHDBan";
            this.txtSoHDBan.Size = new System.Drawing.Size(148, 26);
            this.txtSoHDBan.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(934, 66);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(148, 26);
            this.txtTongTien.TabIndex = 11;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(639, 66);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(148, 26);
            this.txtMaKhach.TabIndex = 13;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(294, 122);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(148, 26);
            this.txtMaNV.TabIndex = 14;
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayban.Location = new System.Drawing.Point(634, 126);
            this.dtpNgayban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(206, 26);
            this.dtpNgayban.TabIndex = 16;
            this.dtpNgayban.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // dataGridView_HDB
            // 
            this.dataGridView_HDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDB,
            this.MaNV,
            this.Ngayban,
            this.Makhach,
            this.Tongtien});
            this.dataGridView_HDB.Location = new System.Drawing.Point(202, 222);
            this.dataGridView_HDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_HDB.Name = "dataGridView_HDB";
            this.dataGridView_HDB.RowHeadersWidth = 62;
            this.dataGridView_HDB.Size = new System.Drawing.Size(832, 195);
            this.dataGridView_HDB.TabIndex = 17;
            this.dataGridView_HDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HDB_CellClick_1);
            this.dataGridView_HDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HDB_CellContentClick);
            // 
            // SoHDB
            // 
            this.SoHDB.DataPropertyName = "SoHDB";
            this.SoHDB.HeaderText = "Số HD Bán";
            this.SoHDB.MinimumWidth = 8;
            this.SoHDB.Name = "SoHDB";
            this.SoHDB.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // Ngayban
            // 
            this.Ngayban.DataPropertyName = "Ngayban";
            this.Ngayban.HeaderText = "Ngày bán";
            this.Ngayban.MinimumWidth = 8;
            this.Ngayban.Name = "Ngayban";
            this.Ngayban.Width = 150;
            // 
            // Makhach
            // 
            this.Makhach.DataPropertyName = "Makhach";
            this.Makhach.HeaderText = "Mã Khách";
            this.Makhach.MinimumWidth = 8;
            this.Makhach.Name = "Makhach";
            this.Makhach.Width = 150;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "tongtien";
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.MinimumWidth = 8;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Width = 150;
            // 
            // FrmHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView_HDB);
            this.Controls.Add(this.dtpNgayban);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtSoHDBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHDB";
            this.Text = "Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.FrmHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoHDBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayban;
        private System.Windows.Forms.DataGridView dataGridView_HDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
    }
}