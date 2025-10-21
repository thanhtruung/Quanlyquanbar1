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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDU = new System.Windows.Forms.TextBox();
            this.cboLoaiDU = new System.Windows.Forms.ComboBox();
            this.txtGiaDU = new System.Windows.Forms.TextBox();
            this.btnThemDU = new System.Windows.Forms.Button();
            this.btnSuaDU = new System.Windows.Forms.Button();
            this.btnXoaDU = new System.Windows.Forms.Button();
            this.btnLamMoiDU = new System.Windows.Forms.Button();
            this.dgvDoUong = new System.Windows.Forms.DataGridView();
            this.lblTongDoUong = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabDoUong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoUong)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(250, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(222, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ QUÁN BAR";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDoUong);
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Controls.Add(this.tabKhachHang);
            this.tabControl1.Location = new System.Drawing.Point(10, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 370);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDoUong
            // 
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
            this.tabDoUong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoUong.Location = new System.Drawing.Point(4, 22);
            this.tabDoUong.Name = "tabDoUong";
            this.tabDoUong.Size = new System.Drawing.Size(772, 344);
            this.tabDoUong.TabIndex = 0;
            this.tabDoUong.Text = "Đồ uống";
            this.tabDoUong.Click += new System.EventHandler(this.tabDoUong_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đồ uống:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại đồ uống:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá (VNĐ):";
            // 
            // txtTenDU
            // 
            this.txtTenDU.Location = new System.Drawing.Point(120, 27);
            this.txtTenDU.Name = "txtTenDU";
            this.txtTenDU.Size = new System.Drawing.Size(100, 25);
            this.txtTenDU.TabIndex = 3;
            // 
            // cboLoaiDU
            // 
            this.cboLoaiDU.Items.AddRange(new object[] {
            "Bia",
            "Rượu",
            "Cocktail",
            "Nước ngọt"});
            this.cboLoaiDU.Location = new System.Drawing.Point(120, 67);
            this.cboLoaiDU.Name = "cboLoaiDU";
            this.cboLoaiDU.Size = new System.Drawing.Size(121, 25);
            this.cboLoaiDU.TabIndex = 4;
            // 
            // txtGiaDU
            // 
            this.txtGiaDU.Location = new System.Drawing.Point(120, 107);
            this.txtGiaDU.Name = "txtGiaDU";
            this.txtGiaDU.Size = new System.Drawing.Size(100, 25);
            this.txtGiaDU.TabIndex = 5;
            // 
            // btnThemDU
            // 
            this.btnThemDU.Location = new System.Drawing.Point(300, 40);
            this.btnThemDU.Name = "btnThemDU";
            this.btnThemDU.Size = new System.Drawing.Size(75, 23);
            this.btnThemDU.TabIndex = 6;
            this.btnThemDU.Text = "+ Thêm";
            this.btnThemDU.Click += new System.EventHandler(this.btnThemDU_Click);
            // 
            // btnSuaDU
            // 
            this.btnSuaDU.Location = new System.Drawing.Point(400, 40);
            this.btnSuaDU.Name = "btnSuaDU";
            this.btnSuaDU.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDU.TabIndex = 7;
            this.btnSuaDU.Text = "✏️ Sửa";
            this.btnSuaDU.Click += new System.EventHandler(this.btnSuaDU_Click);
            // 
            // btnXoaDU
            // 
            this.btnXoaDU.Location = new System.Drawing.Point(500, 40);
            this.btnXoaDU.Name = "btnXoaDU";
            this.btnXoaDU.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDU.TabIndex = 8;
            this.btnXoaDU.Text = "🗑 Xóa";
            this.btnXoaDU.Click += new System.EventHandler(this.btnXoaDU_Click);
            // 
            // btnLamMoiDU
            // 
            this.btnLamMoiDU.Location = new System.Drawing.Point(600, 40);
            this.btnLamMoiDU.Name = "btnLamMoiDU";
            this.btnLamMoiDU.Size = new System.Drawing.Size(75, 52);
            this.btnLamMoiDU.TabIndex = 9;
            this.btnLamMoiDU.Text = "🔄 Làm mới";
            this.btnLamMoiDU.Click += new System.EventHandler(this.btnLamMoiDU_Click);
            // 
            // dgvDoUong
            // 
            this.dgvDoUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoUong.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoUong.Location = new System.Drawing.Point(10, 160);
            this.dgvDoUong.Name = "dgvDoUong";
            this.dgvDoUong.Size = new System.Drawing.Size(750, 160);
            this.dgvDoUong.TabIndex = 10;
            // 
            // lblTongDoUong
            // 
            this.lblTongDoUong.BackColor = System.Drawing.Color.LightGray;
            this.lblTongDoUong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongDoUong.Location = new System.Drawing.Point(0, 319);
            this.lblTongDoUong.Name = "lblTongDoUong";
            this.lblTongDoUong.Size = new System.Drawing.Size(772, 25);
            this.lblTongDoUong.TabIndex = 11;
            this.lblTongDoUong.Text = "Tổng số: 0 đồ uống";
            this.lblTongDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabNhanVien
            // 
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
            this.tabNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(772, 344);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(10, 160);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(750, 160);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(120, 27);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(120, 67);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(100, 22);
            this.txtChucVu.TabIndex = 2;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(120, 107);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(100, 22);
            this.txtLuong.TabIndex = 3;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(300, 40);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(75, 23);
            this.btnThemNV.TabIndex = 4;
            this.btnThemNV.Text = "+ Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(400, 40);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNV.TabIndex = 5;
            this.btnSuaNV.Text = "✏️ Sửa";
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(500, 40);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNV.TabIndex = 6;
            this.btnXoaNV.Text = "🗑 Xóa";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.Location = new System.Drawing.Point(600, 40);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(75, 49);
            this.btnLamMoiNV.TabIndex = 7;
            this.btnLamMoiNV.Text = "🔄 Làm mới";
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chức vụ:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lương:";
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.tabKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(772, 344);
            this.tabKhachHang.TabIndex = 2;
            this.tabKhachHang.Text = "Khách hàng";
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.Location = new System.Drawing.Point(10, 160);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.Size = new System.Drawing.Size(750, 160);
            this.dgvKhach.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(140, 27);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 25);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(140, 67);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 25);
            this.txtSDT.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(140, 107);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 25);
            this.txtGhiChu.TabIndex = 3;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(300, 40);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(75, 23);
            this.btnThemKH.TabIndex = 4;
            this.btnThemKH.Text = "+ Thêm";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(400, 40);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaKH.TabIndex = 5;
            this.btnSuaKH.Text = "✏️ Sửa";
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(500, 40);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKH.TabIndex = 6;
            this.btnXoaKH.Text = "🗑 Xóa";
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnLamMoiKH
            // 
            this.btnLamMoiKH.Location = new System.Drawing.Point(600, 40);
            this.btnLamMoiKH.Name = "btnLamMoiKH";
            this.btnLamMoiKH.Size = new System.Drawing.Size(75, 52);
            this.btnLamMoiKH.TabIndex = 7;
            this.btnLamMoiKH.Text = "🔄 Làm mới";
            this.btnLamMoiKH.Click += new System.EventHandler(this.btnLamMoiKH_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên khách hàng:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số điện thoại:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ghi chú:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ QUÁN BAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDoUong.ResumeLayout(false);
            this.tabDoUong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoUong)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tabDoUong_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
