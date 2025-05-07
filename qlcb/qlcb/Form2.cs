using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlcb
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadcbData();
        }



         public void LoadcbData()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ESUFOTK;Initial Catalog=qlcb;Integrated Security=True")) // Tạo đối tượng kết nối
            {
                conn.Open(); // Mở kết nối tới cơ sở dữ liệu

                // Câu truy vấn lấy thông tin sinh viên, khoa, môn học

                string query = @"

select cb.maso, cb.hoten, cb.ngaysinh, cb.gioitinh, dv.tendonvi,ntc.tenngach, cb.hesoluong 
from canbo cb
inner JOIN donvi dv ON cb.MaDonVi= dv.MaDonVi
inner JOIN NgachCongTac ntc ON cb.MaNgach = ntc.MaNgach;
";




                SqlDataAdapter adapter = new SqlDataAdapter(query, conn); // Lấy dữ liệu từ DB
                grid_cb.RowHeadersVisible = false; // Ẩn cột đánh số đầu dòng
                DataTable dt = new DataTable(); // Tạo bảng dữ liệu
                adapter.Fill(dt);
                grid_cb.DataSource = dt; // Hiển thị dữ liệu lên lưới
                LoadComboBoxMaSo();
            }
        }

        private void combo_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaSo = combo_cb.SelectedItem.ToString(); // Lấy mã số được chọn
            string connectionString = "Data Source=DESKTOP-ESUFOTK;Initial Catalog=qlcb;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối
                string query;

                // Nếu chọn "Tất cả" thì truy vấn tất cả sinh viên
                if (selectedMaSo == "Tất cả")
                {
                    query = @"

select cb.maso, cb.hoten, cb.ngaysinh, cb.gioitinh, dv.tendonvi,ntc.tenngach, cb.hesoluong 
from canbo cb
inner JOIN donvi dv ON cb.MaDonVi= dv.MaDonVi
inner JOIN NgachCongTac ntc ON cb.MaNgach = ntc.MaNgach;
";
                }
                else // Nếu chọn mã số cụ thể
                {

                    query = @"

select cb.maso, cb.hoten, cb.ngaysinh, cb.gioitinh, dv.tendonvi,ntc.tenngach, cb.hesoluong 
from canbo cb
inner JOIN donvi dv ON cb.MaDonVi= dv.MaDonVi
inner JOIN NgachCongTac ntc ON cb.MaNgach = ntc.MaNgach WHERE cb.MaSo = @MaSo;
";
                }

                SqlCommand cmd = new SqlCommand(query, conn); // Tạo lệnh SQL

                if (selectedMaSo != "Tất cả") // Nếu có chọn cụ thể thì truyền tham số
                    cmd.Parameters.AddWithValue("@MaSo", selectedMaSo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Adapter để đổ dữ liệu
                DataTable dt = new DataTable(); // Bảng dữ liệu
                adapter.Fill(dt); // Đổ dữ liệu
                grid_cb.DataSource = dt; // Hiển thị lên lưới
            }
        }


        private void LoadComboBoxMaSo()
        {
            string connectionString = "Data Source=DESKTOP-ESUFOTK;Initial Catalog=qlcb;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                combo_cb.Items.Clear(); // Xóa các mục cũ
                combo_cb.Items.Add("Tất cả"); // Thêm lựa chọn đầu tiên

                conn.Open(); // Mở kết nối
                string query = "SELECT MaSo FROM Canbo"; // Truy vấn lấy mã số
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader(); // Đọc từng dòng kết quả

                while (reader.Read())
                {
                    combo_cb.Items.Add(reader["MaSo"].ToString()); // Thêm vào ComboBox
                }
            }
            combo_cb.SelectedIndex = 0; // Chọn "Tất cả" mặc định
        }

        private void thôngTinLươngCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(); // Tạo form mới
            form.ShowDialog(); // Hiển thị dưới dạng hộp thoại (chặn form chính)
        }



    }

}
