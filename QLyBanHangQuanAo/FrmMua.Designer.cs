namespace QLyBanHangQuanAo
{
    partial class FrmMua
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
            this.DataGridView_Mua = new System.Windows.Forms.DataGridView();
            this.Mamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMamua = new System.Windows.Forms.TextBox();
            this.txtTenmua = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Mua)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Mua
            // 
            this.DataGridView_Mua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Mua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mamua,
            this.Tenmua});
            this.DataGridView_Mua.Location = new System.Drawing.Point(237, 295);
            this.DataGridView_Mua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView_Mua.Name = "DataGridView_Mua";
            this.DataGridView_Mua.RowHeadersWidth = 62;
            this.DataGridView_Mua.Size = new System.Drawing.Size(614, 205);
            this.DataGridView_Mua.TabIndex = 0;
            this.DataGridView_Mua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Mua_CellClick);
            // 
            // Mamua
            // 
            this.Mamua.DataPropertyName = "Mamua";
            this.Mamua.HeaderText = "Mã Mùa";
            this.Mamua.MinimumWidth = 8;
            this.Mamua.Name = "Mamua";
            this.Mamua.Width = 150;
            // 
            // Tenmua
            // 
            this.Tenmua.DataPropertyName = "Tenmua";
            this.Tenmua.HeaderText = "Tên Mùa";
            this.Tenmua.MinimumWidth = 8;
            this.Tenmua.Name = "Tenmua";
            this.Tenmua.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Mùa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Mùa";
            // 
            // txtMamua
            // 
            this.txtMamua.Location = new System.Drawing.Point(171, 78);
            this.txtMamua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMamua.Name = "txtMamua";
            this.txtMamua.Size = new System.Drawing.Size(264, 26);
            this.txtMamua.TabIndex = 3;
            // 
            // txtTenmua
            // 
            this.txtTenmua.Location = new System.Drawing.Point(171, 198);
            this.txtTenmua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenmua.Name = "txtTenmua";
            this.txtTenmua.Size = new System.Drawing.Size(264, 26);
            this.txtTenmua.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(88, 589);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 54);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(956, 589);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 54);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(764, 589);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 54);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(572, 589);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 54);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(332, 589);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 54);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenmua);
            this.Controls.Add(this.txtMamua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_Mua);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMua";
            this.Text = "Mua";
            this.Load += new System.EventHandler(this.FrmMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Mua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Mua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMamua;
        private System.Windows.Forms.TextBox txtTenmua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmua;
    }
}