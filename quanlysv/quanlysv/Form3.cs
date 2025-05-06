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

namespace quanlysv
{
    public partial class Form3 : Form
    {
        // Đặt chuỗi kết nối đến cơ sở dữ liệu SQL
        string connectionString = "Data Source=xr;Initial Catalog=qlsv;Integrated Security=True;";

        public Form3()
        {
            InitializeComponent();  // Khởi tạo các thành phần trên giao diện của Form
            LoadTenKhoa();  // Gọi hàm LoadTenKhoa để tải danh sách các khoa vào comboBox
        }

        // Hàm này dùng để tải danh sách các khoa vào comboBox
        private void LoadTenKhoa()
        {
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string query = "SELECT TenKhoa FROM Khoa";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        comboBoxTenKhoa.Items.Add(reader["TenKhoa"].ToString());
            //    }
            //}




            comboBoxTenKhoa.Items.Add("Tất cả"); // Thêm mục "Tất cả" vào đầu danh sách khoa, để người dùng có thể chọn xem tất cả các khoa.

            // Kết nối đến cơ sở dữ liệu để lấy tên các khoa
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();  // Mở kết nối đến cơ sở dữ liệu
                grid_diem.RowHeadersVisible = false;
                // SQL query để lấy danh sách tên khoa
                string query = "SELECT TenKhoa FROM Khoa";

                // Tạo câu lệnh SQL
                SqlCommand cmd = new SqlCommand(query, conn);

                // Thực thi câu lệnh và đọc kết quả trả về
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // Duyệt qua các dòng kết quả
                {
                    // Thêm tên khoa vào comboBox
                    comboBoxTenKhoa.Items.Add(reader["TenKhoa"].ToString());
                }
            }

            // Chọn mục mặc định "Tất cả" trong comboBox
            comboBoxTenKhoa.SelectedIndex = 0;
        }

        // Hàm này được gọi khi người dùng thay đổi lựa chọn trong comboBox (chọn khoa)
        private void comboBoxTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedTenKhoa = comboBoxTenKhoa.SelectedItem?.ToString();
            //if (string.IsNullOrEmpty(selectedTenKhoa))
            //{
            //    MessageBox.Show("Vui lòng chọn Khoa.");
            //    return;
            //}

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string query = "SELECT sv.MaSo, sv.HoTen, k.TenKhoa, mh.TenMH, mh.SoTiet, d.Diem " +
            //                   "FROM SinhVien sv " +
            //                   "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
            //                   "JOIN Diem d ON sv.MaSo = d.MaSo " +
            //                   "JOIN MonHoc mh ON d.MaMH = mh.MaMH " +
            //                   "WHERE k.TenKhoa = @TenKhoa";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@TenKhoa", selectedTenKhoa);
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    grid_diem.DataSource = dt;
            //}



            // Lấy tên khoa người dùng chọn
            string selectedTenKhoa = comboBoxTenKhoa.SelectedItem?.ToString();

            // Kết nối đến cơ sở dữ liệu để lọc điểm theo khoa đã chọn
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();  // Mở kết nối đến cơ sở dữ liệu
                string query;

                // Kiểm tra nếu người dùng chọn "Tất cả" thì lấy thông tin tất cả các khoa
                if (selectedTenKhoa == "Tất cả")
                {
                    // Lấy dữ liệu của tất cả sinh viên, bao gồm các thông tin về điểm và môn học
                    query = "SELECT sv.MaSo, sv.HoTen, k.TenKhoa, mh.TenMH, mh.SoTiet, d.Diem " +
                            "FROM SinhVien sv " +
                            "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                            "JOIN Diem d ON sv.MaSo = d.MaSo " +
                            "JOIN MonHoc mh ON d.MaMH = mh.MaMH";
                }
                else
                {
                    // Nếu người dùng chọn một khoa cụ thể, lọc kết quả theo tên khoa đó
                    query = "SELECT sv.MaSo, sv.HoTen, k.TenKhoa, mh.TenMH, mh.SoTiet, d.Diem " +
                            "FROM SinhVien sv " +
                            "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                            "JOIN Diem d ON sv.MaSo = d.MaSo " +
                            "JOIN MonHoc mh ON d.MaMH = mh.MaMH " +
                            "WHERE k.TenKhoa = @TenKhoa";  // Thêm điều kiện lọc theo khoa
                }

                // Tạo câu lệnh SQL
                SqlCommand cmd = new SqlCommand(query, conn);

                // Nếu khoa không phải "Tất cả", thêm tham số vào câu lệnh SQL
                if (selectedTenKhoa != "Tất cả")
                {
                    cmd.Parameters.AddWithValue("@TenKhoa", selectedTenKhoa);
                }

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();  // Tạo một DataTable để chứa dữ liệu
                adapter.Fill(dt);  // Điền dữ liệu từ câu lệnh SQL vào DataTable

                // Đặt dữ liệu vào grid_diem (một bảng dữ liệu hiển thị trên giao diện)
                grid_diem.DataSource = dt;
            }
        }

        // Hàm này được gọi khi người dùng nhấn nút "Refresh"
        private void btn_re_Click(object sender, EventArgs e)
        {
            // Kết nối lại tới cơ sở dữ liệu để lấy lại tất cả dữ liệu không có lọc
            string connectionString = "Data Source=xr;Initial Catalog=qlsv;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT sv.MaSo, sv.HoTen, k.TenKhoa, mh.TenMH, mh.SoTiet, d.Diem " +
                           "FROM SinhVien sv " +
                           "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                           "JOIN Diem d ON sv.MaSo = d.MaSo " +
                           "JOIN MonHoc mh ON d.MaMH = mh.MaMH ";

            // Tạo câu lệnh SQL
            SqlCommand cmd = new SqlCommand(query, conn);

            // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();  // Tạo một DataTable để chứa dữ liệu
            adapter.Fill(dt);  // Điền dữ liệu từ câu lệnh SQL vào DataTable

            // Đặt dữ liệu vào grid_diem (một bảng dữ liệu hiển thị trên giao diện)
            grid_diem.DataSource = dt;
        }
    }
}
