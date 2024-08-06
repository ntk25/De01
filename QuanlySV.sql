CREATE DATABASE QuanlySV;
GO

USE QuanlySV;
GO
CREATE TABLE Lop (
    MaLop CHAR(3) PRIMARY KEY,
    TenLop NVARCHAR(30) NOT NULL
);

CREATE TABLE Sinhvien (
    MaSV CHAR(6) PRIMARY KEY,
    HotenSV NVARCHAR(40),
    MaLop CHAR(3),
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);
-- Nhập dữ liệu vào bảng Lop
INSERT INTO Lop (MaLop, TenLop) VALUES ('L01', 'Lop 1');
INSERT INTO Lop (MaLop, TenLop) VALUES ('L02', 'Lop 2');

-- Nhập dữ liệu vào bảng Sinhvien
INSERT INTO Sinhvien (MaSV, HotenSV, MaLop) VALUES ('SV001', 'Nguyen Van A', 'L01');
INSERT INTO Sinhvien (MaSV, HotenSV, MaLop) VALUES ('SV002', 'Tran Thi B', 'L01');
INSERT INTO Sinhvien (MaSV, HotenSV, MaLop) VALUES ('SV003', 'Le Van C', 'L02');
INSERT INTO Sinhvien (MaSV, HotenSV, MaLop) VALUES ('SV004', 'Pham Thi D', 'L02');
