
CREATE TABLE SinhVien (
    MaSo NVARCHAR(100) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATETIME,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(15),
    MaKhoa NVARCHAR(100)
);

CREATE TABLE MonHoc (
    MaMH NVARCHAR(100) PRIMARY KEY,
    TenMH NVARCHAR(100),
    SoTiet INT
);

CREATE TABLE Khoa (
    MaKhoa NVARCHAR(100) PRIMARY KEY,
    TenKhoa NVARCHAR(100)
);


CREATE TABLE Diem (
    MaSo NVARCHAR(100),
    MaMH NVARCHAR(100),
    Diem FLOAT,
    PRIMARY KEY (MaSo, MaMH),
    FOREIGN KEY (MaSo) REFERENCES SinhVien(MaSo),
    FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH)
);
drop table diem
drop table khoa
drop table monhoc
drop table sinhvien

alter table sinhvien
add foreign key (makhoa) references khoa(makhoa)

select * from sinhvien;



SELECT 
    sv.MaSo, 
    sv.HoTen, 
    sv.NgaySinh, 
    sv.GioiTinh, 
    sv.DiaChi, 
    sv.DienThoai, 
    k.TenKhoa, 
    mh.TenMH, 
    mh.SoTiet
FROM 
    SinhVien sv
JOIN 
    Khoa k ON sv.MaKhoa = k.MaKhoa
JOIN 
    Diem d ON sv.MaSo = d.MaSo
JOIN 
    MonHoc mh ON d.MaMH = mh.MaMH;


INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES
('CNTT', N'Công nghệ thông tin'),
('KT', N'Kinh tế'),
('DĐT', N'Điện - Điện tử');


INSERT INTO SinhVien (MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaKhoa) VALUES
('SV001', N'Nguyễn Văn A', '2003-05-10', N'Nam', N'123 Lê Lợi, Hà Nội', '0912345678', 'CNTT'),
('SV002', N'Trần Thị B', '2002-08-15', N'Nữ', N'456 Trần Hưng Đạo, Đà Nẵng', '0938765432', 'KT'),
('SV003', N'Lê Văn C', '2001-12-01', N'Nam', N'789 Nguyễn Huệ, TP.HCM', '0905123456', 'CNTT'),
('SV004', N'Phạm Thị D', '2003-03-22', N'Nữ', N'12 Phan Chu Trinh, Huế', '0988123456', 'DĐT');


INSERT INTO MonHoc (MaMH, TenMH, SoTiet) VALUES
('MH001', N'Cơ sở dữ liệu', 45),
('MH002', N'Lập trình Python', 60),
('MH003', N'Kinh tế học đại cương', 45),
('MH004', N'Mạch điện tử', 50);


INSERT INTO Diem (MaSo, MaMH, Diem) VALUES
('SV001', 'MH001', 8.5),
('SV001', 'MH002', 7.0),
('SV002', 'MH003', 9.0),
('SV003', 'MH001', 6.5),
('SV003', 'MH002', 8.0),
('SV004', 'MH004', 7.5);



SELECT sv.HoTen, mh.TenMH, d.Diem
FROM SinhVien sv
JOIN Diem d ON sv.MaSo = d.MaSo
JOIN MonHoc mh ON d.MaMH = mh.MaMH;