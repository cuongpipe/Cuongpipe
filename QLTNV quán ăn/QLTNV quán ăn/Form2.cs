using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTNV_quán_ăn
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private void loadDatabase()
        {
            string stringconnect = "Server=CUONG-LE;Database=QLNV;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(stringconnect))
            {
                string query = "select * from NhanVien";
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sqlDataAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Lỗi database");
                }

            }

        }
        private void loadcombo()
        {
            string stringconnect = "Server=CUONG-LE;Database=QLNV;Integrated Security=True;";
            string query = "select MaNV from NhanVien";
            SqlConnection conn = new SqlConnection(stringconnect);
            SqlDataReader reader = null;
            try {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["MaNV"].ToString()); ;
                }
                conn.Close();
            }
            catch {
                MessageBox.Show("loi datata roi");
            }
          
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            loadDatabase();
            loadcombo();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMasv.Text) || string.IsNullOrEmpty(txtTen.Text) ||
            string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(txtDiaChi.Text) ||
            string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Nhập đi đủ cho bố coi nàooooooooooo");
                return;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtMasv.Text)
                {
                    MessageBox.Show("Tên mã sinh viên trùng rồi không thể thêm nghe chưa");
                    return;
                }
            }

            string connectionString = "Server=CUONG-LE;Database=QLNV;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO NhanVien  VALUES (@masv, @ten, @ngaysinh, @diachi, @sdt);";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@masv", txtMasv.Text);
                        cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi database: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMasv.Text) || string.IsNullOrEmpty(txtTen.Text) ||
            string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(txtDiaChi.Text) ||
            string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Nhập đi đủ cho bố coi nàooooooooooo");
                return;
            }
            string connectionString = "Server=CUONG-LE;Database=QLNV;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "Update NhanVien set HoTen = @ten,NgaySinh = @ngaysinh," +
                    "DiaChi = @diaChi, DienThoai = @sdt where MaNV = @masv";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@masv", txtMasv.Text);
                        cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sửa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi database: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMasv.Text) || string.IsNullOrEmpty(txtTen.Text) ||
            string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(txtDiaChi.Text) ||
            string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Chọn hàng đi dm mày");
                return;
            }
            string connectionString = "Server=CUONG-LE;Database=QLNV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "delete from NhanVien Where MaNV = @manv";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@manv", txtMasv.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi data");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtMasv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string strconenct = "Server=CUONG-LE;Database=QLNV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconenct);
            string query = "Select * from NhanVien Where MaNV = @manv";
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@manv", comboBox1.Text);
                reader= cmd.ExecuteReader();
                if (reader.Read()) {
                    txtMasv.Text = reader["MaNV"].ToString();
                    txtTen.Text = reader["HoTen"].ToString();
                    dateTimePicker1.Text = reader["NgaySinh"].ToString();
                    txtDiaChi.Text = reader["DiaChi"].ToString();
                    txtSdt.Text = reader["DienThoai"].ToString();
                }

                
                conn.Close();
            }
            catch
            {
                MessageBox.Show("loiiiiiiiiiiii");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
