using System;
using System.Globalization;
using System.Windows.Forms;

namespace Quanlyquanbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chỉ tạo cột nếu chưa có (tránh tạo trùng khi thiết kế lại)
            if (dgvDoUong.Columns.Count == 0)
            {
                dgvDoUong.Columns.Add("TenDoUong", "Tên đồ uống");
                dgvDoUong.Columns.Add("LoaiDoUong", "Loại đồ uống");
                dgvDoUong.Columns.Add("DonGia", "Đơn giá (VNĐ)");
            }

            if (dgvNhanVien.Columns.Count == 0)
            {
                dgvNhanVien.Columns.Add("TenNV", "Tên nhân viên");
                dgvNhanVien.Columns.Add("ChucVu", "Chức vụ");
                dgvNhanVien.Columns.Add("Luong", "Lương (VNĐ)");
            }

            if (dgvKhach.Columns.Count == 0)
            {
                dgvKhach.Columns.Add("TenKH", "Tên khách hàng");
                dgvKhach.Columns.Add("SDT", "Số điện thoại");
                dgvKhach.Columns.Add("GhiChu", "Ghi chú");
            }

            // Dữ liệu mẫu
            dgvDoUong.Rows.Add("Bia Heineken", "Bia", 30000);
            dgvDoUong.Rows.Add("Coca Cola", "Nước ngọt", 15000);
            dgvNhanVien.Rows.Add("Nguyễn Văn A", "Phục vụ", 7000000);
            dgvNhanVien.Rows.Add("Trần Thị B", "Thu ngân", 8000000);
            dgvKhach.Rows.Add("Lê Minh C", "0909123456", "Khách quen");

            // Một số cấu hình hiển thị (tùy chọn)
            dgvDoUong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ==== ĐỒ UỐNG ====
        private void btnThemDU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDU.Text) ||
                string.IsNullOrWhiteSpace(cboLoaiDU.Text) ||
                string.IsNullOrWhiteSpace(txtGiaDU.Text))
            {
                MessageBox.Show("Vui lòng nhập tên, loại và giá đồ uống.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGiaDU.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal gia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvDoUong.Rows.Add(txtTenDU.Text.Trim(), cboLoaiDU.Text.Trim(), gia);
            ClearDoUongInputs();
        }

        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            if (dgvDoUong.CurrentRow != null)
            {
                dgvDoUong.Rows.RemoveAt(dgvDoUong.CurrentRow.Index);
            }
            else MessageBox.Show("Vui lòng chọn 1 dòng để xóa.");
        }

        private void btnSuaDU_Click(object sender, EventArgs e)
        {
            if (dgvDoUong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa.");
                return;
            }

            if (!decimal.TryParse(txtGiaDU.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal gia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvDoUong.CurrentRow.Cells[0].Value = txtTenDU.Text.Trim();
            dgvDoUong.CurrentRow.Cells[1].Value = cboLoaiDU.Text.Trim();
            dgvDoUong.CurrentRow.Cells[2].Value = gia;
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

        // ==== NHÂN VIÊN ====
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtChucVu.Text) ||
                string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.");
                return;
            }

            if (!decimal.TryParse(txtLuong.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal luong))
            {
                MessageBox.Show("Lương phải là số hợp lệ.");
                return;
            }

            dgvNhanVien.Rows.Add(txtTenNV.Text.Trim(), txtChucVu.Text.Trim(), luong);
            txtTenNV.Clear(); txtChucVu.Clear(); txtLuong.Clear();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null) dgvNhanVien.Rows.RemoveAt(dgvNhanVien.CurrentRow.Index);
            else MessageBox.Show("Vui lòng chọn dòng cần xóa.");
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) { MessageBox.Show("Vui lòng chọn dòng để sửa."); return; }
            if (!decimal.TryParse(txtLuong.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal luong)) { MessageBox.Show("Lương phải là số."); return; }

            dgvNhanVien.CurrentRow.Cells[0].Value = txtTenNV.Text.Trim();
            dgvNhanVien.CurrentRow.Cells[1].Value = txtChucVu.Text.Trim();
            dgvNhanVien.CurrentRow.Cells[2].Value = luong;
            txtTenNV.Clear(); txtChucVu.Clear(); txtLuong.Clear();
        }

        // ==== KHÁCH HÀNG ====
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại khách hàng.");
                return;
            }

            dgvKhach.Rows.Add(txtTenKH.Text.Trim(), txtSDT.Text.Trim(), txtGhiChu.Text.Trim());
            txtTenKH.Clear(); txtSDT.Clear(); txtGhiChu.Clear();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvKhach.CurrentRow != null) dgvKhach.Rows.RemoveAt(dgvKhach.CurrentRow.Index);
            else MessageBox.Show("Vui lòng chọn dòng cần xóa.");
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (dgvKhach.CurrentRow == null) { MessageBox.Show("Vui lòng chọn dòng để sửa."); return; }

            dgvKhach.CurrentRow.Cells[0].Value = txtTenKH.Text.Trim();
            dgvKhach.CurrentRow.Cells[1].Value = txtSDT.Text.Trim();
            dgvKhach.CurrentRow.Cells[2].Value = txtGhiChu.Text.Trim();
            txtTenKH.Clear(); txtSDT.Clear(); txtGhiChu.Clear();
        }
    }
}
