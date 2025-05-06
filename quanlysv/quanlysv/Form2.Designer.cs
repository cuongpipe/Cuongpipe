namespace quanlysv
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
            this.danhMụcCácKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid_sv = new System.Windows.Forms.DataGridView();
            this.comboBoxMaSo = new System.Windows.Forms.ComboBox();
            this.btn_re = new System.Windows.Forms.Button();
            this.traĐiểmTheoKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcCácKhoaToolStripMenuItem,
            this.danhToolStripMenuItem,
            this.traĐiểmTheoKhoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcCácKhoaToolStripMenuItem
            // 
            this.danhMụcCácKhoaToolStripMenuItem.Name = "danhMụcCácKhoaToolStripMenuItem";
            this.danhMụcCácKhoaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.danhMụcCácKhoaToolStripMenuItem.Text = "Danh mục các khoa";
            // 
            // danhToolStripMenuItem
            // 
            this.danhToolStripMenuItem.Name = "danhToolStripMenuItem";
            this.danhToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.danhToolStripMenuItem.Text = "danh mục các môn";
            // 
            // grid_sv
            // 
            this.grid_sv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sv.Location = new System.Drawing.Point(31, 71);
            this.grid_sv.Name = "grid_sv";
            this.grid_sv.RowHeadersWidth = 51;
            this.grid_sv.RowTemplate.Height = 24;
            this.grid_sv.Size = new System.Drawing.Size(587, 271);
            this.grid_sv.TabIndex = 1;
            // 
            // comboBoxMaSo
            // 
            this.comboBoxMaSo.FormattingEnabled = true;
            this.comboBoxMaSo.Location = new System.Drawing.Point(649, 71);
            this.comboBoxMaSo.Name = "comboBoxMaSo";
            this.comboBoxMaSo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaSo.TabIndex = 2;
            this.comboBoxMaSo.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaSo_SelectedIndexChanged_1);
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(649, 138);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(86, 24);
            this.btn_re.TabIndex = 3;
            this.btn_re.Text = "refesh";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.btn_re_Click);
            // 
            // traĐiểmTheoKhoaToolStripMenuItem
            // 
            this.traĐiểmTheoKhoaToolStripMenuItem.Name = "traĐiểmTheoKhoaToolStripMenuItem";
            this.traĐiểmTheoKhoaToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.traĐiểmTheoKhoaToolStripMenuItem.Text = "Tra điểm theo khoa";
            this.traĐiểmTheoKhoaToolStripMenuItem.Click += new System.EventHandler(this.traĐiểmTheoKhoaToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.btn_re);
            this.Controls.Add(this.comboBoxMaSo);
            this.Controls.Add(this.grid_sv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcCácKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhToolStripMenuItem;
        private System.Windows.Forms.DataGridView grid_sv;
        private System.Windows.Forms.ComboBox comboBoxMaSo;
        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.ToolStripMenuItem traĐiểmTheoKhoaToolStripMenuItem;
    }
}