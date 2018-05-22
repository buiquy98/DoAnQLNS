/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

--tạo database
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTV]
GO

--Tạo bảng tblDocGia
USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 05/06/18 12:46:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDocGia](
	[MaDocGia] [int] NOT NULL,
	[TenDocGia] [nvarchar](50) NULL,
	[NgaySinh] [datetime2](7) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NgayLapThe] [datetime2](7) NULL,
	[NgayHetHan] [datetime2](7) NULL,
	[MaLoaiDocGia] [int] NULL,
	[NguoiLap] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblDocGia]  WITH CHECK ADD  CONSTRAINT [FK_tblDocGia_tblLoaiDocGia] FOREIGN KEY([MaLoaiDocGia])
REFERENCES [dbo].[tblLoaiDocGia] ([MaLoaiDocGia])
GO

ALTER TABLE [dbo].[tblDocGia] CHECK CONSTRAINT [FK_tblDocGia_tblLoaiDocGia]
GO


--Insert vào bảng tblDocGia
USE [QLTV]
GO

INSERT INTO [dbo].[tblDocGia]
           ([MaDocGia]
           ,[TenDocGia]
           ,[NgaySinh]
           ,[DiaChi]
           ,[Email]
           ,[NgayLapThe]
           ,[NgayHetHan]
           ,[MaLoaiDocGia]
           ,[NguoiLap])
     VALUES
           ('18000000'
           ,N'Nguyễn Anh'
           ,convert(datetime,'01/01/1999 00:00:00',101)
           ,N'Quận 1'
           ,N'nguyenanh@gmail.com'
           ,convert(datetime,'02/02/2018 00:00:00',101)
           ,convert(datetime,'08/02/2018 00:00:00',101)
           ,'1'
           ,N'Nguyễn Thanh')
GO


--Tạo bảng tblLoaiDocGia
USE [QLTV]
GO

/****** Object:  Table [dbo].[tblLoaiDocGia]    Script Date: 05/06/18 12:56:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDocGia](
	[MaLoaiDocGia] [int] NOT NULL,
	[TenLoaiDocGia] [nchar](10) NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--insert bảng tblLoaiDocGia
USE [QLTV]
GO

INSERT INTO [dbo].[tblLoaiDocGia]
           ([MaLoaiDocGia]
           ,[TenLoaiDocGia])
     VALUES
           ('1'
           ,'X')
GO
INSERT INTO [dbo].[tblLoaiDocGia]
           ([MaLoaiDocGia]
           ,[TenLoaiDocGia])
     VALUES
           ('2'
           ,'Y')
GO


--tạo tblThamSo
--USE [QLTV]
--GO

--/****** Object:  Table [dbo].[tblThamSo]    Script Date: 05/06/18 1:00:33 PM ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--CREATE TABLE [dbo].[tblThamSo](
--	[MaThamSo] [int] NOT NULL,
--	[TuoiToiThieu] [int] NULL,
--	[TuoiToiDa] [int] NULL,
--	[ThoiGianSuDung] [int] NULL,
-- CONSTRAINT [PK_tblThamSo] PRIMARY KEY CLUSTERED 
--(
--	[MaThamSo] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO


--Insert tblThamSo
--USE [QLTV]
--GO

--INSERT INTO [dbo].[tblThamSo]
--           ([MaThamSo]
--           ,[TuoiToiThieu]
--           ,[TuoiToiDa]
--           ,[ThoiGianSuDung])
--     VALUES
--           ('1'
--           ,'18'
--           ,'55'
--           ,'6')
--GO


