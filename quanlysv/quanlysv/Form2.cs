using System; // Thư viện chứa các lớp cơ bản của .NET (kiểu dữ liệu, ngoại lệ, ...).
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Hỗ trợ thao tác dữ liệu (DataTable, DataSet,...).
using System.Data.SqlClient; // Thư viện để làm việc với SQL Server.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Thư viện cho giao diện WinForms.

namespace quanlysv // Tên namespace của chương trình, có thể hiểu là "tên nhóm" của các class.
{
    public partial class Form2 : Form // Khai báo Form2 kế thừa từ lớp Form (giao diện cửa sổ).
    {
        public Form2()
        {
            InitializeComponent(); // Tạo và thiết lập giao diện từ file .Designer.cs
            LoadSinhVienData(); // Gọi hàm để hiển thị danh sách sinh viên ban đầu.
            LoadComboBoxMaSo(); // Gọi hàm để đổ dữ liệu mã số vào ComboBox.
        }

        // Hàm tải dữ liệu sinh viên lên DataGridView (lưới hiển thị)
        public void LoadSinhVienData()
        {
            //Sai do ngu
            //string query1 = "SELECT sv.MaSo, sv.HoTen,  sv.NgaySinh, sv.GioiTinh,  sv.DiaChi, sv.DienThoai, k.TenKhoa, mh.TenMH, mh.SoTiet" +
            //                  "FROM SinhVien sv" +
            //                            " JOIN Khoa k ON sv.MaKhoa = k.MaKhoa" +
            //                          " JOIN Diem d ON sv.MaSo = d.MaSo" +
            //                                  "JOIN MonHoc mh ON d.MaMH = mh.MaMH";



            // Chuỗi kết nối đến SQL Server, database là "qlsv"
            string connectionString = "Data Source=xr;Initial Catalog=qlsv;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString)) // Tạo đối tượng kết nối
            {
                conn.Open(); // Mở kết nối tới cơ sở dữ liệu

                // Câu truy vấn lấy thông tin sinh viên, khoa, môn học
                string query = "SELECT sv.MaSo, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.DiaChi, sv.DienThoai, " +
                               "k.TenKhoa, mh.TenMH, mh.SoTiet " +
                               "FROM SinhVien sv " +
                               "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                               "JOIN Diem d ON sv.MaSo = d.MaSo " +
                               "JOIN MonHoc mh ON d.MaMH = mh.MaMH";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn); // Lấy dữ liệu từ DB
                grid_sv.RowHeadersVisible = false; // Ẩn cột đánh số đầu dòng
                DataTable dt = new DataTable(); // Tạo bảng dữ liệu
                adapter.Fill(dt); // Đổ dữ liệu từ adapter vào DataTable
                grid_sv.DataSource = dt; // Hiển thị dữ liệu lên lưới
            }
        }

        // Sự kiện khi người dùng chọn giá trị trong ComboBox
        private void comboBoxMaSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedMaSo = comboBoxMaSo.SelectedItem.ToString(); // Lấy mã số được chọn
            string connectionString = "Data Source=xr;Initial Catalog=qlsv;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối
                string query;

                // Nếu chọn "Tất cả" thì truy vấn tất cả sinh viên
                if (selectedMaSo == "Tất cả")
                {
                    query = "SELECT sv.MaSo, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.DiaChi, sv.DienThoai, " +
                            "k.TenKhoa, mh.TenMH, mh.SoTiet " +
                            "FROM SinhVien sv " +
                            "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                            "JOIN Diem d ON sv.MaSo = d.MaSo " +
                            "JOIN MonHoc mh ON d.MaMH = mh.MaMH";
                }
                else // Nếu chọn mã số cụ thể
                {
                    query = "SELECT sv.MaSo, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.DiaChi, sv.DienThoai, " +
                            "k.TenKhoa, mh.TenMH, mh.SoTiet " +
                            "FROM SinhVien sv " +
                            "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                            "JOIN Diem d ON sv.MaSo = d.MaSo " +
                            "JOIN MonHoc mh ON d.MaMH = mh.MaMH " +
                            "WHERE sv.MaSo = @MaSo"; // Có điều kiện lọc theo mã số
                }

                SqlCommand cmd = new SqlCommand(query, conn); // Tạo lệnh SQL

                if (selectedMaSo != "Tất cả") // Nếu có chọn cụ thể thì truyền tham số
                    cmd.Parameters.AddWithValue("@MaSo", selectedMaSo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Adapter để đổ dữ liệu
                DataTable dt = new DataTable(); // Bảng dữ liệu
                adapter.Fill(dt); // Đổ dữ liệu
                grid_sv.DataSource = dt; // Hiển thị lên lưới
            }
        }

        // Hàm đổ dữ liệu mã số sinh viên vào ComboBox
        private void LoadComboBoxMaSo()
        {
            string connectionString = "Data Source=xr;Initial Catalog=qlsv;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                comboBoxMaSo.Items.Clear(); // Xóa các mục cũ
                comboBoxMaSo.Items.Add("Tất cả"); // Thêm lựa chọn đầu tiên

                conn.Open(); // Mở kết nối
                string query = "SELECT MaSo FROM SinhVien"; // Truy vấn lấy mã số
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader(); // Đọc từng dòng kết quả

                while (reader.Read())
                {
                    comboBoxMaSo.Items.Add(reader["MaSo"].ToString()); // Thêm vào ComboBox
                }
            }
            comboBoxMaSo.SelectedIndex = 0; // Chọn "Tất cả" mặc định
        }

        // Sự kiện khi bấm nút "Refresh" để tải lại toàn bộ dữ liệu
        private void btn_re_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=xr;Initial Catalog=qlsv;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "SELECT sv.MaSo, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.DiaChi, sv.DienThoai, " +
                            "k.TenKhoa, mh.TenMH, mh.SoTiet " +
                            "FROM SinhVien sv " +
                            "JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                            "JOIN Diem d ON sv.MaSo = d.MaSo " +
                            "JOIN MonHoc mh ON d.MaMH = mh.MaMH";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grid_sv.DataSource = dt;
        }

        // Sự kiện mở form Form3 khi chọn menu "Tra điểm theo khoa"
        private void traĐiểmTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form3 form = new Form3 ();
            //form.Show();
            Form3 form = new Form3(); // Tạo form mới
            form.ShowDialog(); // Hiển thị dưới dạng hộp thoại (chặn form chính)
        }
    }
}
