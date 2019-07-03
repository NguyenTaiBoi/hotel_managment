USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLKS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLKS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLKS]
END
GO

CREATE DATABASE [QLKS]
GO
USE [QLKS]
GO

/*table khach hang*/
CREATE TABLE KHACHHANG
(
	[maKH] [char](10) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[tuoi] [int] NOT NULL,
	[email] [char](50) NOT NULL,
	[cmnd] [int] NOT NULL,
	[sdt] [int] NOT NULL,
	[quoctich] [char](50) NOT NULL,
 CONSTRAINT [PK_maKH] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE KHACHHANG
ADD
	[gioitinh] [char] (4) NOT NULL;

	alter table KHACHHANG alter column cmnd char
	alter table KHACHHANG alter column sdt char
/*table Phong*/
CREATE TABLE PHONG
(
	[soPhong] [char] (10) NOT NULL,
	[loaiPhong] [varchar](50) NOT NULL,
	[giaPhong] [money] NOT NULL,
CONSTRAINT [PK_soPhong] PRIMARY KEY CLUSTERED 
(
	[soPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
alter table PHONG add moTa [varchar] (100)


insert into PHONG(soPhong,loaiPhong,giaPhong,moTa) 

values ('1','VIP','1000000','kec')


select @@VERSION
/*table Nhan Vien*/
CREATE TABLE NHANVIEN
(
	[maNV] [char] (10) NOT NULL,
	[hoten] [varchar] (50) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[sdt] [int] NOT NULL,
	[gioitinh] [char] (4) NOT NULL,
	[cmnd] [int] NOT NULL,
	[chucvu] [varchar] (50) NOT NULL,
CONSTRAINT [PK_maNV] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE NHANVIEN ADD [mkNV] [char](50)
alter table NHANVIEN alter column sdt char(12)
alter table NHANVIEN alter column cmnd char(50)
insert into NHANVIEN(maNV,hoten,ngaysinh,sdt,gioitinh,cmnd,chucvu,mkNV) 
values ('175','nguyen van a','1/1/2000','090090090','nam','52423423','Manager','175')
select *from NHANVIEN
/*table Dich Vu*/
CREATE TABLE DICHVU
(
	[maDV] [char] (10) NOT NULL,
	[tenDV] [varchar] (50) NOT NULL,
	[giaDV] [money] NOT NULL,
	[maNV] [char] (10) NOT NULL,
	CONSTRAINT [PK_maDV] PRIMARY KEY CLUSTERED 
(
	[maDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/* table Chi tiet phong*/
CREATE TABLE CHITIETPHONG
(
	[soPhong] [char](10) NOT NULL,
	[maKH] [char](10) NOT NULL,
	[thoigian] [time] NOT NULL,
CONSTRAINT [PK_maKH_soPhong] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC,
	[soPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/*table dat phong*/
CREATE TABLE DATPHONG
(
	[soPhong] [char] (10) NOT NULL,
	[maKH] [char] (10) NOT NULL,
	[ngaythue] [datetime] NOT NULL,
	[ngaytra] [datetime] NOT NULL,
	[soluongnguoi] [int] NOT NULL,
	[tienphong] [money] NOT NULL,
)
/*table loai phong*/
CREATE TABLE LOAIPHONG
(
	[loaiPhong] [varchar](50) NOT NULL,
	[sodichvu] [int]  NOT NULL,
	[maDV] [varchar] (50) NOT NULL,
	[phi] [money] NOT NULL,
CONSTRAINT [PK_loaiPhong] PRIMARY KEY CLUSTERED 
(
	[loaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

alter table LOAIPHONG drop column sodichvu
alter table LOAIPHONG drop column maDV

insert into LOAIPHONG(loaiPhong,phi)
values ('VIP','1000000')

insert into LOAIPHONG(loaiPhong,phi)
values ('Thuong','700000')
/* foreign key*/

--Reference: CHITIETPHONG_KHACHHANG (table: CHITIETPHONG)
ALTER TABLE CHITIETPHONG ADD CONSTRAINT CHITIETPHONG_KHACHHANG
    FOREIGN KEY (maKH)
    REFERENCES KHACHHANG (maKH);

--Reference: CHITIETPHONG_PHONG (table: CHITIETPHONG)
ALTER TABLE CHITIETPHONG ADD CONSTRAINT CHITIETPHONG_PHONG
    FOREIGN KEY (soPhong)
    REFERENCES PHONG (soPhong);

-- Reference: DATPHONG_KHACHHANG (table: DATPHONG)

ALTER TABLE DATPHONG ADD CONSTRAINT DATPHONG_KHACHHANG
    FOREIGN KEY (maKH)
    REFERENCES KHACHHANG (maKH);

-- Reference: DATPHONG_PHONG (table: DATPHONG)
ALTER TABLE DATPHONG ADD CONSTRAINT DATPHONG_PHONG
    FOREIGN KEY (soPhong)
    REFERENCES PHONG (soPhong);

-- Reference: PHONG_LOAIPHONG (table: PHONG)
ALTER TABLE PHONG ADD CONSTRAINT PHONG_LOAIPHONG
    FOREIGN KEY (loaiPhong)
    REFERENCES LOAIPHONG (loaiPhong);

-- Reference: DICHVU_NHANVIEN (table: DICHVU)
ALTER TABLE DICHVU ADD CONSTRAINT DICHVU_NHANVIEN
    FOREIGN KEY (maNV)
    REFERENCES NHANVIEN (maNV);

-- Reference: LOAIPHONG_DICHVU (table: LOAIPHONG)
ALTER TABLE DICHVU ADD CONSTRAINT LOAIPHONG_DICHVU
    FOREIGN KEY (maDV)
    REFERENCES DICHVU (maDV);
