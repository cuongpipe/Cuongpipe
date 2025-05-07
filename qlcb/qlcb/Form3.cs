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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadcbData();
        }
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ESUFOTK;Initial Catalog=qlcb;Integrated Security=True");
        //string query = "SELECT MaSo, HoTen,LuongCuaCanBo =( HeSoLuong *25000) from CanBo";
        //try
        //    {
        // conn.Open();
        // SqlCommand cmd = new SqlCommand(query, conn);
        //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //DataTable dt = new DataTable();
        //adapter.Fill(dt);
        //    dataGridView3.DataSource = dt;
        //}
        //catch
        //    {
        //  MessageBox.Show("Lỗi kết nối database");
        //    }

          public void LoadcbData()
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ESUFOTK;Initial Catalog=qlcb;Integrated Security=True");
            string query = "SELECT MaSo, HoTen,LuongCuaCanBo =( HeSoLuong *25000) from CanBo";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grid_luong.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối database");
            }


        }

    }
}
