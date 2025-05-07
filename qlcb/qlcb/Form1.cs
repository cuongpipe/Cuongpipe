using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlcb
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*';
        }


        

 

        private void btn_login_Click(object sender, EventArgs e)
        {
           // string connect_string = " ";
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ESUFOTK;Initial Catalog=qlcb;Integrated Security=True");
            SqlDataReader rdr = null;
            bool OK = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TaiKhoan", conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if ((txt_user.Text.Trim() == rdr["tendangnhap"].ToString().Trim()))
                    {

                        if (txt_pass.Text.Trim() == rdr["matkhau"].ToString().Trim()) OK = true;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                return;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            if (OK == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else MessageBox.Show("Tên đăng nhập/Mật khẩu không hợp lệ!");




        }
    }
}
