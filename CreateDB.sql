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

/****** Object:  Table [dbo].[tblTheDocGia] Script Date: 3/28/2018 8:05:42 AM ******/
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

USE [QLTV]


GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblSach](
	[masach] [nvarchar](8) NOT NULL,
	[tensach] [nvarchar](50) NOT NULL,
	[matheloai] [nvarchar](8) NOT NULL,
	[matacgia] [nvarchar](8) NOT NULL,
	[namxuatban] [int] NOT NULL,
	[nhaxuatban] [nvarchar](50) NOT NULL,
	[ngaynhap] [datetime2](7) NOT NULL,
	[trigia] [int] NOT NULL,
	[tinhtrang] [int] NOT NULL,
	
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [QLTV]
GO

/****** Object:  Table [dbo].[tblTheLoaiSach]    Script Date: 3/28/2018 8:02:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTheLoaiSach](
	[matheloaisach] [int] NOT NULL,
	[tentheloaisach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[matheloaisach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLTV]
GO

INSERT INTO[dbo].[tblTheLoaiSach]([matheloaisach],[tentheloaisach]) VALUES(1,N'A')
GO
INSERT INTO[dbo].[tblTheLoaiSach]([matheloaisach],[tentheloaisach]) VALUES(2,N'B')
GO
INSERT INTO[dbo].[tblTheLoaiSach]([matheloaisach],[tentheloaisach]) VALUES(3,N'C')
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [int] NOT NULL,
	[tentacgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLTV]
GO

INSERT INTO[dbo].[tblTacGia]([matacgia],[tentacgia]) VALUES(1,N'Nguyễn Bá Tùng')
GO
INSERT INTO[dbo].[tblTacGia]([matacgia],[tentacgia]) VALUES(2,N'Nguyễn Lê Anh Tú')
GO
INSERT INTO[dbo].[tblTacGia]([matacgia],[tentacgia]) VALUES(3,N'Tú Cao Nguyên')
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblThamSo](
	[tuoitoida] [int] NOT NULL,
	[tuoitoithieu] [int] NOT NULL,
	[sotacgiatoida] [int] NOT NULL,
	[thoigiansudungthe] [int] NOT NULL,
	[sosachmuontoida] [int] NOT NULL,
	[ngaymuontoida] [int] NOT NULL,	
)
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblMuonSach](
	[mamuonsach] [nvarchar](8) NOT NULL,
	[ngaymuon] [int] NOT NULL,	
	[mathe] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblMuonSach] PRIMARY KEY CLUSTERED 
(
	[mamuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCTMuonSach](
	[mamuonsach] [nvarchar](8) NOT NULL,
	[masach] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblCTMuonSach] PRIMARY KEY CLUSTERED 
(
	[mamuonsach] ASC, [masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO