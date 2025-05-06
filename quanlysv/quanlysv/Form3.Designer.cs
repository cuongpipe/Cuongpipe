namespace quanlysv
{
    partial class Form3
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
            this.btn_re = new System.Windows.Forms.Button();
            this.comboBoxTenKhoa = new System.Windows.Forms.ComboBox();
            this.grid_diem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_diem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(649, 157);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(86, 24);
            this.btn_re.TabIndex = 6;
            this.btn_re.Text = "refesh";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.btn_re_Click);
            // 
            // comboBoxTenKhoa
            // 
            this.comboBoxTenKhoa.FormattingEnabled = true;
            this.comboBoxTenKhoa.Location = new System.Drawing.Point(649, 90);
            this.comboBoxTenKhoa.Name = "comboBoxTenKhoa";
            this.comboBoxTenKhoa.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTenKhoa.TabIndex = 5;
            this.comboBoxTenKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenKhoa_SelectedIndexChanged);
            // 
            // grid_diem
            // 
            this.grid_diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_diem.Location = new System.Drawing.Point(31, 90);
            this.grid_diem.Name = "grid_diem";
            this.grid_diem.RowHeadersWidth = 51;
            this.grid_diem.RowTemplate.Height = 24;
            this.grid_diem.Size = new System.Drawing.Size(587, 271);
            this.grid_diem.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_re);
            this.Controls.Add(this.comboBoxTenKhoa);
            this.Controls.Add(this.grid_diem);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.grid_diem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.ComboBox comboBoxTenKhoa;
        private System.Windows.Forms.DataGridView grid_diem;
    }
}