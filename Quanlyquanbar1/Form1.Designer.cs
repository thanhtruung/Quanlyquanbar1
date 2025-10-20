using System;

namespace Quanlyquanbar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDoUong = new System.Windows.Forms.TabPage();
            this.lblTongDoUong = new System.Windows.Forms.Label();
            this.btnLamMoiDU = new System.Windows.Forms.Button();
            this.btnXoaDU = new System.Windows.Forms.Button();
            this.btnSuaDU = new System.Windows.Forms.Button();
            this.btnThemDU = new System.Windows.Forms.Button();
            this.txtGiaDU = new System.Windows.Forms.TextBox();
            this.cboLoaiDU = new System.Windows.Forms.ComboBox();
            this.txtTenDU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDoUong = new System.Windows.Forms.DataGridView();

            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnLamMoiKH = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();

            // ============ FORM =============
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(250, 10);
            this.lblTieuDe.Text = "QUẢN LÝ QUÁN BAR";

            // tabControl1
            this.tabControl1.Controls.Add(this.tabDoUong);
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Controls.Add(this.tabKhachHang);
            this.tabControl1.Location = new System.Drawing.Point(10, 60);
            this.tabControl1.Size = new System.Drawing.Size(780, 370);

            // ============ TAB ĐỒ UỐNG =============
            this.tabDoUong.Text = "Đồ uống";
            this.tabDoUong.Controls.Add(this.label1);
            this.tabDoUong.Controls.Add(this.label2);
            this.tabDoUong.Controls.Add(this.label3);
            this.tabDoUong.Controls.Add(this.txtTenDU);
            this.tabDoUong.Controls.Add(this.cboLoaiDU);
            this.tabDoUong.Controls.Add(this.txtGiaDU);
            this.tabDoUong.Controls.Add(this.btnThemDU);
            this.tabDoUong.Controls.Add(this.btnSuaDU);
            this.tabDoUong.Controls.Add(this.btnXoaDU);
            this.tabDoUong.Controls.Add(this.btnLamMoiDU);
            this.tabDoUong.Controls.Add(this.dgvDoUong);
            this.tabDoUong.Controls.Add(this.lblTongDoUong);

            // label1 - Tên đồ uống
            this.label1.Text = "Tên đồ uống:";
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.txtTenDU.Location = new System.Drawing.Point(120, 27);

            // label2 - Loại
            this.label2.Text = "Loại đồ uống:";
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.cboLoaiDU.Location = new System.Drawing.Point(120, 67);
            this.cboLoaiDU.Items.AddRange(new object[] { "Bia", "Rượu", "Cocktail", "Nước ngọt" });

            // label3 - Giá
            this.label3.Text = "Giá (VNĐ):";
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.txtGiaDU.Location = new System.Drawing.Point(120, 107);

            // Buttons
            this.btnThemDU.Text = "+ Thêm";
            this.btnThemDU.Location = new System.Drawing.Point(300, 40);
            this.btnSuaDU.Text = "✏️ Sửa";
            this.btnSuaDU.Location = new System.Drawing.Point(400, 40);
            this.btnXoaDU.Text = "🗑 Xóa";
            this.btnXoaDU.Location = new System.Drawing.Point(500, 40);
            this.btnLamMoiDU.Text = "🔄 Làm mới";
            this.btnLamMoiDU.Location = new System.Drawing.Point(600, 40);

            // DataGridView
            this.dgvDoUong.Location = new System.Drawing.Point(10, 160);
            this.dgvDoUong.Size = new System.Drawing.Size(750, 160);
            this.dgvDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Label dưới DataGridView
            this.lblTongDoUong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongDoUong.Text = "Tổng số: 0 đồ uống";
            this.lblTongDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTongDoUong.BackColor = System.Drawing.Color.LightGray;
            this.lblTongDoUong.Height = 25;

            // ============ TAB NHÂN VIÊN ============
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            this.tabNhanVien.Controls.Add(this.txtTenNV);
            this.tabNhanVien.Controls.Add(this.txtChucVu);
            this.tabNhanVien.Controls.Add(this.txtLuong);
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.btnSuaNV);
            this.tabNhanVien.Controls.Add(this.btnXoaNV);
            this.tabNhanVien.Controls.Add(this.btnLamMoiNV);
            this.tabNhanVien.Controls.Add(this.label4);
            this.tabNhanVien.Controls.Add(this.label5);
            this.tabNhanVien.Controls.Add(this.label6);

            this.label4.Text = "Tên nhân viên:";
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.txtTenNV.Location = new System.Drawing.Point(120, 27);

            this.label5.Text = "Chức vụ:";
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.txtChucVu.Location = new System.Drawing.Point(120, 67);

            this.label6.Text = "Lương:";
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.txtLuong.Location = new System.Drawing.Point(120, 107);

            this.btnThemNV.Text = "+ Thêm";
            this.btnThemNV.Location = new System.Drawing.Point(300, 40);
            this.btnSuaNV.Text = "✏️ Sửa";
            this.btnSuaNV.Location = new System.Drawing.Point(400, 40);
            this.btnXoaNV.Text = "🗑 Xóa";
            this.btnXoaNV.Location = new System.Drawing.Point(500, 40);
            this.btnLamMoiNV.Text = "🔄 Làm mới";
            this.btnLamMoiNV.Location = new System.Drawing.Point(600, 40);

            this.dgvNhanVien.Location = new System.Drawing.Point(10, 160);
            this.dgvNhanVien.Size = new System.Drawing.Size(750, 160);

            // ============ TAB KHÁCH HÀNG ============
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.Controls.Add(this.dgvKhach);
            this.tabKhachHang.Controls.Add(this.txtTenKH);
            this.tabKhachHang.Controls.Add(this.txtSDT);
            this.tabKhachHang.Controls.Add(this.txtGhiChu);
            this.tabKhachHang.Controls.Add(this.btnThemKH);
            this.tabKhachHang.Controls.Add(this.btnSuaKH);
            this.tabKhachHang.Controls.Add(this.btnXoaKH);
            this.tabKhachHang.Controls.Add(this.btnLamMoiKH);
            this.tabKhachHang.Controls.Add(this.label7);
            this.tabKhachHang.Controls.Add(this.label8);
            this.tabKhachHang.Controls.Add(this.label9);

            this.label7.Text = "Tên khách hàng:";
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.txtTenKH.Location = new System.Drawing.Point(140, 27);

            this.label8.Text = "Số điện thoại:";
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.txtSDT.Location = new System.Drawing.Point(140, 67);

            this.label9.Text = "Ghi chú:";
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.txtGhiChu.Location = new System.Drawing.Point(140, 107);

            this.btnThemKH.Text = "+ Thêm";
            this.btnThemKH.Location = new System.Drawing.Point(300, 40);
            this.btnSuaKH.Text = "✏️ Sửa";
            this.btnSuaKH.Location = new System.Drawing.Point(400, 40);
            this.btnXoaKH.Text = "🗑 Xóa";
            this.btnXoaKH.Location = new System.Drawing.Point(500, 40);
            this.btnLamMoiKH.Text = "🔄 Làm mới";
            this.btnLamMoiKH.Location = new System.Drawing.Point(600, 40);

            this.dgvKhach.Location = new System.Drawing.Point(10, 160);
            this.dgvKhach.Size = new System.Drawing.Size(750, 160);

            // ============ FORM SETTINGS ============
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.tabControl1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Text = "QUẢN LÝ QUÁN BAR";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDoUong;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabKhachHang;

        // Đồ uống
        private System.Windows.Forms.TextBox txtTenDU;
        private System.Windows.Forms.ComboBox cboLoaiDU;
        private System.Windows.Forms.TextBox txtGiaDU;
        private System.Windows.Forms.Button btnThemDU, btnSuaDU, btnXoaDU, btnLamMoiDU;
        private System.Windows.Forms.DataGridView dgvDoUong;
        private System.Windows.Forms.Label label1, label2, label3, lblTongDoUong;

        // Nhân viên
        private System.Windows.Forms.TextBox txtTenNV, txtChucVu, txtLuong;
        private System.Windows.Forms.Button btnThemNV, btnSuaNV, btnXoaNV, btnLamMoiNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label4, label5, label6;

        // Khách hàng
        private System.Windows.Forms.TextBox txtTenKH, txtSDT, txtGhiChu;
        private System.Windows.Forms.Button btnThemKH, btnSuaKH, btnXoaKH, btnLamMoiKH;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Label label7, label8, label9;
    }
}
