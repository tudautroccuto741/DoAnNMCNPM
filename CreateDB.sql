/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

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

USE [QLTV]
GO

/****** Object:  Table [dbo].[tblLoaiDocGia]    Script Date: 3/28/2018 8:02:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [int] NOT NULL,
	[tenloaidocgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLTV]
GO

/****** Object:  Table [dbo].[tblHocSinh]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblTheDocGia](
	[mathe] [nvarchar](8) NOT NULL,
	[maloaidocgia] [int] NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylapthe] [datetime2](7) NOT NULL,
	
 CONSTRAINT [PK_tblTheDocGia] PRIMARY KEY CLUSTERED 
(
	[mathe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLTV]
GO

INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(1,N'X')
GO
INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(2,N'Y')
GO





