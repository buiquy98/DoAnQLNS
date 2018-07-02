USE [master]
GO

/****** Object:  Database [QLNS]    Script Date: 02/07/2018 1:53:52 CH ******/
CREATE DATABASE [QLNS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.PERCY\MSSQL\DATA\QLNS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.PERCY\MSSQL\DATA\QLNS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [QLNS] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QLNS] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QLNS] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QLNS] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QLNS] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QLNS] SET ARITHABORT OFF 
GO

ALTER DATABASE [QLNS] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QLNS] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QLNS] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QLNS] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QLNS] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QLNS] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QLNS] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QLNS] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QLNS] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QLNS] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QLNS] SET RECOVERY FULL 
GO

ALTER DATABASE [QLNS] SET  MULTI_USER 
GO

ALTER DATABASE [QLNS] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QLNS] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QLNS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QLNS] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QLNS] SET QUERY_STORE = OFF
GO

USE [QLNS]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [QLNS] SET  READ_WRITE 
GO




--TblBaoCaoCongNo
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBaoCaoCongNo]    Script Date: 02/07/2018 1:54:43 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoCongNo](
	[maBaoCaoCongNo] [int] NOT NULL,
	[thang] [int] NOT NULL,
	[nam] [int] NULL,
 CONSTRAINT [PK_tblBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[maBaoCaoCongNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tblBaoCaoTon

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBaoCaoTon]    Script Date: 02/07/2018 1:55:08 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoTon](
	[maBaoCaoTon] [int] NOT NULL,
	[thang] [int] NOT NULL,
	[nam] [int] NOT NULL,
 CONSTRAINT [PK_tblBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[maBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tblChiTietBaoCaoCongNo
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietBaoCaoCongNo]    Script Date: 02/07/2018 1:55:28 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietBaoCaoCongNo](
	[maChiTietBaoCaoCongNo] [int] NOT NULL,
	[maKH] [int] NOT NULL,
	[maBaoCaoCongNo] [int] NOT NULL,
	[noDau] [text] NOT NULL,
	[noPhatSinh] [text] NOT NULL,
	[noCuoi] [text] NOT NULL,
 CONSTRAINT [PK_tblChiTietBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[maChiTietBaoCaoCongNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoCongNo]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoCongNo_tblBaoCaoCongNo] FOREIGN KEY([maBaoCaoCongNo])
REFERENCES [dbo].[tblBaoCaoCongNo] ([maBaoCaoCongNo])
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoCongNo] CHECK CONSTRAINT [FK_tblChiTietBaoCaoCongNo_tblBaoCaoCongNo]
GO


--tblChiTietBaoCaoTon

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietBaoCaoTon]    Script Date: 02/07/2018 1:56:04 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietBaoCaoTon](
	[maChiTietBaoCaoTon] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[maBaoCaoTon] [int] NOT NULL,
	[tonDau] [int] NOT NULL,
	[tonPhatSinh] [int] NOT NULL,
	[tonCuoi] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[maChiTietBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoTon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoTon_tblBaoCaoTon] FOREIGN KEY([maBaoCaoTon])
REFERENCES [dbo].[tblBaoCaoTon] ([maBaoCaoTon])
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoTon] CHECK CONSTRAINT [FK_tblChiTietBaoCaoTon_tblBaoCaoTon]
GO


--tblChiTietHoaDon

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietHoaDon]    Script Date: 02/07/2018 1:56:30 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietHoaDon](
	[maChiTietHoaDon] [int] NOT NULL,
	[maHoaDon] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[soLuongBan] [int] NOT NULL,
	[donGiaBan] [int] NOT NULL,
	[thanhTien] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[maChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tblChiTietPhieuNhap
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietPhieuNhap]    Script Date: 02/07/2018 1:57:35 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietPhieuNhap](
	[maChiTietPhieuNhap] [int] NOT NULL,
	[maPhieuNhap] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[soLuongNhap] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maChiTietPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tblHoaDon
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 02/07/2018 1:58:01 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblHoaDon](
	[maHoaDon] [int] NOT NULL,
	[ngayHoaDon] [datetime2](7) NOT NULL,
	[maKH] [int] NOT NULL,
	[tongGiaTriHD] [int] NOT NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tblKhachHang
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 02/07/2018 1:58:20 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKhachHang](
	[maKH] [int] NOT NULL,
	[hoTenKH] [nvarchar](50) NOT NULL,
	[tienNoKH] [text] NOT NULL,
	[diaChi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[sdt] [text] NOT NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


--tblLoaiNguoiDung

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblLoaiNguoiDung]    Script Date: 02/07/2018 1:58:37 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiNguoiDung](
	[maLoaiNguoiDung] [int] NOT NULL,
	[tenLoaiNguoiDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLoaiNguoiDung] PRIMARY KEY CLUSTERED 
(
	[maLoaiNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblLoaiNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_tblLoaiNguoiDung_tblLoaiNguoiDung] FOREIGN KEY([maLoaiNguoiDung])
REFERENCES [dbo].[tblLoaiNguoiDung] ([maLoaiNguoiDung])
GO

ALTER TABLE [dbo].[tblLoaiNguoiDung] CHECK CONSTRAINT [FK_tblLoaiNguoiDung_tblLoaiNguoiDung]
GO


--tblLoaiSach

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblLoaiSach]    Script Date: 02/07/2018 1:58:55 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiSach](
	[maLoaiSach] [int] NOT NULL,
	[tenLoaiSach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiSach] PRIMARY KEY CLUSTERED 
(
	[maLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tblNguoiDung
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblNguoiDung]    Script Date: 02/07/2018 1:59:30 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblNguoiDung](
	[maNguoiDung] [int] NOT NULL,
	[hoTenNguoiDung] [nvarchar](50) NULL,
	[tenDangNhap] [nvarchar](50) NOT NULL,
	[matKhau] [nvarchar](50) NOT NULL,
	[maLoaiNguoiDUng] [int] NOT NULL
) ON [PRIMARY]
GO


--tblPhieuNhap

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 02/07/2018 1:59:43 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuNhap](
	[maPhieuNhap] [int] NOT NULL,
	[ngayNhap] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tblPhieuThuTien

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuThuTien]    Script Date: 02/07/2018 2:00:12 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuThuTien](
	[maPhieuThu] [int] NOT NULL,
	[maKH] [int] NOT NULL,
	[ngayThuTien] [datetime2](7) NOT NULL,
	[soTienThu] [int] NOT NULL,
 CONSTRAINT [PK_tblPhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[maPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblPhieuThuTien]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuThuTien_tblKhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[tblKhachHang] ([maKH])
GO

ALTER TABLE [dbo].[tblPhieuThuTien] CHECK CONSTRAINT [FK_tblPhieuThuTien_tblKhachHang]
GO


--tblQuyDinh

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblQuyDinh]    Script Date: 02/07/2018 2:00:30 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblQuyDinh](
	[id] [int] NOT NULL,
	[luongNhapToiThieu] [int] NOT NULL,
	[luongTonToiDa] [int] NOT NULL,
	[tienNoToiDa] [int] NOT NULL,
	[luongTonToiThieu] [int] NOT NULL,
	[apDung] [int] NOT NULL,
 CONSTRAINT [PK_tblQuyDinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




--tblSach

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblSach]    Script Date: 02/07/2018 2:00:46 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSach](
	[maSach] [int] NOT NULL,
	[tenSach] [nvarchar](50) NOT NULL,
	[maLoaiSach] [int] NOT NULL,
	[tacGia] [nvarchar](50) NOT NULL,
	[soLuongTon] [nchar](10) NOT NULL,
	[donGia] [int] NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblLoaiSach] FOREIGN KEY([maLoaiSach])
REFERENCES [dbo].[tblLoaiSach] ([maLoaiSach])
GO

ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblLoaiSach]
GO


--Import data vào table

--tblBaoCaoCongNo
USE [QLNS]
GO

INSERT [dbo].[tblBaoCaoCongNo] ([maBaoCaoCongNo], [thang], [nam]) VALUES (1, 7, 2018)
INSERT [dbo].[tblBaoCaoTon] ([maBaoCaoTon], [thang], [nam]) VALUES (1, 7, 2018)
INSERT [dbo].[tblChiTietBaoCaoCongNo] ([maChiTietBaoCaoCongNo], [maKH], [maBaoCaoCongNo], [noDau], [noPhatSinh], [noCuoi]) VALUES (1, 4, 1, N'0', N'410000', N'0410000')
INSERT [dbo].[tblChiTietBaoCaoCongNo] ([maChiTietBaoCaoCongNo], [maKH], [maBaoCaoCongNo], [noDau], [noPhatSinh], [noCuoi]) VALUES (2, 2, 1, N'0', N'2952000', N'02952000')
INSERT [dbo].[tblChiTietBaoCaoCongNo] ([maChiTietBaoCaoCongNo], [maKH], [maBaoCaoCongNo], [noDau], [noPhatSinh], [noCuoi]) VALUES (3, 3, 1, N'0', N'3800000', N'3800000')
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (1, 13, 1, 50, 400, 450)
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (2, 10, 1, 100, 200, 300)
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (3, 16, 1, 15, 300, 315)
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (4, 7, 1, 230, 100, 480)
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (5, 12, 1, 50, 100, 150)
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (6, 19, 1, 50, 150, 200)
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (7, 26, 1, 50, 140, 190)
INSERT [dbo].[tblChiTietBaoCaoTon] ([maChiTietBaoCaoTon], [maSach], [maBaoCaoTon], [tonDau], [tonPhatSinh], [tonCuoi]) VALUES (8, 28, 1, 40, 150, 190)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (1, 2, 2, 5, 0, 700000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (2, 2, 3, 10, 0, 200000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (3, 2, 4, 15, 0, 705000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (4, 3, 2, 200, 0, 28000000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (5, 3, 3, 10, 0, 200000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (6, 4, 2, 10, 140000, 1400000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (7, 4, 4, 5, 47000, 235000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (8, 5, 4, 5, 47000, 235000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (9, 6, 4, 1, 47000, 47000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (10, 7, 2, 1, 140000, 140000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (11, 7, 5, 2, 48000, 96000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (12, 8, 16, 20, 150000, 3000000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (13, 10, 7, 50, 57000, 2850000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (14, 11, 12, 50, 45000, 2250000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (15, 12, 25, 1, 280000, 280000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (16, 13, 2, 1, 140000, 140000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (17, 14, 24, 1, 270000, 270000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (18, 15, 9, 1, 52000, 52000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (19, 16, 27, 1, 300000, 300000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (20, 17, 26, 10, 290000, 2900000)
INSERT [dbo].[tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien]) VALUES (21, 18, 28, 10, 350000, 3500000)
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (1, 1, 1, N'210       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (2, 1, 1, N'210       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (3, 1, 2, N'210       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (4, 1, 1, N'210       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (5, 1, 2, N'210       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (6, 2, 1, N'200       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (7, 2, 3, N'200       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (8, 4, 2, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (9, 5, 2, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (10, 7, 2, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (11, 8, 2, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (12, 10, 2, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (13, 11, 2, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (14, 12, 3, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (15, 13, 3, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (16, 14, 4, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (17, 15, 4, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (18, 16, 5, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (19, 17, 5, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (20, 18, 5, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (21, 19, 6, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (22, 19, 6, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (23, 22, 7, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (24, 23, 13, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (25, 24, 13, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (26, 13, 13, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (27, 10, 10, N'200       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (28, 16, 16, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (29, 16, 16, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (30, 7, 7, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (31, 12, 12, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (32, 19, 19, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (33, 26, 26, N'150       ')
INSERT [dbo].[tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [soLuongNhap]) VALUES (34, 28, 28, N'150       ')
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (1, CAST(N'2018-06-29T16:27:08.0100000' AS DateTime2), 2, 1605000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (2, CAST(N'2018-06-29T16:31:17.8933333' AS DateTime2), 2, 1605000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (3, CAST(N'2018-06-29T16:33:33.2933333' AS DateTime2), 1, 28200000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (4, CAST(N'2018-06-29T16:41:06.2700000' AS DateTime2), 2, 1635000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (5, CAST(N'2018-06-29T16:44:55.0033333' AS DateTime2), 2, 235000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (6, CAST(N'2018-07-01T13:07:41.0400000' AS DateTime2), 1, 47000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (7, CAST(N'2018-07-01T17:02:32.5133333' AS DateTime2), 1, 236000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (8, CAST(N'2018-07-01T21:10:43.4166667' AS DateTime2), 1, 3000000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (9, CAST(N'2018-07-01T21:13:14.1033333' AS DateTime2), 2, 7500000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (10, CAST(N'2018-07-01T21:16:45.9466667' AS DateTime2), 3, 2850000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (11, CAST(N'2018-07-01T21:39:16.3433333' AS DateTime2), 1, 2250000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (12, CAST(N'2018-07-01T23:03:14.6700000' AS DateTime2), 1, 280000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (13, CAST(N'2018-07-02T06:58:55.2000000' AS DateTime2), 4, 140000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (14, CAST(N'2018-07-02T07:35:13.3833333' AS DateTime2), 4, 270000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (15, CAST(N'2018-07-02T07:36:18.2166667' AS DateTime2), 2, 52000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (16, CAST(N'2018-07-02T07:38:57.8333333' AS DateTime2), 3, 300000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (17, CAST(N'2018-07-02T07:48:39.0766667' AS DateTime2), 2, 2900000)
INSERT [dbo].[tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD]) VALUES (18, CAST(N'2018-07-02T07:55:18.8066667' AS DateTime2), 3, 3500000)
INSERT [dbo].[tblKhachHang] ([maKH], [hoTenKH], [tienNoKH], [diaChi], [email], [sdt]) VALUES (1, N'Nguyễn Văn A', N'280000', N'Ngã năm', N'abc@gmail.com', N'0123456789')
INSERT [dbo].[tblKhachHang] ([maKH], [hoTenKH], [tienNoKH], [diaChi], [email], [sdt]) VALUES (2, N'Nguyễn Văn Save', N'2900000', N'Sóc trăng', N'abdc@gmail.com', N'0152362123')
INSERT [dbo].[tblKhachHang] ([maKH], [hoTenKH], [tienNoKH], [diaChi], [email], [sdt]) VALUES (3, N'Nguyễn Văn Tèo', N'3500000', N'Việt Nam', N'teo@gmail.com', N'0123456778')
INSERT [dbo].[tblKhachHang] ([maKH], [hoTenKH], [tienNoKH], [diaChi], [email], [sdt]) VALUES (4, N'Nguyễn Quang Hạ', N'280000', N'nơi nào đó', N'nguoinaodo@gmail.com', N'01236793456')
INSERT [dbo].[tblLoaiNguoiDung] ([maLoaiNguoiDung], [tenLoaiNguoiDung]) VALUES (1, N'admin')
INSERT [dbo].[tblLoaiNguoiDung] ([maLoaiNguoiDung], [tenLoaiNguoiDung]) VALUES (2, N'Khách')
INSERT [dbo].[tblLoaiNguoiDung] ([maLoaiNguoiDung], [tenLoaiNguoiDung]) VALUES (3, N'Quản trị hệ thống')
INSERT [dbo].[tblLoaiNguoiDung] ([maLoaiNguoiDung], [tenLoaiNguoiDung]) VALUES (4, N'Giám đốc')
INSERT [dbo].[tblLoaiNguoiDung] ([maLoaiNguoiDung], [tenLoaiNguoiDung]) VALUES (5, N'Nhân Viên')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (1, N'Nhảm nhí')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (4, N'Truyện tranh')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (5, N'Sách giáo khoa')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (6, N'Kỹ năng sống')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (7, N'Manga')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (8, N'Tiểu thuyết')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (10, N'truyện ngắn')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (11, N'Tôn giáo')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (12, N'Sách tham khảo')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (13, N'Sách tham khảo')
INSERT [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach]) VALUES (14, N'Nghệ thuật')
INSERT [dbo].[tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau], [maLoaiNguoiDUng]) VALUES (1, N'Nguyễn Huỳnh Sáng', N'admin', N'sang', 1)
INSERT [dbo].[tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau], [maLoaiNguoiDUng]) VALUES (2, N'Bùi Đang Huy', N'percy', N'quy', 1)
INSERT [dbo].[tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau], [maLoaiNguoiDUng]) VALUES (3, N'Khách', N'guest', N'guest', 2)
INSERT [dbo].[tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau], [maLoaiNguoiDUng]) VALUES (4, N'Giám Đốc', N'Sang', N'sang', 4)
INSERT [dbo].[tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau], [maLoaiNguoiDUng]) VALUES (5, N'Nhân viên', N'quy', N'123', 5)
INSERT [dbo].[tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau], [maLoaiNguoiDUng]) VALUES (6, N'Nguyễn Văn A', N'nhanvien1', N'123456', 5)
INSERT [dbo].[tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau], [maLoaiNguoiDUng]) VALUES (7, N'ád', N'sds', N'ád', 2)
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (1, CAST(N'2018-06-27T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (2, CAST(N'2018-06-28T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (3, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (4, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (5, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (6, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (7, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (8, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (9, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (10, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (11, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (12, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (13, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (14, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (15, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (16, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (17, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (18, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (19, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (20, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (21, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (22, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (23, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (24, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (25, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (26, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (27, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (28, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (29, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (30, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (31, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) VALUES (32, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (1, 3, CAST(N'2018-06-28T00:00:00.0000000' AS DateTime2), 10000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (2, 3, CAST(N'2018-06-28T00:00:00.0000000' AS DateTime2), 2000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (3, 4, CAST(N'2018-06-28T00:00:00.0000000' AS DateTime2), 20000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (4, 3, CAST(N'2018-06-28T00:00:00.0000000' AS DateTime2), 20000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (5, 2, CAST(N'2018-06-28T00:00:00.0000000' AS DateTime2), 10000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (6, 1, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2), 47000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (7, 1, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2), 236000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (8, 1, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2), 3000000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (9, 1, CAST(N'2018-07-01T00:00:00.0000000' AS DateTime2), 2250000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (10, 4, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), 40000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (11, 3, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), 2870000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (12, 2, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), 7501000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (13, 4, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), 130000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (14, 2, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), 52000)
INSERT [dbo].[tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu]) VALUES (15, 3, CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), 300000)
INSERT [dbo].[tblQuyDinh] ([id], [luongNhapToiThieu], [luongTonToiDa], [tienNoToiDa], [luongTonToiThieu], [apDung]) VALUES (1, 150, 300, 20000, 20, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (2, N'Daraemon', 4, N'Fujiko Fujio', N'983       ', 140000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (3, N'Conan', 4, N'Gosho Aoyama', N'380       ', 20000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (4, N'Nhà giả kim', 6, N'Paulo Coelho', N'324       ', 47000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (5, N'Ngày xưa có một con bò', 6, N'Camilo Cruz', N'498       ', 48000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (6, N'Ngoại Tình', 6, N'Paulo Coelho', N'190       ', 63000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (7, N'Eleven Minutes', 6, N'Paulo Coelho', N'330       ', 57000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (8, N'5 Centimet Trên Giây', 8, N'Shinkai Makoto', N'100       ', 40000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (9, N'Tuổi Trẻ Đáng Giá Bao Nhiêu', 6, N'Rosie Nguyễn', N'99        ', 52000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (10, N'Đắc Nhân Tâm', 6, N'Dale Carnegie', N'300       ', 57000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (11, N'Quẳng Gánh Lo Đi Và Vui Sống', 6, N'Dale Carnegie', N'100       ', 57000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (12, N'Thuật Hùng Biện', 6, N'Dale Carnegie', N'150       ', 45000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (13, N'Thay Đổi Để Thành Công', 6, N'Dale Carnegie', N'650       ', 108000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (14, N'Tony Buổi Sáng trên Đường Băng', 6, N'Tony Buổi Sáng', N'150       ', 60000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (15, N'Cà phê cùng Tony', 6, N'Tony Buổi Sáng', N'150       ', 60000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (16, N'Nguồn Cội', 11, N'Dan Brown', N'245       ', 150000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (17, N'Bộ sách giáo khoa lớp 1', 5, N'Bộ giáo dục', N'50        ', 150000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (18, N'Bộ sách giáo khoa lớp 2', 5, N'Bộ giáo dục', N'50        ', 170000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (19, N'Bộ sách giáo khoa lớp 3', 5, N'Bộ giáo dục', N'200       ', 180000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (20, N'Bộ sách giáo khoa lớp 4', 5, N'Bộ giáo dục', N'50        ', 200000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (21, N'Bộ sách giáo khoa lớp 5', 5, N'Bộ giáo dục', N'50        ', 220000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (22, N'Bộ sách giáo khoa lớp 6', 5, N'Bộ giáo dục', N'50        ', 250000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (23, N'Bộ sách giáo khoa lớp 7', 5, N'Bộ giáo dục', N'50        ', 260000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (24, N'Bộ sách giáo khoa lớp 8', 5, N'Bộ giáo dục', N'49        ', 270000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (25, N'Bộ sách giáo khoa lớp 9', 5, N'Bộ giáo dục', N'49        ', 280000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (26, N'Bộ sách giáo khoa lớp 10', 5, N'Bộ giáo dục', N'190       ', 290000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (27, N'Bộ sách giáo khoa lớp 11', 5, N'Bộ giáo dục', N'49        ', 300000)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [soLuongTon], [donGia]) VALUES (28, N'Bộ sách giáo khoa lớp 12', 5, N'Bộ giáo dục', N'190       ', 350000)



