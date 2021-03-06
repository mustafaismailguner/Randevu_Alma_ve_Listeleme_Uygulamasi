USE [master]
GO
/****** Object:  Database [Koru_Sigorta_Randevu_DB]    Script Date: 12.07.2021 13:46:09 ******/
CREATE DATABASE [Koru_Sigorta_Randevu_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Koru_Sigorta_Randevu_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Koru_Sigorta_Randevu_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Koru_Sigorta_Randevu_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Koru_Sigorta_Randevu_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Koru_Sigorta_Randevu_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET QUERY_STORE = OFF
GO
USE [Koru_Sigorta_Randevu_DB]
GO
/****** Object:  Table [dbo].[Koru_Sigorta_Randevu_Bilgileri]    Script Date: 12.07.2021 13:46:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Koru_Sigorta_Randevu_Bilgileri](
	[musteri_id] [int] IDENTITY(1,1) NOT NULL,
	[musteri_ad] [nvarchar](50) NOT NULL,
	[musteri_soyad] [nvarchar](50) NOT NULL,
	[musteri_telefon_numarasi] [nchar](11) NOT NULL,
	[musteri_il] [nvarchar](50) NOT NULL,
	[musteri_ilce] [nvarchar](50) NOT NULL,
	[musteri_tc_kimlik_numarasi] [bigint] NOT NULL,
	[musteri_police_numarasi] [bigint] NOT NULL,
	[musteri_randevu_tarihi] [date] NOT NULL,
 CONSTRAINT [PK__Koru_Sig__966D46E210119D5D] PRIMARY KEY CLUSTERED 
(
	[musteri_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ON 

INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (1, N'Mustafa İsmail', N'Güner', N'05074420023', N'Trabzon', N'Of', 49564236784, 12345678, CAST(N'2022-01-26' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (2, N'Mehmet', N'Aydın', N'05074420029', N'İstanbul', N'Üsküdar', 12345678999, 49564236899, CAST(N'2021-07-09' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (3, N'Halil', N'Göker', N'05074420037', N'İstanbul', N'Ataşehir', 12345678994, 12345678994, CAST(N'2021-07-10' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (4, N'İbrahim', N'Tekin', N'05074420158', N'İstanbul', N'Üsküdar', 12345678, 12345678995, CAST(N'2021-07-21' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (5, N'Cenk', N'Çelik', N'05074420026', N'İstanbul', N'Kadıköy', 12345678, 12345611782, CAST(N'2021-07-17' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (6, N'Mustafa', N'Gezgin', N'05074420055', N'İstanbul', N'Beykoz', 12345678, 11111111111, CAST(N'2021-07-16' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (7, N'Mesut', N'Çelik', N'05074420033', N'İstanbul', N'Beykoz', 12345678996, 123456789, CAST(N'2021-09-29' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (8, N'Serdar', N'Örnek', N'05074420033', N'İstanbul', N'Kartal', 49564236784, 12345678, CAST(N'2021-08-25' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (23, N'Mehmet', N'Işık', N'05074425588', N'İstanbul', N'Maltepe', 12345678, 49564236784, CAST(N'2021-07-13' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (24, N'Murat', N'Fener', N'05074426633', N'İstanbul', N'Ataşehir', 49564236784, 87654321, CAST(N'2021-07-23' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (25, N'Mehmet', N'Kurgun', N'05074421144', N'İstanbul', N'Üsküdar', 49564236784, 87654321, CAST(N'2021-07-14' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (26, N'Fatih', N'Şahin', N'05074429966', N'İstanbul', N'Kartal', 49564236784, 1346, CAST(N'2021-07-21' AS Date))
INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_telefon_numarasi], [musteri_il], [musteri_ilce], [musteri_tc_kimlik_numarasi], [musteri_police_numarasi], [musteri_randevu_tarihi]) VALUES (27, N'Mert', N'Kaya', N'05074424562', N'İstanbul', N'Tuzla', 49564236784, 12345678, CAST(N'2021-07-21' AS Date))
SET IDENTITY_INSERT [dbo].[Koru_Sigorta_Randevu_Bilgileri] OFF
GO
USE [master]
GO
ALTER DATABASE [Koru_Sigorta_Randevu_DB] SET  READ_WRITE 
GO
