create database QLNV2 ;
use QLNV2;
create table NhanVien(
MaNV varchar(5) primary key,
HoTen varchar(20),
NgaySinh date,
DiaChi varchar(20),
DienThoai int
)
create table MonAn(
MaMon varchar(5)  primary key,
TenMon varchar(20),
DonGia int 
)
create table DatMonAn(
STT int,
MaMon varchar(5),
SoLuong int ,
MaBan varchar(5) primary key,
)
create table Account(
User1 varchar(50) primary key,
Password1 varchar(50)
)
insert into Account  values ('admin',1);
insert into Account  values ('admin2',2);
insert into Account  values ('admin3',3);
insert into NhanVien(MaNV,HoTen,NgaySinh,DiaChi,DienThoai)  
values ('NV01','Le Quoc Cuong','2005-12-2','Binh Dinh','08651321'),
('NV02','Le Quoc A','2005-12-2','Binh Dinh','0864221'),
('NV03','Le Quoc B','2002-4-2','Binh Dinh','011212'),
('NV04','Le Quoc C','2003-12-2','Sai Gon','08234221'),
('NV05','Le Quoc D','2005-12-2','Gia Lai','0923221');
insert into MonAn(MaMon,TenMon,DonGia)  
values ('Mon1','dau buoi',60000),
('Mon2','dau buoi 2',11000),
('Mon3','dau buoi 3',70000);