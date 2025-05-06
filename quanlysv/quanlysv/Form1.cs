using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*'; // ẩn ký tự
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                string user = txt_user.Text;
            string pass = txt_pass.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("mẹ mày nhập vô cu");

            }
            else
            {
                if (user == "admin" && pass == "11")
                {
                    MessageBox.Show("đúng rồi cu");
                        Form2 form2 = new Form2(); // Tạo đối tượng của Form2
                        form2.Show(); // Mở form mới
                        // Nếu muốn đóng form hiện tại sau khi mở form mới:
                        this.Hide(); // Ẩn form hiện tại (Form1), nếu muốn giữ lại form trước đó có thể không cần dòng này
                    }

                else
                {
                    MessageBox.Show("cút");
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("có cái lỗi gì đó rồi cu: " + ex.Message);
            }
        }
    }
}
