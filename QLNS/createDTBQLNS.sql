/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

--tạo database
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLNS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNS]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLNS]
GO

--tạo bảng tblPhieuNhap
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPHIEUNHAP]    Script Date: 05/29/18 10:34:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPHIEUNHAP](
	[maphieunhap] [int] NOT NULL,
	[ngaynhap] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_tblPHIEUNHAP_tblPHIEUNHAP1] FOREIGN KEY([maphieunhap])
REFERENCES [dbo].[tblPHIEUNHAP] ([maphieunhap])
GO

ALTER TABLE [dbo].[tblPHIEUNHAP] CHECK CONSTRAINT [FK_tblPHIEUNHAP_tblPHIEUNHAP1]
GO


--tạo bảng tblChiTietPhieuNhap
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblCHITIETPHIEUNHAP]    Script Date: 05/29/18 10:35:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCHITIETPHIEUNHAP](
	[machitietphieunhap] [int] NOT NULL,
	[maphieunhap] [int] NOT NULL,
	[soluongnhap] [int] NULL,
	[masach] [int] NULL,
 CONSTRAINT [PK_tblCHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[machitietphieunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_tblCHITIETPHIEUNHAP_tblPHIEUNHAP] FOREIGN KEY([maphieunhap])
REFERENCES [dbo].[tblPHIEUNHAP] ([maphieunhap])
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_tblCHITIETPHIEUNHAP_tblPHIEUNHAP]
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_tblCHITIETPHIEUNHAP_tblSACH] FOREIGN KEY([masach])
REFERENCES [dbo].[tblSACH] ([masach])
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_tblCHITIETPHIEUNHAP_tblSACH]
GO


--tạo bảng tblSach
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblSACH]    Script Date: 05/29/18 10:35:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSACH](
	[masach] [int] NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[theloai] [nvarchar](50) NULL,
	[tacgia] [nvarchar](50) NULL,
	[dongia] [int] NULL,
	[soluongton] [int] NULL,
 CONSTRAINT [PK_tblSACH] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tạo bảng tblChiTietPhieuHoaDon
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblCHITIETPHIEUHOADON]    Script Date: 05/29/18 10:36:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCHITIETPHIEUHOADON](
	[machitietphieuhoadon] [int] NOT NULL,
	[maphieuhoadon] [int] NULL,
	[soluongban] [int] NULL,
	[masach] [int] NULL,
 CONSTRAINT [PK_tblCHITIETPHIEUHOADON] PRIMARY KEY CLUSTERED 
(
	[machitietphieuhoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUHOADON]  WITH CHECK ADD  CONSTRAINT [FK_tblCHITIETPHIEUHOADON_tblPHIEUHOADON] FOREIGN KEY([maphieuhoadon])
REFERENCES [dbo].[tblPHIEUHOADON] ([maphieuhoadon])
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUHOADON] CHECK CONSTRAINT [FK_tblCHITIETPHIEUHOADON_tblPHIEUHOADON]
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUHOADON]  WITH CHECK ADD  CONSTRAINT [FK_tblCHITIETPHIEUHOADON_tblSACH] FOREIGN KEY([masach])
REFERENCES [dbo].[tblSACH] ([masach])
GO

ALTER TABLE [dbo].[tblCHITIETPHIEUHOADON] CHECK CONSTRAINT [FK_tblCHITIETPHIEUHOADON_tblSACH]
GO


--tạo bảng tblPhieuThuTien
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPHIEUTHUTIEN]    Script Date: 05/29/18 10:37:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPHIEUTHUTIEN](
	[maphieuthu] [int] NOT NULL,
	[makhachhang] [int] NULL,
	[sotienthu] [int] NULL,
 CONSTRAINT [PK_tblPHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[maphieuthu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--tạo bảng tblPhieuHoaDon
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPHIEUHOADON]    Script Date: 05/29/18 10:37:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPHIEUHOADON](
	[maphieuhoadon] [int] NOT NULL,
	[ngaylaphoadon] [datetime2](7) NULL,
	[makhachhang] [int] NOT NULL,
 CONSTRAINT [PK_tblPHIEUHOADON] PRIMARY KEY CLUSTERED 
(
	[maphieuhoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblPHIEUHOADON]  WITH CHECK ADD  CONSTRAINT [FK_tblPHIEUHOADON_tblKHACHHANG] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[tblKHACHHANG] ([makhachhang])
GO

ALTER TABLE [dbo].[tblPHIEUHOADON] CHECK CONSTRAINT [FK_tblPHIEUHOADON_tblKHACHHANG]
GO


--tạo bảng tblKhachHang
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblKHACHHANG]    Script Date: 05/29/18 10:37:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKHACHHANG](
	[makhachhang] [int] NOT NULL,
	[hotenkhachhang] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sotienno] [int] NULL,
 CONSTRAINT [PK_tblKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblKHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_tblKHACHHANG_tblKHACHHANG] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[tblKHACHHANG] ([makhachhang])
GO

ALTER TABLE [dbo].[tblKHACHHANG] CHECK CONSTRAINT [FK_tblKHACHHANG_tblKHACHHANG]
GO

ALTER TABLE [dbo].[tblKHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_tblKHACHHANG_tblKHACHHANG1] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[tblKHACHHANG] ([makhachhang])
GO

ALTER TABLE [dbo].[tblKHACHHANG] CHECK CONSTRAINT [FK_tblKHACHHANG_tblKHACHHANG1]
GO


--tạo bảng tblBaoCaoCongNo
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBAOCAONOCONG]    Script Date: 05/29/18 10:38:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBAOCAONOCONG](
	[machitietcongno] [int] NOT NULL,
	[thang] [datetime2](7) NULL,
	[makhachhang] [int] NOT NULL,
	[nodau] [int] NULL,
	[nophatsinh] [int] NULL,
	[nocuoi] [int] NULL,
 CONSTRAINT [PK_tblBAOCAONOCONG] PRIMARY KEY CLUSTERED 
(
	[machitietcongno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblBAOCAONOCONG]  WITH CHECK ADD  CONSTRAINT [FK_tblBAOCAONOCONG_tblKHACHHANG] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[tblKHACHHANG] ([makhachhang])
GO

ALTER TABLE [dbo].[tblBAOCAONOCONG] CHECK CONSTRAINT [FK_tblBAOCAONOCONG_tblKHACHHANG]
GO


--tbl tạo bảng tblBaoCaoTon
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBAOCAOTON]    Script Date: 05/29/18 10:39:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBAOCAOTON](
	[machitietton] [int] NOT NULL,
	[thang] [datetime2](7) NULL,
	[masach] [int] NULL,
	[tondau] [int] NULL,
	[tonphatsinh] [int] NULL,
	[toncuoi] [int] NULL,
 CONSTRAINT [PK_tblBAOCAOTON] PRIMARY KEY CLUSTERED 
(
	[machitietton] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblBAOCAOTON]  WITH CHECK ADD  CONSTRAINT [FK_tblBAOCAOTON_tblSACH] FOREIGN KEY([masach])
REFERENCES [dbo].[tblSACH] ([masach])
GO

ALTER TABLE [dbo].[tblBAOCAOTON] CHECK CONSTRAINT [FK_tblBAOCAOTON_tblSACH]
GO


--tạo bảng tblThamSo
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblTHAMSO]    Script Date: 05/29/18 10:39:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTHAMSO](
	[soluongnhapitnhat] [int] NULL,
	[soluongtontoidatruocnhap] [int] NULL,
	[sotiennotoida] [int] NULL,
	[soluongtonsautoithieu] [int] NULL,
	[sudungquydinh4] [bit] NULL
) ON [PRIMARY]
GO


