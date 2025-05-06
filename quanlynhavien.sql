drop table nhanvien;
create table nhanvien(
 manv nvarchar(20) not null primary key,
 hoten nvarchar(20) not null,
  diachi nvarchar(20) not null,
 ngaysinh datetime not null,
 dienthoai int not null,
 )
 go
 insert into nhanvien values('nv01','sv ten thanh','sv','2023/02/20',1233)
 select * from nhanvien

 DELETE FROM nhanvien 

 SELECT FORMAT(NgaySinh, 'dd/MM/yy') AS NgaySinh_DinhDang
FROM nhanvien;














 drop table account
create table account(
 usser nchar(20) not null primary key,
 pass nchar(20) not null,
)
go
select * from account

insert into account values('admin','1')
select * from accont










create table monan(
 mamon nvarchar(20) not null primary key,
 tenmon nvarchar(20) not null,
 dongia float not null,
)
go
drop table datmon
create table datmon(
   STT INT PRIMARY KEY,
    MaMon nvarchar(20) not null foreign key (mamon) references monan(mamon),
    SoLuong INT not null,
    MaBan VARCHAR(10) not null,
)
cach 1 k xac dinh duoc ten cua khoa ngoai
alter table datmon
add foreign key (mamon) references monan(mamon)
cach2
ALTER TABLE datmon
add constraint fk_datmon_monan
FOREIGN KEY (mamon) REFERENCES monan(mamon);

