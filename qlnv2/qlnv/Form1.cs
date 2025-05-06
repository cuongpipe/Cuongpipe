using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlnv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxMaNV();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection("Data Source = xr; Initial Catalog = qlnv; Integrated Security = True;"))
            {
                string sql = "SELECT MaNV, HoTen, DiaChi, FORMAT(NgaySinh, 'dd/MM/yyyy') AS NgaySinh, DienThoai FROM nhanvien";
                SqlDataAdapter gridviu = new SqlDataAdapter(sql, conn);
                gridviu.Fill(dt);
                grid_nhanvien.RowHeadersVisible = false;
                grid_nhanvien.DataSource = dt;
            }


            //// Cập nhật danh sách tên nhân viên vào ComboBox
            //cbTenNhanVien.Items.Clear();
            //cbTenNhanVien.Items.Add("Tất cả");

            //foreach (DataRow row in dt.Rows)
            //{
            //    string hoten = row["HoTen"].ToString();
            //    if (!cbTenNhanVien.Items.Contains(hoten))
            //    {
            //        cbTenNhanVien.Items.Add(hoten);
            //    }
            //}

            //cbTenNhanVien.SelectedIndex = 0;
            LoadComboBoxMaNV();
        }
        private void LoadComboBoxMaNV()
        {
            string connectionString = "Data Source=xr;Initial Catalog=qlnv;Integrated Security=True;";
            string query = "SELECT MaNV FROM nhanvien";

            cbTenNhanVien.Items.Clear();
            cbTenNhanVien.Items.Add("Tất cả");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbTenNhanVien.Items.Add(reader["MaNV"].ToString());
                }
            }

            cbTenNhanVien.SelectedIndex = 0;
        }







        private void thôngTinProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng Quản lý Quán Ăn Nhanh\nSinh viên: Nguyễn Văn A\nLớp: CNTT4",
                    "Thông tin Project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure about that ?",
                                      "Xác nhận thoát",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source = xr; Initial Catalog = qlnv; Integrated Security = True;");
            //conn.Open();
            string manv = txt_manv.Text;
            string hoten = txt_hoten.Text;
            string diachi = txt_diachi.Text;
            //string ngaysinhstr = txt_ngaysinh.Text;
            string dienthoai = txt_dienthoai.Text;
            string dt_ngaysinh = dtp_ngaysinh.Value.ToString("yyyy/MM/dd HH:mm:ss");

            if (string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Mã nhân viên và Họ tên không được để trống!");
                return;
            }

            // KIỂM TRA xem MaNV đã tồn tại chưa

            using (SqlConnection conn = new SqlConnection("Data Source = xr; Initial Catalog = qlnv; Integrated Security = True;"))
            {
                conn.Open();
                string checkSql = "SELECT COUNT(*) FROM nhanvien WHERE MaNV = @MaNV";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@MaNV", manv);

                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại! Vui lòng nhập mã khác.");
                    conn.Close();
                    return;
                }

                string sql = "INSERT into nhanvien values('" + manv +
                "','" + hoten + "','" + diachi + "','" + dt_ngaysinh + "','" + dienthoai + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("đã thêm thành công");
                LoadData();
                //conn.Close();
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_manv.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source = xr; Initial Catalog = qlnv; Integrated Security = True;"))
            {
                string sql = "UPDATE nhanvien SET HoTen = @hoten, DiaChi = @diachi, NgaySinh = @ngaysinh, DienThoai = @dienthoai WHERE MaNV = @manv";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@manv", txt_manv.Text);
                cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dtp_ngaysinh.Value);
                cmd.Parameters.AddWithValue("@dienthoai", txt_dienthoai.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cập nhật nhân viên thành công!");
                LoadData();
            }


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_manv.Text) || string.IsNullOrEmpty(txt_hoten.Text) ||
                string.IsNullOrEmpty(dtp_ngaysinh.Text) || string.IsNullOrEmpty(txt_diachi.Text) ||
                string.IsNullOrEmpty(txt_dienthoai.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin để xóa!");
                return;
            }

            SqlConnection conn = new SqlConnection("Data Source = xr; Initial Catalog = qlnv; Integrated Security = True;");
            string query = "DELETE FROM NhanVien WHERE MaNV = @manv";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@manv", txt_manv.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Xóa thành công");
                LoadData(); // Nếu muốn cập nhật lại lưới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void grid_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid_nhanvien.Rows[e.RowIndex];
            txt_manv.Text = row.Cells["MaNV"].Value.ToString();
            txt_hoten.Text = row.Cells["HoTen"].Value.ToString();
            txt_diachi.Text = row.Cells["DiaChi"].Value.ToString();
            dtp_ngaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            txt_dienthoai.Text = row.Cells["DienThoai"].Value.ToString();
        }

        private void FilterByTenNhanVien(string tenNV)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = xr; Initial Catalog = qlnv; Integrated Security = True;"))
            {
                string sql;

                if (tenNV == "Tất cả")
                {
                    sql = "SELECT MaNV, HoTen, DiaChi, FORMAT(NgaySinh, 'dd/MM/yyyy') AS NgaySinh, DienThoai FROM nhanvien";
                }
                else
                {
                    sql = "SELECT MaNV, HoTen, DiaChi, FORMAT(NgaySinh, 'dd/MM/yyyy') AS NgaySinh, DienThoai FROM nhanvien WHERE HoTen = @HoTen";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (tenNV != "Tất cả")
                    cmd.Parameters.AddWithValue("@HoTen", tenNV);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grid_nhanvien.DataSource = dt;
            }
        }

        private void cbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cbTenNhanVien.SelectedItem.ToString();
            FilterByTenNhanVien(selectedName);
        }
    }
}
