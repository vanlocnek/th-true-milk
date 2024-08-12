CREATE DATABASE THTRUEMILKDB
GO
USE THTRUEMILKDB
GO

/* BANG CHAT LIEU */
CREATE TABLE product_types (
id nvarchar(10) NOT NULL,
name nvarchar(50) NOT NULL,

PRIMARY KEY (id)
);

/*DU LIEU BANG CHAT LIEU */

/*
INSERT INTO product_types 
	(id, name) 
VALUES 
('SUA', N'Sữa'),
('SCH', N'Sữa chua');

*/

/* BANG NGUOI DUNG */
CREATE TABLE users (
id int NOT NULL IDENTITY(1,1),
name nvarchar(50) NOT NULL,
username nvarchar(50) NOT NULL,
password nvarchar(50) NOT NULL,
group_type nchar(10) NOT NULL

PRIMARY KEY (id)
)

/* BANG CHUC NANG */
CREATE TABLE permission (
id int NOT NULL,
name nvarchar(100),

PRIMARY KEY (id)
)

/* BANG PHAN QUYEN */
CREATE TABLE user_permission (
id int NOT NULL IDENTITY(1, 1),
id_user int NOT NULL,
id_permission int NOT NULL

PRIMARY KEY (id),
FOREIGN KEY (id_user) REFERENCES users(id),
FOREIGN KEY (id_permission) REFERENCES permission(id)
)

/* DU LIEU BANG NGUOI DUNG */
INSERT INTO users 
	(name, username, password, group_type) 
VALUES 
(N'Đỗ Quốc Hùng', 'dohung', '123456', 'user'),
(N'Lê Văn Lộc', 'vanloc', '123456', 'user'),
(N'Lâm Chí Nguyên', 'chinguyen', '123456', 'user'),
(N'Quản Trị Viên', 'adminpro', '123456', 'admin');

/* DU LIEU BANG CHUC NANG */
INSERT INTO permission 
	(id, name) 
VALUES 
(1, N'Thêm Tài Khoản'),
(2, N'Đổi mật khẩu'),
(3, N'Quản Lý Chất Liệu'),
(4, N'Quản Lý Sản Phẩm'),
(5, N'Quản Lý Nhân Viên'),
(6, N'Quản Lý Khách Hàng'),
(7, N'Quản Lý Hoá Đơn'),
(8, N'Chi Tiết Hoá Đơn'),
(9, N'Tìm Kiếm Hoá Đơn'),
(10, N'Tìm Kiếm Khách Hàng'),
(11, N'Tìm Kiếm Mặt Hàng'),
(12, N'Báo Cáo Doanh Thu'),
(13, N'Báo Cáo Tồn Kho'),
(14, N'In Báo Cáo'),
(15, N'In Hoá Đơn');

/* DU LIEU BANG PHAN QUYEN */
INSERT INTO user_permission 
	(id_user, id_permission) 
VALUES 
(1, 2),
(1, 3),
(1, 7),
(2, 4),
(2, 2),
(2, 3),
(2, 7),
(2, 4),
(3, 2),
(3, 3),
(3, 7);


/* BANG CHI NHANH CONG TY */
CREATE TABLE branchs (
id int NOT NULL IDENTITY(1,1),
phone nvarchar(20) NOT NULL,
email nvarchar(100) NOT NULL,
address_full nvarchar(100) NOT NULL

PRIMARY KEY (id)
)

/* BANG  CHUC VU NHAN VIEN */
CREATE TABLE staff_groups (
id int NOT NULL IDENTITY(1,1),
short_code nchar(5) NOT NULL,
name nvarchar(80) NOT NULL

PRIMARY KEY (id)
)

/*BANG NHAN VIEN*/
CREATE TABLE staffs (
id int NOT NULL IDENTITY(1,1),
name nvarchar(100) NOT NULL,
phone nvarchar(15) NOT NULL,
email nvarchar(100),
staff_group_id int NOT NULL,
branch_id int NOT NULL

PRIMARY KEY (id),
FOREIGN KEY (staff_group_id) REFERENCES staff_groups(id),
FOREIGN KEY (branch_id) REFERENCES branchs(id)
)

/*DU LIEU BANG NHAN VIEN*/
/*
INSERT INTO staffs (name, phone, email, staff_group_id) 
VALUES
(N'Le Van Loc', '0913605897', 'levanloc8112@gmail.com', 1)
*/

/*BANG KHACH HANG*/
CREATE TABLE customers (
id int NOT NULL IDENTITY(1,1),
name nvarchar(100) NOT NULL,
phone nvarchar(15) NOT NULL,
email nvarchar(100),
address_full nvarchar(200),

PRIMARY KEY (id)
)

/*
INSERT INTO customers(name, phone, email, address_full) 
VALUES
(N'Nguyễn Văn A', '0956789451', 'customer.demo@gmail.com', 'Ba Ria - Vung Tau');
*/


/*BANG HOA DON*/
CREATE TABLE invoices (
id nvarchar(15) NOT NULL,
id_staff int NOT NULL,
id_customer int NOT NULL,
created_at date NOT NULL,
total_amount float NOT NULL,

PRIMARY KEY (id),
FOREIGN KEY (id_staff) REFERENCES staffs(id),
FOREIGN KEY (id_customer) REFERENCES customers(id)
)

/*
INSERT INTO invoices(id, id_staff, id_customer, created_at, total_amount) 
VALUES ('HD1', 1, 1, '2024-11-08', 13000) 
*/

/*BANG MAT HANG*/
CREATE TABLE products(
id nvarchar(10) NOT NULL,
name nvarchar(100) NOT NULL,
product_type_id nvarchar(10) NOT NULL,
amount float NOT NULL,
import_price float NOT NULL,
export_price float NOT NULL,
note nvarchar(200),

PRIMARY KEY (id),
FOREIGN KEY (product_type_id) REFERENCES product_types(id)
)

/*DU LIEU MAT HANG*/
/*
INSERT INTO products(id, name, product_type_id, amount, import_price, export_price, note)
VALUES 
('MH1', '123', 'sat', 2, 1300, 1400, 'abc')
*/

/*BANG CHI TIET HOA DON*/
CREATE TABLE invoice_detail (
id int NOT NULL IDENTITY(1,1),
invoice_id nvarchar(15) NOT NULL,
product_id nvarchar(10) NOT NULL,
amount float NOT NULL,
price float NOT NULL,
discount float NOT NULL,
money float NOT NULL,

PRIMARY KEY (id),
FOREIGN KEY (invoice_id) REFERENCES invoices(id),
FOREIGN KEY (product_id) REFERENCES products(id)
)
/*
INSERT INTO invoice_detail (invoice_id, product_id, amount, price, discount, money)
VALUES
('HD1', 'MH1', 4, 1000, 10, 900);
*/

/*
CREATE PROC InChiTiet 
@MaHoaDon nvarchar(15)
AS BEGIN
SELECT MH.id, MH.TenHang, CT.SoLuong, DonGia, GiamGia, ThanhTien
FROM MatHang as MH JOIN ChiTietHoaDon AS CT ON MH.id = CT.id_mh WHERE CT.id_hd = @MaHoaDon
END

SELECT MH.id, MH.TenHang, CT.SoLuong, DonGia, GiamGia, ThanhTien
FROM MatHang as MH JOIN ChiTietHoaDon AS CT ON MH.id = CT.id_mh WHERE CT.id_hd = 'HD1'
*/

SELECT * FROM users WHERE username = 'vanloc' AND password = '123456'