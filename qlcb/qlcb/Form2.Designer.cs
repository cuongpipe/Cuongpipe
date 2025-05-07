namespace qlcb
{
    partial class Form2
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
            this.danhMụcCácĐơnVịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcCácNgạchCôngTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid_cb = new System.Windows.Forms.DataGridView();
            this.combo_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thôngTinLươngCánBộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcCácĐơnVịToolStripMenuItem,
            this.danhMụcCácNgạchCôngTácToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.thôngTinLươngCánBộToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcCácĐơnVịToolStripMenuItem
            // 
            this.danhMụcCácĐơnVịToolStripMenuItem.Name = "danhMụcCácĐơnVịToolStripMenuItem";
            this.danhMụcCácĐơnVịToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.danhMụcCácĐơnVịToolStripMenuItem.Text = "Danh mục các đơn vị";
            // 
            // danhMụcCácNgạchCôngTácToolStripMenuItem
            // 
            this.danhMụcCácNgạchCôngTácToolStripMenuItem.Name = "danhMụcCácNgạchCôngTácToolStripMenuItem";
            this.danhMụcCácNgạchCôngTácToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.danhMụcCácNgạchCôngTácToolStripMenuItem.Text = "Danh mục các ngạch công tác";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // grid_cb
            // 
            this.grid_cb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cb.Location = new System.Drawing.Point(30, 64);
            this.grid_cb.Name = "grid_cb";
            this.grid_cb.Size = new System.Drawing.Size(444, 337);
            this.grid_cb.TabIndex = 1;
            // 
            // combo_cb
            // 
            this.combo_cb.FormattingEnabled = true;
            this.combo_cb.Location = new System.Drawing.Point(560, 80);
            this.combo_cb.Name = "combo_cb";
            this.combo_cb.Size = new System.Drawing.Size(204, 21);
            this.combo_cb.TabIndex = 2;
            this.combo_cb.SelectedIndexChanged += new System.EventHandler(this.combo_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "lọc";
            // 
            // thôngTinLươngCánBộToolStripMenuItem
            // 
            this.thôngTinLươngCánBộToolStripMenuItem.Name = "thôngTinLươngCánBộToolStripMenuItem";
            this.thôngTinLươngCánBộToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.thôngTinLươngCánBộToolStripMenuItem.Text = "Thông tin lương cán bộ";
            this.thôngTinLươngCánBộToolStripMenuItem.Click += new System.EventHandler(this.thôngTinLươngCánBộToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_cb);
            this.Controls.Add(this.grid_cb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcCácĐơnVịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcCácNgạchCôngTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.DataGridView grid_cb;
        private System.Windows.Forms.ComboBox combo_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinLươngCánBộToolStripMenuItem;
    }
}