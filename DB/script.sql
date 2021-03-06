USE [master]
GO
/****** Object:  Database [SAD2018]    Script Date: 5/20/2018 4:35:49 PM ******/
CREATE DATABASE [SAD2018]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SAD2018', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SAD2018.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SAD2018_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SAD2018_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SAD2018] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SAD2018].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SAD2018] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SAD2018] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SAD2018] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SAD2018] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SAD2018] SET ARITHABORT OFF 
GO
ALTER DATABASE [SAD2018] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SAD2018] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SAD2018] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SAD2018] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SAD2018] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SAD2018] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SAD2018] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SAD2018] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SAD2018] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SAD2018] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SAD2018] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SAD2018] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SAD2018] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SAD2018] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SAD2018] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SAD2018] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SAD2018] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SAD2018] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SAD2018] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SAD2018] SET  MULTI_USER 
GO
ALTER DATABASE [SAD2018] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SAD2018] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SAD2018] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SAD2018] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SAD2018]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[cvu_id] [int] IDENTITY(1,1) NOT NULL,
	[cvu_ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[cvu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[contact]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact](
	[ct_ten] [nvarchar](50) NOT NULL,
	[ct_diachi] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_contact] PRIMARY KEY CLUSTERED 
(
	[ct_ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hopdonglaodong]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hopdonglaodong](
	[hdld_id] [int] IDENTITY(1,1) NOT NULL,
	[nv_id] [int] NOT NULL,
	[hdld_loai] [nvarchar](50) NOT NULL,
	[hdld_ngaybatdau] [date] NOT NULL,
	[hdld_ngayketthuc] [date] NOT NULL,
 CONSTRAINT [PK_hopdonglaodong] PRIMARY KEY CLUSTERED 
(
	[hdld_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[loai]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loai](
	[loai_id] [bit] NOT NULL,
	[loai_ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_loai] PRIMARY KEY CLUSTERED 
(
	[loai_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[luong]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[luong](
	[lg_bacluong] [int] IDENTITY(1,1) NOT NULL,
	[lg_luongcoban] [int] NOT NULL,
	[lg_hesoluong] [int] NOT NULL,
	[lg_hesophucap] [int] NOT NULL,
 CONSTRAINT [PK_luong] PRIMARY KEY CLUSTERED 
(
	[lg_bacluong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[nv_id] [int] IDENTITY(1,1) NOT NULL,
	[nv_ten] [nvarchar](50) NOT NULL,
	[nv_ngaysinh] [date] NULL,
	[nv_diachi] [nvarchar](100) NULL,
	[nv_sdt] [nchar](11) NULL,
	[nv_gioitinh] [bit] NOT NULL,
	[pb_id] [int] NOT NULL,
	[cvu_id] [int] NOT NULL,
	[tdhv_id] [int] NOT NULL,
	[lg_bacluong] [int] NOT NULL,
	[nv_tinhtrang] [nchar](10) NOT NULL,
	[tt_id] [int] NOT NULL,
	[loai] [bit] NOT NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[nv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieutuyendung]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieutuyendung](
	[ptd_id] [int] IDENTITY(1,1) NOT NULL,
	[ptd_ten] [nvarchar](100) NOT NULL,
	[ptd_ngaysinh] [date] NOT NULL,
	[ptd_sdt] [nchar](11) NULL,
	[ptd_gioitinh] [bit] NOT NULL,
	[ptd_chucvu] [nvarchar](50) NOT NULL,
	[ptd_email] [nvarchar](100) NOT NULL,
	[ttptd_id] [int] NOT NULL,
	[ptd_ngaydangphieu] [date] NOT NULL,
 CONSTRAINT [PK_phieutuyendung] PRIMARY KEY CLUSTERED 
(
	[ptd_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phongban]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongban](
	[pb_id] [int] IDENTITY(1,1) NOT NULL,
	[pb_ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_phongban] PRIMARY KEY CLUSTERED 
(
	[pb_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tinhtrang]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinhtrang](
	[tt_id] [int] IDENTITY(1,1) NOT NULL,
	[tt_ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tinhtrang] PRIMARY KEY CLUSTERED 
(
	[tt_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tinhtrangdottuyendung]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinhtrangdottuyendung](
	[tttd_id] [int] NOT NULL,
	[tttd_ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tinhtrangdottuyendung] PRIMARY KEY CLUSTERED 
(
	[tttd_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tinhtrangphieutuyendung]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinhtrangphieutuyendung](
	[ttptd_id] [int] NOT NULL,
	[ttptd_ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tinhtrangphieutuyendung] PRIMARY KEY CLUSTERED 
(
	[ttptd_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[trinhdohocvan]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trinhdohocvan](
	[tdhv_id] [int] IDENTITY(1,1) NOT NULL,
	[tdhv_ten] [nvarchar](50) NOT NULL,
	[tdhv_chuyennganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_trinhdohocvan] PRIMARY KEY CLUSTERED 
(
	[tdhv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tuyendung]    Script Date: 5/20/2018 4:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tuyendung](
	[td_id] [int] IDENTITY(1,1) NOT NULL,
	[td_ten] [nvarchar](300) NOT NULL,
	[td_noidung] [nvarchar](max) NOT NULL,
	[td_ngaybatdau] [date] NOT NULL,
	[td_ngayketthuc] [date] NOT NULL,
	[tttd_id] [int] NOT NULL,
 CONSTRAINT [PK_tuyendung] PRIMARY KEY CLUSTERED 
(
	[td_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[hopdonglaodong]  WITH CHECK ADD  CONSTRAINT [FK_hopdonglaodong_nhanvien] FOREIGN KEY([nv_id])
REFERENCES [dbo].[nhanvien] ([nv_id])
GO
ALTER TABLE [dbo].[hopdonglaodong] CHECK CONSTRAINT [FK_hopdonglaodong_nhanvien]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_chucvu] FOREIGN KEY([cvu_id])
REFERENCES [dbo].[chucvu] ([cvu_id])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_chucvu]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_loai] FOREIGN KEY([loai])
REFERENCES [dbo].[loai] ([loai_id])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_loai]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_luong] FOREIGN KEY([lg_bacluong])
REFERENCES [dbo].[luong] ([lg_bacluong])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_luong]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_phongban] FOREIGN KEY([pb_id])
REFERENCES [dbo].[phongban] ([pb_id])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_phongban]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_tinhtrang] FOREIGN KEY([tt_id])
REFERENCES [dbo].[tinhtrang] ([tt_id])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_tinhtrang]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_trinhdohocvan] FOREIGN KEY([tdhv_id])
REFERENCES [dbo].[trinhdohocvan] ([tdhv_id])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_trinhdohocvan]
GO
ALTER TABLE [dbo].[phieutuyendung]  WITH CHECK ADD  CONSTRAINT [FK_phieutuyendung_tinhtrangphieutuyendung] FOREIGN KEY([ttptd_id])
REFERENCES [dbo].[tinhtrangphieutuyendung] ([ttptd_id])
GO
ALTER TABLE [dbo].[phieutuyendung] CHECK CONSTRAINT [FK_phieutuyendung_tinhtrangphieutuyendung]
GO
ALTER TABLE [dbo].[tuyendung]  WITH CHECK ADD  CONSTRAINT [FK_tuyendung_tinhtrangdottuyendung] FOREIGN KEY([tttd_id])
REFERENCES [dbo].[tinhtrangdottuyendung] ([tttd_id])
GO
ALTER TABLE [dbo].[tuyendung] CHECK CONSTRAINT [FK_tuyendung_tinhtrangdottuyendung]
GO
USE [master]
GO
ALTER DATABASE [SAD2018] SET  READ_WRITE 
GO
