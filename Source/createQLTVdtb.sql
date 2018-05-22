/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

--tạo database
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTVien')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTVien') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTVien]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTVien]
GO

--Tạo bảng tblDocGia
USE [QLTVien]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 05/06/18 5:10:50 PM ******/
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
	[TenLoaiDocGia] [nchar](10) NULL,
	[NguoiLap] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




--Insert vào bảng tblDocGia
USE [QLTVien]
GO

INSERT INTO [dbo].[tblDocGia]
           ([MaDocGia]
           ,[TenDocGia]
           ,[NgaySinh]
           ,[DiaChi]
           ,[Email]
           ,[NgayLapThe]
           ,[NgayHetHan]
           ,[TenLoaiDocGia]
           ,[NguoiLap])
     VALUES
           ('1'
           ,N'Nguyễn Anh'
           ,convert(datetime,'01/01/1999 00:00:00',101)
           ,N'Quận 1'
           ,N'nguyenanh@gmail.com'
           ,convert(datetime,'02/02/2018 00:00:00',101)
           ,convert(datetime,'08/02/2018 00:00:00',101)
           ,'X'
           ,N'Nguyễn Thơ')
GO

