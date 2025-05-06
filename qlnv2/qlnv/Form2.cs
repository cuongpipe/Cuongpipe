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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace qlnv
{
    public partial class Form2 : Form
    {
 
        public Form2()

        {
            InitializeComponent();
           

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = xr; Initial Catalog = qlnv; Integrated Security = True;");
            SqlDataReader rdr = null;
            bool OK = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from account", conn);
                rdr = cmd.ExecuteReader();
            
               while (rdr.Read())
                {
                    if ((txt_user.Text.Trim() == rdr["usser"].ToString().Trim()))
                    {

                        if (txt_pass.Text.Trim() == rdr["pass"].ToString().Trim()) OK = true;

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
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else MessageBox.Show("Tên đăng nhập/Mật khẩu không hợp lệ!");

               



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
