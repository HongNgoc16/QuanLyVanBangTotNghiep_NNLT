USE [master]
GO
/****** Object:  Database [QuanLyVanBang]    Script Date: 3/27/2025 9:28:51 PM ******/
CREATE DATABASE [QuanLyVanBang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyVanBang', FILENAME = N'D:\Ngôn ngữ lập trình\Bài tập lớn\QuanLyVanBang.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 16384KB )
 LOG ON 
( NAME = N'QuanLyVanBang_log', FILENAME = N'D:\Ngôn ngữ lập trình\Bài tập lớn\QuanLyVanBang_log.ldf' , SIZE = 10240KB , MAXSIZE = 2048GB , FILEGROWTH = 16384KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyVanBang] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyVanBang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyVanBang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyVanBang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyVanBang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyVanBang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyVanBang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyVanBang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyVanBang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyVanBang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyVanBang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyVanBang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyVanBang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyVanBang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyVanBang] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyVanBang] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyVanBang]
GO
/****** Object:  Table [dbo].[dm_ChuyenNganh]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_ChuyenNganh](
	[Id_ChuyenNganh] [int] IDENTITY(1,1) NOT NULL,
	[Ma_ChuyenNganh] [nvarchar](50) NULL,
	[Ten_ChuyenNganh] [nvarchar](50) NULL,
	[Id_NganhHoc] [int] NULL,
	[Trang_Thai_Su_Dung] [bit] NULL,
 CONSTRAINT [PK_dm_ChuyenNganh] PRIMARY KEY CLUSTERED 
(
	[Id_ChuyenNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm_DonViQuanLy]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_DonViQuanLy](
	[Id_DonViQuanLy] [int] IDENTITY(1,1) NOT NULL,
	[Ma_DonViQuanLy] [nvarchar](10) NOT NULL,
	[Ten_DonViQuanLy] [nvarchar](30) NULL,
	[Ten_DonViQuanLy_Cha] [nvarchar](30) NULL,
	[Trang_Thai_Su_Dung] [bit] NULL,
 CONSTRAINT [PK_dm_DonViQuanLy] PRIMARY KEY CLUSTERED 
(
	[Id_DonViQuanLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm_KhoaHoc]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_KhoaHoc](
	[Id_KhoaHoc] [int] IDENTITY(1,1) NOT NULL,
	[Ma_KhoaHoc] [nvarchar](10) NULL,
	[Nam_Bat_Dau] [int] NULL,
	[Nam_Ket_Thuc] [int] NULL,
	[Trang_Thai] [bit] NULL,
 CONSTRAINT [PK_dm_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[Id_KhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm_NganhHoc]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_NganhHoc](
	[Id_NganhHoc] [int] IDENTITY(1,1) NOT NULL,
	[Ma_NganhHoc] [nvarchar](10) NULL,
	[Ten_Nganh] [nvarchar](30) NULL,
	[Trang_Thai_Su_Dung] [bit] NULL,
 CONSTRAINT [PK_dm_Nganh_Hoc] PRIMARY KEY CLUSTERED 
(
	[Id_NganhHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm_NguoiDung]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_NguoiDung](
	[Id_NguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[Ma_NguoiDung] [nvarchar](20) NOT NULL,
	[Ten_Dang_Nhap] [nvarchar](30) NOT NULL,
	[Mat_Khau] [varchar](50) NOT NULL,
	[Id_LoaiNguoiDung] [int] NOT NULL,
 CONSTRAINT [PK_dm_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[Id_NguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm_PhanQuyenNguoiDung]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_PhanQuyenNguoiDung](
	[Id_LoaiNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[Ma_LoaiNguoiDung] [nvarchar](10) NOT NULL,
	[Ten_LoaiNguoiDung] [nvarchar](50) NOT NULL,
	[Trang_Thai_Su_Dung] [bit] NOT NULL,
 CONSTRAINT [PK_dm_PhanQuyenNguoiDung] PRIMARY KEY CLUSTERED 
(
	[Id_LoaiNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm_SinhVien]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_SinhVien](
	[Id_SinhVien] [int] IDENTITY(1,1) NOT NULL,
	[Ma_SinhVien] [nvarchar](50) NULL,
	[Ho_Va_Ten] [nvarchar](50) NULL,
	[Gioi_Tinh] [bit] NULL,
	[Ngay_Sinh] [date] NULL,
	[Id_ChuyenNganh] [int] NULL,
	[Id_KhoaHoc] [int] NULL,
	[So_Dien_Thoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Diem_Trung_Binh_Tich_Luy] [decimal](4, 2) NULL,
	[Id_XepLoai] [int] NULL,
	[Id_DonViQuanLy] [int] NULL,
	[Trang_Thai] [bit] NULL,
 CONSTRAINT [PK_dm_SinhVien] PRIMARY KEY CLUSTERED 
(
	[Id_SinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm_XepLoai]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm_XepLoai](
	[Id_XepLoai] [int] IDENTITY(1,1) NOT NULL,
	[Ma_XepLoai] [nvarchar](10) NOT NULL,
	[Ten_XepLoai] [nvarchar](10) NOT NULL,
	[Diem_Toi_Thieu] [decimal](4, 2) NOT NULL,
	[Diem_Toi_Da] [decimal](4, 2) NOT NULL,
	[Trang_Thai_Su_Dung] [bit] NOT NULL,
 CONSTRAINT [PK_dm_XepLoai] PRIMARY KEY CLUSTERED 
(
	[Id_XepLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nv_DotCapBangTN]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nv_DotCapBangTN](
	[Id_Dot_Cap] [int] IDENTITY(1,1) NOT NULL,
	[Ten_Van_Bang] [nvarchar](50) NULL,
	[Ten_Dot_Cap] [nvarchar](50) NULL,
 CONSTRAINT [PK_nv_Dot_Cap_Bang_TN] PRIMARY KEY CLUSTERED 
(
	[Id_Dot_Cap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nv_VanBangTN]    Script Date: 3/27/2025 9:28:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nv_VanBangTN](
	[Id_VanBang] [int] IDENTITY(1,1) NOT NULL,
	[So_Hieu_Van_Bang] [nvarchar](50) NOT NULL,
	[Ma_SV] [nvarchar](50) NOT NULL,
	[Ho_Va_Ten] [nvarchar](50) NOT NULL,
	[Gioi_Tinh] [bit] NOT NULL,
	[Ngay_Sinh] [date] NOT NULL,
	[Noi_Sinh] [nvarchar](50) NOT NULL,
	[Nganh_Hoc] [nvarchar](50) NOT NULL,
	[Khoa_Hoc] [nvarchar](50) NOT NULL,
	[Ngay_Cap] [date] NOT NULL,
	[Xep_Loai_Tot_Nghiep] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_nv_VanBangTN] PRIMARY KEY CLUSTERED 
(
	[Id_VanBang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[dm_DonViQuanLy] ON 

INSERT [dbo].[dm_DonViQuanLy] ([Id_DonViQuanLy], [Ma_DonViQuanLy], [Ten_DonViQuanLy], [Ten_DonViQuanLy_Cha], [Trang_Thai_Su_Dung]) VALUES (1, N'MTA', N'Học viện Kỹ thuật Quân sự', N'Bộ Quốc phòng', 1)
SET IDENTITY_INSERT [dbo].[dm_DonViQuanLy] OFF
GO
SET IDENTITY_INSERT [dbo].[dm_KhoaHoc] ON 

INSERT [dbo].[dm_KhoaHoc] ([Id_KhoaHoc], [Ma_KhoaHoc], [Nam_Bat_Dau], [Nam_Ket_Thuc], [Trang_Thai]) VALUES (1, N'K53', 2017, 2022, 1)
INSERT [dbo].[dm_KhoaHoc] ([Id_KhoaHoc], [Ma_KhoaHoc], [Nam_Bat_Dau], [Nam_Ket_Thuc], [Trang_Thai]) VALUES (4, N'K54', 2018, 2023, 1)
INSERT [dbo].[dm_KhoaHoc] ([Id_KhoaHoc], [Ma_KhoaHoc], [Nam_Bat_Dau], [Nam_Ket_Thuc], [Trang_Thai]) VALUES (5, N'K55', 2019, 2024, 1)
INSERT [dbo].[dm_KhoaHoc] ([Id_KhoaHoc], [Ma_KhoaHoc], [Nam_Bat_Dau], [Nam_Ket_Thuc], [Trang_Thai]) VALUES (6, N'K56', 2020, 2025, 0)
SET IDENTITY_INSERT [dbo].[dm_KhoaHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[dm_NguoiDung] ON 

INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (1, N'QTV01', N'nguyenvana', N'Admin@123', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (2, N'QTV02', N'tranthib', N'Admin@456', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (3, N'QTV03', N'lequangc', N'Admin@789', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (4, N'QTV04', N'phamvand', N'Admin@321', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (5, N'QTV05', N'hoangthie', N'Admin@654', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (6, N'QTV06', N'buidinhf', N'Admin@987', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (7, N'QTV07', N'dinhnguyeng', N'Admin@111', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (8, N'QTV08', N'phanthih', N'Admin@222', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (9, N'QTV09', N'vuquangi', N'Admin@333', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (10, N'QTV10', N'dangthij', N'Admin@444', 1)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (11, N'QL01', N'truongvank', N'QL@123', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (12, N'QL02', N'duongthil', N'QL@456', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (13, N'QL03', N'nguyenminhm', N'QL@789', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (14, N'QL04', N'truonghuun', N'QL@321', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (15, N'QL05', N'doanvand', N'QL@654', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (16, N'QL06', N'lythanhp', N'QL@987', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (17, N'QL07', N'dangquangq', N'QL@111', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (18, N'QL08', N'caoanhr', N'QL@222', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (19, N'QL09', N'truonganhs', N'QL@333', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (20, N'QL10', N'maiquoct', N'QL@444', 2)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (21, N'D01', N'hoangminhx', N'Duyet@123', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (22, N'D02', N'lethihy', N'Duyet@456', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (23, N'D03', N'nguyenvietz', N'Duyet@789', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (24, N'D04', N'trankhanha', N'Duyet@321', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (25, N'D05', N'phanthanhb', N'Duyet@654', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (26, N'D06', N'dangquangc', N'Duyet@987', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (27, N'D07', N'caoxuanh', N'Duyet@111', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (28, N'D08', N'maianhk', N'Duyet@222', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (29, N'D09', N'nguyenchil', N'Duyet@333', 3)
INSERT [dbo].[dm_NguoiDung] ([Id_NguoiDung], [Ma_NguoiDung], [Ten_Dang_Nhap], [Mat_Khau], [Id_LoaiNguoiDung]) VALUES (30, N'D10', N'tranthanhm', N'Duyet@444', 3)
SET IDENTITY_INSERT [dbo].[dm_NguoiDung] OFF
GO
SET IDENTITY_INSERT [dbo].[dm_PhanQuyenNguoiDung] ON 

INSERT [dbo].[dm_PhanQuyenNguoiDung] ([Id_LoaiNguoiDung], [Ma_LoaiNguoiDung], [Ten_LoaiNguoiDung], [Trang_Thai_Su_Dung]) VALUES (1, N'QTV', N'Quản trị viên', 1)
INSERT [dbo].[dm_PhanQuyenNguoiDung] ([Id_LoaiNguoiDung], [Ma_LoaiNguoiDung], [Ten_LoaiNguoiDung], [Trang_Thai_Su_Dung]) VALUES (2, N'BPQL', N'Bộ phận quản lý', 1)
INSERT [dbo].[dm_PhanQuyenNguoiDung] ([Id_LoaiNguoiDung], [Ma_LoaiNguoiDung], [Ten_LoaiNguoiDung], [Trang_Thai_Su_Dung]) VALUES (3, N'BPD', N'Bộ phận duyệt', 1)
SET IDENTITY_INSERT [dbo].[dm_PhanQuyenNguoiDung] OFF
GO
ALTER TABLE [dbo].[dm_ChuyenNganh]  WITH CHECK ADD  CONSTRAINT [FK_dm_ChuyenNganh_dm_NganhHoc] FOREIGN KEY([Id_NganhHoc])
REFERENCES [dbo].[dm_NganhHoc] ([Id_NganhHoc])
GO
ALTER TABLE [dbo].[dm_ChuyenNganh] CHECK CONSTRAINT [FK_dm_ChuyenNganh_dm_NganhHoc]
GO
ALTER TABLE [dbo].[dm_NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_dm_NguoiDung_dm_PhanQuyenNguoiDung] FOREIGN KEY([Id_LoaiNguoiDung])
REFERENCES [dbo].[dm_PhanQuyenNguoiDung] ([Id_LoaiNguoiDung])
GO
ALTER TABLE [dbo].[dm_NguoiDung] CHECK CONSTRAINT [FK_dm_NguoiDung_dm_PhanQuyenNguoiDung]
GO
ALTER TABLE [dbo].[dm_SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_dm_SinhVien_dm_ChuyenNganh] FOREIGN KEY([Id_ChuyenNganh])
REFERENCES [dbo].[dm_ChuyenNganh] ([Id_ChuyenNganh])
GO
ALTER TABLE [dbo].[dm_SinhVien] CHECK CONSTRAINT [FK_dm_SinhVien_dm_ChuyenNganh]
GO
ALTER TABLE [dbo].[dm_SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_dm_SinhVien_dm_DonViQuanLy] FOREIGN KEY([Id_DonViQuanLy])
REFERENCES [dbo].[dm_DonViQuanLy] ([Id_DonViQuanLy])
GO
ALTER TABLE [dbo].[dm_SinhVien] CHECK CONSTRAINT [FK_dm_SinhVien_dm_DonViQuanLy]
GO
ALTER TABLE [dbo].[dm_SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_dm_SinhVien_dm_KhoaHoc] FOREIGN KEY([Id_KhoaHoc])
REFERENCES [dbo].[dm_KhoaHoc] ([Id_KhoaHoc])
GO
ALTER TABLE [dbo].[dm_SinhVien] CHECK CONSTRAINT [FK_dm_SinhVien_dm_KhoaHoc]
GO
ALTER TABLE [dbo].[dm_SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_dm_SinhVien_dm_XepLoai] FOREIGN KEY([Id_XepLoai])
REFERENCES [dbo].[dm_XepLoai] ([Id_XepLoai])
GO
ALTER TABLE [dbo].[dm_SinhVien] CHECK CONSTRAINT [FK_dm_SinhVien_dm_XepLoai]
GO
USE [master]
GO
ALTER DATABASE [QuanLyVanBang] SET  READ_WRITE 
GO
