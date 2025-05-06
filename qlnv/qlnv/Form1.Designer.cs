namespace qlnv
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid_nhanvien = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýMónĂnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinProjectToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thôngTinProjectToolStripMenuItem
            // 
            this.thôngTinProjectToolStripMenuItem.Name = "thôngTinProjectToolStripMenuItem";
            this.thôngTinProjectToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.thôngTinProjectToolStripMenuItem.Text = "thông tin project";
            this.thôngTinProjectToolStripMenuItem.Click += new System.EventHandler(this.thôngTinProjectToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.thoátToolStripMenuItem.Text = "thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýMónĂnToolStripMenuItem
            // 
            this.quảnLýMónĂnToolStripMenuItem.Name = "quảnLýMónĂnToolStripMenuItem";
            this.quảnLýMónĂnToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.quảnLýMónĂnToolStripMenuItem.Text = "Quản lý món ăn";
            // 
            // grid_nhanvien
            // 
            this.grid_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_nhanvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_nhanvien.Location = new System.Drawing.Point(12, 48);
            this.grid_nhanvien.Name = "grid_nhanvien";
            this.grid_nhanvien.RowHeadersWidth = 51;
            this.grid_nhanvien.RowTemplate.Height = 24;
            this.grid_nhanvien.Size = new System.Drawing.Size(457, 309);
            this.grid_nhanvien.TabIndex = 1;
            this.grid_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_nhanvien_CellContentClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(546, 353);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(640, 353);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(733, 353);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(574, 53);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(244, 22);
            this.txt_manv.TabIndex = 6;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(574, 94);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(244, 22);
            this.txt_hoten.TabIndex = 7;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(574, 144);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(244, 22);
            this.txt_diachi.TabIndex = 8;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(574, 223);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(244, 22);
            this.txt_dienthoai.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "mã nv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "điện thoại";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(574, 188);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(244, 22);
            this.dtp_ngaysinh.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "tìm kiếm";
            // 
            // cbTenNhanVien
            // 
            this.cbTenNhanVien.FormattingEnabled = true;
            this.cbTenNhanVien.Location = new System.Drawing.Point(573, 278);
            this.cbTenNhanVien.Name = "cbTenNhanVien";
            this.cbTenNhanVien.Size = new System.Drawing.Size(245, 24);
            this.cbTenNhanVien.TabIndex = 19;
            this.cbTenNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbTenNhanVien_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.cbTenNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dienthoai);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grid_nhanvien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMónĂnToolStripMenuItem;
        private System.Windows.Forms.DataGridView grid_nhanvien;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTenNhanVien;
    }
}

