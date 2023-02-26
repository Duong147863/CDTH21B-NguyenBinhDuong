create database	QuanLiBanGiay


create table KHACHHANG
(
	MaKH char(5) not null ,
	HoTenKH nvarchar(25),
	Phai char(3),
	NgaySinh datetime,
	DiaChi nvarchar(100),
	SDT nvarchar(12),
	Email nvarchar(50),
	GhiChu nvarchar(100)
	constraint PK_KhachHang primary key(MaKH)
)
create table NHANVIEN
(
	MaNV int not null,
	HoTenNV nvarchar(25),
	Phai char(3),
	NgaySinh datetime,
	DiaChi nvarchar(100),
	SDT nvarchar(12),
	Email nvarchar(50),
	MaLoaiNV int ,
	constraint PK_NhanVien primary key(MaNV)
)
create table SANPHAM
(
	MaSP int not null ,
	TenSP nvarchar(50),
	MaLoaiSP char(5),
	DVT nvarchar(25),
	NgaySX datetime,
	SoLuongTon int,
	KichCo nvarchar(25),
	MauSac nvarchar(25),
	ChatLieu nvarchar(25),
	GiaBan money,
	MaNCC int,
	NgungKinhDoanh bit,
	constraint PK_SanPham primary key(MaSP)
)
create table HOADON
(
	MaHD int not null,
	NgayLapHD datetime,
	MaNV int,
	MaKH char(5),
	TongTien money,
	DaThanhToan bit,
	constraint PK_HD primary key(MaHD)
)
create table CTHD
(
	MaHD int not null, 
	MaSP int not null,
	SoLuong int,
	GiaBan money,
	ChietKhau money,
	constraint PK_CTHD primary key(MAHD,MaSP)
)
create table NHACUNGCAP
(
	MaNCC int not null,
	TenNCC nvarchar(50),
	DiaChi nvarchar(100),
	SDT nvarchar(12),
	Email nvarchar(50),
	constraint PK_NhaCungCap primary key(MaNCC)
)
create table LOAINHANVIEN
(
	MaLoaiNV int not null,
	TenLoai nvarchar(50),
	constraint PK_LoaiNhanVien primary key(MALoaiNV)
)
create table PHIEUNHAP
(
	MaPhieu char(5) not null,
	NgayNhap datetime,
	MaNV int,
	MaNCC int,
	TongTienNhap money,
	constraint PK_PhieuNhap primary key(MaPhieu)
)
create table CT_PHIEUNHAP
(
	MaPhieu char(5),
	MaSp int,
	SoLuongNhap int,
	DonGiaNhap money,
	constraint PK_CT_PhieuNhap primary key(MaPhieu,MaSP)
)
create table LOAISANPHAM
(
	MaLoaiSP char(5) not null,
	TenLoai nvarchar(50),
	constraint PK_lOAISP primary key(MaLoaiSP)
)
create table TAIKHOAN
(
	TaiKhoan nvarchar(50),
	MatKhau nvarchar(50),
	TrangThai nvarchar(25),
	MaNV int, 
	constraint PK_TaiKhoan primary key(TaiKhoan)
)
create table QUYEN 
(
	MaQuyen int not null,
	TenQuyen nvarchar(50),
	constraint PK_QUYEN primary key(MaQuyen)
)
create table PHANQUYEN
(
	TaiKhoan nvarchar(50),
	MaQuyen int,
	CoQuyen nvarchar(50),
	constraint PK_PhanQuyen primary key(TaiKhoan,MaQuyen)
)
---- Khoa ngoai cho bang HOADON
--ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
--ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
---- Khoa ngoai cho bang CT_HOADON
--ALTER TABLE CT_HOADON ADD CONSTRAINT FK_CT_HOADON_HOADON FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)
--ALTER TABLE CT_HOADON ADD CONSTRAINT FK_CT_HOADON_SANPHAM FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
----Khoa ngoai cho bang SANPHAM
--ALTER TABLE SANPHAM ADD CONSTRAINT PK_SANPHAM_NHACUNGCAP FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP(MANCC)
--ALTER TABLE SANPHAM ADD CONSTRAINT PK_SANPHAM_LOAISANPHAM FOREIGN KEY (MALOAISP) REFERENCES LOAISP (MALOAISP)
----khoa ngoai cho bang 






    
