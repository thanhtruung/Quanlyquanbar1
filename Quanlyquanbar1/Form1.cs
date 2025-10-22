using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Quanlyquanbar1
{
    public partial class Form1 : Form
    {
        private readonly string connectionString;

        public Form1()
        {
            InitializeComponent();

            // Gán trực tiếp chuỗi kết nối thay vì đọc từ App.config
            connectionString = "Data Source=DESKTOP-BVCNC89;Initial Catalog=QuanLyQuanBar;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";


            // Kiểm tra kết nối luôn
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("✅ Kết nối thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Kết nối thất bại: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDoUong();
                LoadNhanVien();
                LoadKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // ========================= LOAD DATA =========================
        private void LoadDoUong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, TenDoUong, LoaiDoUong, DonGia FROM DoUong";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoUong.DataSource = dt;
                if (dgvDoUong.Columns["ID"] != null) dgvDoUong.Columns["ID"].Visible = false;
                dgvDoUong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, TenNV, ChucVu, Luong FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhanVien.DataSource = dt;
                if (dgvNhanVien.Columns["ID"] != null) dgvNhanVien.Columns["ID"].Visible = false;
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, TenKH, SDT, GhiChu FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhach.DataSource = dt;
                if (dgvKhach.Columns["ID"] != null) dgvKhach.Columns["ID"].Visible = false;
                dgvKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // ========================= ĐỒ UỐNG =========================
        private void btnThemDU_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGiaDU.Text, out decimal gia) || string.IsNullOrWhiteSpace(txtTenDU.Text) || string.IsNullOrWhiteSpace(cboLoaiDU.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập đúng thông tin đồ uống.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DoUong (TenDoUong, LoaiDoUong, DonGia) VALUES (@Ten, @Loai, @Gia)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", txtTenDU.Text.Trim());
                    cmd.Parameters.AddWithValue("@Loai", cboLoaiDU.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadDoUong();
            ClearDoUongInputs();
        }

        private void btnSuaDU_Click(object sender, EventArgs e)
        {
            if (dgvDoUong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đồ uống cần sửa.");
                return;
            }

            int id = Convert.ToInt32(dgvDoUong.CurrentRow.Cells["ID"].Value);
            if (!decimal.TryParse(txtGiaDU.Text, out decimal gia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DoUong SET TenDoUong=@Ten, LoaiDoUong=@Loai, DonGia=@Gia WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", txtTenDU.Text.Trim());
                    cmd.Parameters.AddWithValue("@Loai", cboLoaiDU.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadDoUong();
            ClearDoUongInputs();
        }

        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            if (dgvDoUong.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvDoUong.CurrentRow.Cells["ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DoUong WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadDoUong();
            ClearDoUongInputs();
        }

        private void btnLamMoiDU_Click(object sender, EventArgs e)
        {
            ClearDoUongInputs();
        }

        private void ClearDoUongInputs()
        {
            txtTenDU.Clear();
            txtGiaDU.Clear();
            cboLoaiDU.SelectedIndex = -1;
        }

        // ========================= NHÂN VIÊN =========================
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtLuong.Text, out decimal luong) || string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtChucVu.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập đúng thông tin nhân viên.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NhanVien (TenNV, ChucVu, Luong) VALUES (@Ten, @ChucVu, @Luong)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text.Trim());
                    cmd.Parameters.AddWithValue("@Luong", luong);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadNhanVien();
            ClearNhanVienInputs();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value);
            if (!decimal.TryParse(txtLuong.Text, out decimal luong))
            {
                MessageBox.Show("Lương phải là số hợp lệ.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE NhanVien SET TenNV=@Ten, ChucVu=@ChucVu, Luong=@Luong WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text.Trim());
                    cmd.Parameters.AddWithValue("@Luong", luong);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadNhanVien();
            ClearNhanVienInputs();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM NhanVien WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadNhanVien();
            ClearNhanVienInputs();
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            ClearNhanVienInputs();
        }

        private void ClearNhanVienInputs()
        {
            txtTenNV.Clear();
            txtChucVu.Clear();
            txtLuong.Clear();
        }

        // ========================= KHÁCH HÀNG =========================
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên và số điện thoại khách hàng.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO KhachHang (TenKH, SDT, GhiChu) VALUES (@Ten, @SDT, @GhiChu)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", txtTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }

            LoadKhachHang();
            ClearKhachInputs();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (dgvKhach.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvKhach.CurrentRow.Cells["ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE KhachHang SET TenKH=@Ten, SDT=@SDT, GhiChu=@GhiChu WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", txtTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadKhachHang();
            ClearKhachInputs();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvKhach.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvKhach.CurrentRow.Cells["ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM KhachHang WHERE ID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadKhachHang();
            ClearKhachInputs();
        }

        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            ClearKhachInputs();
        }

        private void ClearKhachInputs()
        {
            txtTenKH.Clear();
            txtSDT.Clear();
            txtGhiChu.Clear();
        }

        // ========================= TEST CONNECTION =========================
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("✅ Kết nối SQL Server thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Kết nối thất bại: " + ex.Message);
            }
        }
    }
}
