﻿CREATE DATABASE QLKS
USE QLKS
set dateformat DMY
go
CREATE TABLE LOAIPHONG (
    MALOAIPHONG nvarchar(10) NOT NULL PRIMARY KEY,
    TENLOAIPHONG NVARCHAR(30) NOT NULL,
    DONGIA INT NOT NULL,
    GHICHU NVARCHAR(100)
)
INSERT INTO LOAIPHONG VALUES('A',150000,'PHÒNG GÀ')
SELECT * FROM LOAIPHONG

CREATE TABLE PHONG (
    MAPHONG INT NOT NULL PRIMARY KEY IDENTITY,
    MALOAIPHONG INT NOT NULL FOREIGN KEY REFERENCES LOAIPHONG(MALOAIPHONG),
    TENPHONG NVARCHAR(20) NOT NULL,
    GHICHU NVARCHAR(100) NOT NULL,
	TINHTRANG INT NOT NULL,
)


SELECT PHONG.TENPHONG AS 'TÊN PHÒNG', CHITIETHOADON.SONGAY,CHITIETHOADON.DONGIA, CHITIETHOADON.THANHTIEN, CHITIETHOADON.PHUTHU, CHITIETHOADON.HESO
FROM CHITIETHOADON,KHACHHANG,HOADON,PHONG WHERE (KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG)
AND (HOADON.MAHOADON=CHITIETHOADON.MAHOADON) AND (PHONG.MAPHONG=CHITIETHOADON.MAPHONG) AND (HOADON.TINHTRANGHOADON=0) AND KHACHHANG.MAKHACHHANG =1

select machitiethoadon from chitiethoadon,phong where chitiethoadon.maphong=phong.maphong and phong.MAPHONG = 1

ALTER TABLE	CHITIETBCDT DROP CONSTRAINT FK__CHITIETBC__MALOA__5535A963
ALTER TABLE	LOAIPHONG DROP CONSTRAINT PK__LOAIPHON__82203A7630F09564
ALTER TABLE	LOAIPHONG 
ALTER COLUMN MALOAIPHONG NVARCHAR(10) --1 LA CO NGUOI , 0 LA KHONG NGUOI
delete from PHONG
INSERT INTO PHONG VALUES(1,'101','NONE',1)
INSERT INTO PHONG VALUES(1,'102','NONE',0)
INSERT INTO PHONG VALUES(1,'103','NONE',1)
INSERT INTO PHONG VALUES(1,'104','NONE',1)


SELECt * from PHONG
select * from dbo.PHONG WHERE TINHTRANG = 1 

SELECT * FROM CHITIETHOADON,KHACHHANG,HOADON WHERE (KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG) AND (HOADON.MAHOADON=CHITIETHOADON.MAHOADON) AND (HOADON.TINHTRANGHOADON=0) AND KHACHHANG.MAKHACHHANG=

select * from KHACHHANG


CREATE TABLE LOAIKHACHHANG (
    MALOAIKHACHHANG INT NOT NULL PRIMARY KEY IDENTITY,
    TENLOAIKHACHHANG NVARCHAR(50) NOT NULL
)
insert into LOAIKHACHHANG VALUES ('NOI DIA')
insert into LOAIKHACHHANG VALUES ('NUOC NGOAI')
SELECT * FROM LOAIKHACHHANG

CREATE TABLE KHACHHANG (
    MAKHACHHANG INT NOT NULL PRIMARY KEY IDENTITY,
    MALOAIKHACHHANG INT NOT NULL FOREIGN KEY REFERENCES LOAIKHACHHANG(MALOAIKHACHHANG),
    TENKHACHHANG NVARCHAR(50) NOT NULL,
    CMND INT NOT NULL,
    DIACHI NVARCHAR(50) NOT NULL,
    SODIENTHOAI INT,
    NGAYSINH DATETIME
)
SELECT * FROM KHACHHANG

insert into KHACHHANG VALUES (2, 'NGUYEN VAN ASDGF', 1243123,'ASDFASDF',122323,'01/01/2000')
insert into KHACHHANG VALUES (2, 'NGUYEN VAN ASDGF', 1243123,'ASDFASDF',122323,'01/01/2000')
insert into KHACHHANG VALUES (2, 'NGUYEN VAN b', 1243123,'ASDagdfhjadsfgFASDF',122323,'01/01/2000')

insert into KHACHHANG VALUES (1, 'NGUYEN VAN A', 1243123,'ASDFASDF',72316476,01/01/20)
SELECT * FROM KHACHHANG
DELETE  
FROM KHACHHANG
WHERE MAKHACHHANG=

SELECT * FROM HOADON

select * from phong
insert into loaiphong(maloaiphong,tenloaiphong,dongia,ghichu) values('l01','vip',150000,'khong co')

CREATE TABLE PHIEUTHUEPHONG (
    MAPHIEUTHUE INT NOT NULL PRIMARY KEY IDENTITY,
    NGAYLAPPHIEU DATETIME NOT NULL,
    MAPHONG INT NOT NULL FOREIGN KEY REFERENCES PHONG(MAPHONG)
)

alter table phieuthuephong add tinhtrang int default 0


insert PHIEUTHUEPHONG(NGAYLAPPHIEU,MAPHONG) VALUES ('27/06/2020',2)
insert PHIEUTHUEPHONG(NGAYLAPPHIEU,MAPHONG) VALUES ('27/06/2020',3)
SELECT * FROM PHIEUTHUEPHONG

CREATE TABLE CHITIETPHIEUTHUEPHONG (
    MACHITIETPHIEUTHUE INT NOT NULL PRIMARY KEY IDENTITY,
	MAPHIEUTHUE INT NOT NULL FOREIGN KEY REFERENCES PHIEUTHUEPHONG(MAPHIEUTHUE),
    MAKHACHHANG INT NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MAKHACHHANG)
)
insert CHITIETPHIEUTHUEPHONG(MAPHIEUTHUE,MAKHACHHANG) VALUES (6,1)
insert CHITIETPHIEUTHUEPHONG(MAPHIEUTHUE,MAKHACHHANG) VALUES (6,2)
SELECT * FROM CHITIETPHIEUTHUEPHONG







CREATE TABLE THAMSO (
    SOLUONGKHACHTOIDATRONGPHONG INT NOT NULL
)


CREATE TABLE DANGKI (
    MADANGKI INT NOT NULL PRIMARY KEY IDENTITY,
    TENDANGNHAP VARCHAR(50) NOT NULL,
	MATKHAU VARCHAR(50) NOT NULL,
	HOTEN NVARCHAR(50) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	SODIENTHOAI INT NOT NULL,
	DIACHI NVARCHAR(50) NOT NULL
)
ALTER TABLE THAMSO ADD PHUTHU VARCHAR(50)

ALTER TABLE THAMSO ADD HESO FLOAT

CREATE TABLE HOADON (
    MAHOADON INT NOT NULL PRIMARY KEY IDENTITY,
    THANHTIEN INT NOT NULL,
    NGAYLAP DATETIME,
	MAKHACHHANG INT REFERENCES KHACHHANG(MAKHACHHANG)
)


SELECT * FROM HOADON

ALTER proc USP_InsertBill
@makh int
as
begin
	insert into HOADON(NGAYLAP,MAKHACHHANG,THANHTIEN,TINHTRANGHOADON)
	values(GETDATE(),@makh,0,0)
end
go

select * from khachhang

USP_InsertBill 1
select * from KHACHHANG

select *  from HOADON

select * from phong


--SELECT * FROM HOADON
--select * from KHACHHANG
--insert into HOADON(NGAYLAP,MAKHACHHANG,THANHTIEN)
--	values(GETDATE(),1,0)

--select * from HOADON
--INSERT INTO HOADON(NGAYLAP, THANHTIEN,HOTEN, DIACHI) VALUES ('28/07/2020',0, 'NGUYEN VAN B', 'ÁDFASDFASDF')
--DELETE HOADON

--select max(MAHOADON)  from HOADON

create proc USP_GetUnCheckBillByIDCustomer
@makh int
as
begin
	select * 
	from KHACHHANG kh,HOADON hd
	where  (hd.MAKHACHHANG = kh.MAKHACHHANG) and hd.MAKHACHHANG = @makh and (hd.TINHTRANGHOADON =1)
end
go

CREATE TABLE CHITIETHOADON (
    MACHITIETHOADON INT NOT NULL PRIMARY KEY IDENTITY,
    MAHOADON INT NOT NULL FOREIGN KEY REFERENCES HOADON(MAHOADON),
	MAPHONG INT NOT NULL FOREIGN KEY REFERENCES PHONG(MAPHONG),
	SONGAY FLOAT NOT NULL,
    DONGIA INT NOT NULL,	
)

alter table chitiethoadon add  phuthu float default 0


ALTER TABLE CHITIETHOADON ADD THANHTIEN INT DEFAULT 0
MAHOADON,MAPHONG,SONGAY,DONGIA
CREATE TABLE BAOCAODOANHTHU (
    MABCDT INT NOT NULL PRIMARY KEY IDENTITY,
    THANG INT NOT NULL,
    TONGDOANHTHU INT 
)

CREATE TABLE CHITIETBCDT (
    MACTBCDT INT NOT NULL PRIMARY KEY IDENTITY,
    MABCDT INT NOT NULL FOREIGN KEY REFERENCES BAOCAODOANHTHU(MABCDT),
	MALOAIPHONG INT NOT NULL FOREIGN KEY REFERENCES LOAIPHONG(MALOAIPHONG),
    DOANHTHU INT NOT NULL,
	TYLE VARCHAR 
)


--CREATE PROC USP_themChiTietHoaDon
--@mahd INT , @maphong INT, @songay INT,@ngaylaphoadon datetime, @
--as
--begin
--	SELECT hd.NGAYLAP, ptp.NGAYLAPPHIEU
--	FROM HOADON hd, PHIEUTHUEPHONG ptp 
--	WHERE MAPHONG=@maphong
--	@songay=
--	INSERT INTO CHITIETHOADON(MAHOADON,MAPHONG,) values (@mahd,@maphong,@makh)
--end 


 select datediff(dayofyear,PHIEUTHUEPHONG.NGAYLAPPHIEU, HOADON.NGAYLAP ) FROM PHIEUTHUEPHONG, HOADON, CHITIETPHIEUTHUEPHONG WHERE (MAPHONG=2) AND (CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE=PHIEUTHUEPHONG.MAPHIEUTHUE) AND (CHITIETPHIEUTHUEPHONG.MAKHACHHANG= HOADON.MAKHACHHANG)  
 SELECT * FROM PHONG
 SELECT DATEDIFF (DAYOFYEAR, '12/12/2018', '01/01/2019')

create PROC USP_addChiTietHoaDon
@mahd INT , @maphong INT
AS
BEGIN
	declare  @ngaypht datetime, @ngayhd datetime, @tontaichitiethoadon int

	select @ngaypht = pt.NGAYLAPPHIEU
	from PHIEUTHUEPHONG pt, PHONG p
	where pt.MAPHONG=@maphong and(p.MAPHONG=pt.MAPHONG) and (p.TINHTRANG=1)
	
	select @ngayhd= hd.NGAYLAP
	from  HOADON hd
	where hd.MAHOADON=@mahd

	declare @songay int 
	set @songay = 0
	SELECT @songay= datediff(DAYOFYEAR ,@ngaypht , @ngayhd)

	declare @dongia int
	select  @dongia=LOAIPHONG.DONGIA FROM PHONG, LOAIPHONG WHERE (PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG) AND (PHONG.MAPHONG =@maphong)

	declare @thanhtien int = 0
	select @thanhtien=CHITIETHOADON.DONGIA * CHITIETHOADON.SONGAY  FROM CHITIETHOADON,PHONG WHERE(CHITIETHOADON.MAPHONG=PHONG.MAPHONG) AND (CHITIETHOADON.MAPHONG=@maphong)

	select @tontaichitiethoadon = machitiethoadon from CHITIETHOADON, PHONG where PHONG.MAPHONG=CHITIETHOADON.MAPHONG and phong.MAPHONG=@maphong

	if(@tontaichitiethoadon > 0 )
	begin return
	end
	else 
	begin
		insert into CHITIETHOADON(MAHOADON,MAPHONG,SONGAY,DONGIA,THANHTIEN) values ( @mahd , @maphong , @songay , @dongia , @thanhtien )
	end
END
GO

select * from CHITIETHOADON

select machitiethoadon from CHITIETHOADON, PHONG where PHONG.MAPHONG=CHITIETHOADON.MAPHONG and phong.MAPHONG=2 

insert PHIEUTHUEPHONG(NGAYLAPPHIEU, MAPHONG) VALUES('18/07/2020', 2 )

insert PHIEUTHUEPHONG(NGAYLAPPHIEU, MAPHONG) VALUES('18/07/2020', 4)

insert PHIEUTHUEPHONG(NGAYLAPPHIEU, MAPHONG) VALUES('18/07/2020', 5)

insert PHIEUTHUEPHONG(NGAYLAPPHIEU, MAPHONG) VALUES('18/07/2020', 6)

update phong set tinhtrang=1 where maphong=6
select * from phong where maphong=6
select * from HOADON

USP_addChiTietHoaDon 5004, 4

select * from CHITIETHOADON where MAHOADON=5004

select * from phong

delete from HOADON

--select  from dbo.PHONG,PHIEUTHUEPHONG WHERE TINHTRANG =1 AND(PHIEUTHUEPHONG.MAPHONG=PHONG.MAPHONG)

--select * from dbo.KHACHHANG WHERE MAKHACHHANG = 1

--select MAPHIEUTHUE,NGAYLAPPHIEU,PHONG.MAPHONG from dbo.PHONG,PHIEUTHUEPHONG WHERE TINHTRANG =1 AND(PHIEUTHUEPHONG.MAPHONG=PHONG.MAPHONG) 

SELECT * FROM HOADON 
SELECT * FROM KHACHHANG
select * from CHITIETHOADON
SELECT ct.MAPHONG,ct.SONGAY,ct.DONGIA FROM CHITIETHOADON ct,KHACHHANG,HOADON WHERE (KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG) AND (HOADON.MAHOADON=ct.MAHOADON) AND (HOADON.TINHTRANGHOADON=0) AND (KHACHHANG.MAKHACHHANG =1)


alter PROC USP_updateChiTietHoaDon
@maphong int
as
begin
	update CHITIETHOADON set THANHTIEN = SONGAY*DONGIA
	
	DECLARE @songuoinuocngoaitrongphong int
	SELECT @songuoinuocngoaitrongphong = COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND KHACHHANG.MALOAIKHACHHANG =1
	AND PHIEUTHUEPHONG.TINHTRANG=0 and PHIEUTHUEPHONG.MAPHONG=@maphong
	
	if (@songuoinuocngoaitrongphong > 0)
	begin
	update CHITIETHOADON set heso=(select giatrithamso from thamso where mathamso=2) where MAPHONG=@maphong
	end

	DECLARE @songuoitrongphong int
	SELECT @songuoitrongphong = COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND PHIEUTHUEPHONG.TINHTRANG=0 and PHIEUTHUEPHONG.MAPHONG=@maphong

	if(@songuoitrongphong = 3 )
	begin
	update CHITIETHOADON set PHUTHU=0.9 where MAPHONG=@maphong
	end

end
GO

SELECT  COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND PHIEUTHUEPHONG.TINHTRANG=0 and PHIEUTHUEPHONG.MAPHONG=2

		update CHITIETHOADON set phuthu=(select giatrithamso from thamso where mathamso=1) where MAPHONG=2
		select * from CHITIETHOADON
USP_updateChiTietHoaDon 2

select * from CHITIETHOADON

SELECT * FROM PHONG

SELECT  COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND PHIEUTHUEPHONG.TINHTRANG=0 and PHIEUTHUEPHONG.MAPHONG=6

SELECT * FROM THAMSO

	SELECT  COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND PHIEUTHUEPHONG.TINHTRANG=0 and PHIEUTHUEPHONG.MAPHONG=2
select * from CHITIETPHIEUTHUEPHONG where MAPHIEUTHUE=3013

	SELECT  COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND PHIEUTHUEPHONG.TINHTRANG=0 and PHIEUTHUEPHONG.MAPHONG=6

	
select * from CHITIETHOADON

SELECT  COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND PHIEUTHUEPHONG.TINHTRANG=0 and PHIEUTHUEPHONG.MAPHONG=6

delete from CHITIETPHIEUTHUEPHONG where MAPHIEUTHUE=3012 and MAKHACHHANG =2002
 alter PROC USP_thanhToanHoaDon
 @mahd int, @trigia int
as 
BEGIN
	UPDATE HOADON SET THANHTIEN=@trigia, TINHTRANGHOADON=1 WHERE MAHOADON = @mahd
	UPDATE PHONG SET phong.TINHTRANG = 0 FROM PHONG INNER JOIN CHITIETHOADON ON (PHONG.MAPHONG = CHITIETHOADON.MAPHONG) WHERE (CHITIETHOADON.MAHOADON=@mahd)
	
	UPDATE PHIEUTHUEPHONG SET PHIEUTHUEPHONG.TINHTRANG=1
	FROM PHONG, CHITIETHOADON,PHIEUTHUEPHONG,HOADON
	WHERE PHONG.MAPHONG=PHIEUTHUEPHONG.MAPHONG AND PHONG.MAPHONG = CHITIETHOADON.MAPHONG AND CHITIETHOADON.MAHOADON=HOADON.MAHOADON AND (CHITIETHOADON.MAHOADON=@mahd) AND PHIEUTHUEPHONG.TINHTRANG=0

	DELETE FROM CHITIETHOADON WHERE MAHOADON=@mahd
END
GO

SELECT * FROM CHITIETPHIEUTHUEPHONG CT WHERE CT.MAPHIEUTHUE=3012


SELECT COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE AND PHIEUTHUEPHONG.TINHTRANG=0 AND PHIEUTHUEPHONG.MAPHONG=6 

CREATE PROC USP_laySoNguoiTrongPhong
@maphong int
AS 
BEGIN
	SELECT COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE AND PHIEUTHUEPHONG.TINHTRANG=0 AND PHIEUTHUEPHONG.MAPHONG=@maphong
END

create proc USP_kiemTraSoNguoiNuocNgoaiTrongPhong
@maphong int
AS 
BEGIN
	SELECT COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND KHACHHANG.MALOAIKHACHHANG =1
	AND PHIEUTHUEPHONG.TINHTRANG=0 AND PHIEUTHUEPHONG.MAPHONG=@maphong
END

USP_kiemTraSoNguoiNuocNgoaiTrongPhong 6

SELECT * FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND KHACHHANG.MALOAIKHACHHANG =1
	AND PHIEUTHUEPHONG.TINHTRANG=0

	update thamso set giatrithamso=0.25 where mathamso =2
	DROP TABLE THAMSO
	select * from thamso
	insert into thamso values(3,'SONGUOITOIDATRONGPHONG',3,N'SỐ NGƯỜI TỐI ĐA TRONG PHÒNG')

	delete from thamso where mathamso=3

CREATE TABLE THAMSO 
( 
	MATHAMSO INT PRIMARY KEY NOT NULL,
	TENTHAMSO VARCHAR(50) NOT NULL,
	GIATRITHAMSO FLOAT NOT NULL,
	GHICHU NVARCHAR(200) NOT NULL,	
)
 
drop TRIGGER UTG_CAPNHATTIENPHONG on CHITIETHOADON after update AS
BEGIN
	DECLARE @songuoitrongphong int
	SELECT @songuoitrongphong = COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND KHACHHANG.MALOAIKHACHHANG =1
	AND PHIEUTHUEPHONG.TINHTRANG=0 
	if (@songuoitrongphong > 0)
	begin
	update CHITIETHOADON set heso=1.5 
	end
end

GO

SELECT COUNT(*) FROM CHITIETPHIEUTHUEPHONG,PHIEUTHUEPHONG,KHACHHANG
	WHERE PHIEUTHUEPHONG.MAPHIEUTHUE=CHITIETPHIEUTHUEPHONG.MAPHIEUTHUE 
	AND CHITIETPHIEUTHUEPHONG.MAKHACHHANG=KHACHHANG.MAKHACHHANG
	AND KHACHHANG.MALOAIKHACHHANG =1
	AND PHIEUTHUEPHONG.TINHTRANG=0 

select * from CHITIETHOADON


select * from thamso
insert into thamso VALUES (2, 'HESO', 1.5 , N'HỆ SỐ'

select * from KHACHHANG

USP_InsertBill 2
delete from HOADON
select * from phong

select * from CHITIETPHIEUTHUEPHONG
3013 1 , 4 1003
select * from KHACHHANG
insert into PHIEUTHUEPHONG values(getdate(),2,0)

INSERT INTO CHITIETPHIEUTHUEPHONG VALUES (3013,1)
INSERT INTO CHITIETPHIEUTHUEPHONG VALUES (3013,4)
INSERT INTO CHITIETPHIEUTHUEPHONG VALUES (3013,1003)


select * from PHIEUTHUEPHONG

insert CHITIETPHIEUTHUEPHONG values (3014,4)

select * from CHITIETPHIEUTHUEPHONG

select * from KHACHHANG

select * from PHONG

update phong set TINHTRANG=1 where MAPHONG=6

SELECT CHITIETHOADON.MACHITIETHOADON AS'MÃ CHI TIẾT HÓA ĐƠN', CHITIETHOADON.MAHOADON AS'MÃ HÓA ĐƠN', PHONG.TENPHONG AS 'TÊN PHÒNG', CHITIETHOADON.SONGAY AS 'SỐ NGÀY', CHITIETHOADON.DONGIA AS'ĐƠN GIÁ', CHITIETHOADON.PHUTHU AS'PHỤ THU',  CHITIETHOADON.HESO AS 'HỆ SỐ',CHITIETHOADON.THANHTIEN AS 'THÀNH TIỀN'  
FROM PHONG,CHITIETHOADON,KHACHHANG,HOADON 
WHERE (KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG) AND (HOADON.MAHOADON=CHITIETHOADON.MAHOADON) AND (PHONG.MAPHONG=CHITIETHOADON.MAPHONG) AND (HOADON.TINHTRANGHOADON=0) AND KHACHHANG.MAKHACHHANG = 1