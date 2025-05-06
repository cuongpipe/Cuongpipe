using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace QLTNV_quán_ăn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTk.Text) || string.IsNullOrEmpty(txtMk.Text))
            {
                MessageBox.Show("có bt nhập ko tg ngu ?");
                return;
            }
            string stringconnect = "Server = CUONG-LE;Database=QLNV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(stringconnect);
            SqlDataReader reader = null;
            bool ktra = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Account", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["User1"].ToString() == txtTk.Text && reader["Password1"].ToString() == txtMk.Text)
                    {
                        ktra = true;
                        break;
                       
                    }
                }
                if(ktra)
                {
                    this.Hide();
                    frmHome frm = new frmHome();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không chính xác");
                }
            }
            catch {
                MessageBox.Show("Lỗi kết nối database");
            }
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Show")
            {
                button1.Text = "Hide";
                txtMk.PasswordChar = '\0';
            }
            else
            {
                txtMk.PasswordChar = '*';
                button1.Text = "Show";
            }
        }
    }
}
