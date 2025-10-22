CREATE DATABASE QuanLyQuanBar;
GO

USE QuanLyQuanBar;
GO
CREATE TABLE DoUong (
    MaDoUong INT IDENTITY(1,1) PRIMARY KEY,
    TenDoUong NVARCHAR(100) NOT NULL,
    LoaiDoUong NVARCHAR(50),
    DonGia DECIMAL(18,2) CHECK (DonGia >= 0)
);

-- Dữ liệu mẫu
INSERT INTO DoUong (TenDoUong, LoaiDoUong, DonGia)
VALUES
(N'Bia Heineken', N'Bia', 30000),
(N'Rượu Vodka', N'Rượu', 85000),
(N'Cocktail Mojito', N'Cocktail', 70000),
(N'Coca Cola', N'Nước ngọt', 15000),
(N'Nước suối', N'Nước ngọt', 10000);
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    ChucVu NVARCHAR(50),
    Luong DECIMAL(18,2) CHECK (Luong >= 0)
);

CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15),
    GhiChu NVARCHAR(200)
);

-- Dữ liệu mẫu
INSERT INTO KhachHang (TenKH, SDT, GhiChu)
VALUES
(N'Lê Minh C', '0909123456', N'Khách quen'),
(N'Nguyễn Hoàng D', '0938456789', N'Khách mới'),
(N'Trần Mỹ E', '0977888999', N'Thường gọi cocktail');
SELECT * FROM DoUong;
SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
