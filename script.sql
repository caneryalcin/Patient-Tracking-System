USE [master]
GO
/****** Object:  Database [SOHATS]    Script Date: 1/2/2020 5:09:23 PM ******/
CREATE DATABASE [SOHATS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SOHATS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SOHATS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SOHATS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SOHATS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SOHATS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SOHATS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SOHATS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SOHATS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SOHATS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SOHATS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SOHATS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SOHATS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SOHATS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SOHATS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SOHATS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SOHATS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SOHATS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SOHATS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SOHATS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SOHATS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SOHATS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SOHATS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SOHATS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SOHATS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SOHATS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SOHATS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SOHATS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SOHATS] SET RECOVERY FULL 
GO
ALTER DATABASE [SOHATS] SET  MULTI_USER 
GO
ALTER DATABASE [SOHATS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SOHATS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SOHATS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SOHATS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SOHATS', N'ON'
GO
USE [SOHATS]
GO
/****** Object:  Table [dbo].[cikis]    Script Date: 1/2/2020 5:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cikis](
	[dosyano] [nvarchar](10) NOT NULL,
	[sevktarihi] [datetime] NULL,
	[cikissaati] [datetime] NULL,
	[odeme] [nvarchar](30) NULL,
	[toplamtutar] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hasta]    Script Date: 1/2/2020 5:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hasta](
	[tckimlikno] [nvarchar](11) NOT NULL,
	[dosyano] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](15) NULL,
	[soyad] [nvarchar](15) NULL,
	[dogumyeri] [nvarchar](15) NULL,
	[dogumtarihi] [datetime] NULL,
	[babaadi] [nvarchar](15) NULL,
	[anneadi] [nvarchar](15) NULL,
	[cinsiyet] [nvarchar](5) NULL,
	[kangrubu] [nvarchar](5) NULL,
	[medenihal] [nvarchar](5) NULL,
	[adres] [nvarchar](255) NULL,
	[tel] [nvarchar](11) NULL,
	[kurumsicilno] [nvarchar](10) NULL,
	[kurumadi] [nvarchar](50) NULL,
	[yakintel] [nvarchar](11) NULL,
	[yakinkurumsicilno] [nvarchar](10) NULL,
	[yakinkurumadi] [nvarchar](50) NULL,
 CONSTRAINT [PK_hasta] PRIMARY KEY CLUSTERED 
(
	[tckimlikno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[islem]    Script Date: 1/2/2020 5:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[islem](
	[islemAdi] [nvarchar](50) NULL,
	[birimFiyat] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 1/2/2020 5:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[kodu] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](20) NULL,
	[soyad] [nvarchar](20) NULL,
	[sifre] [nvarchar](20) NULL,
	[yetki] [bit] NULL,
	[evtel] [nvarchar](11) NULL,
	[ceptel] [nvarchar](11) NULL,
	[adres] [nvarchar](255) NULL,
	[unvan] [nvarchar](20) NULL,
	[isebaslama] [datetime] NULL,
	[maas] [nvarchar](20) NULL,
	[dogumyeri] [nvarchar](50) NULL,
	[annead] [nvarchar](20) NULL,
	[babaad] [nvarchar](20) NULL,
	[cinsiyet] [nvarchar](5) NULL,
	[kangrubu] [nvarchar](5) NULL,
	[medenihal] [nvarchar](10) NULL,
	[dogumtarihi] [datetime] NULL,
	[tckimlikno] [nvarchar](11) NULL,
	[username] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[polikinlik]    Script Date: 1/2/2020 5:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[polikinlik](
	[polikinlikadi] [nvarchar](50) NOT NULL,
	[durum] [bit] NULL,
	[aciklama] [nvarchar](255) NULL,
 CONSTRAINT [PK_polikinlik] PRIMARY KEY CLUSTERED 
(
	[polikinlikadi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sevk]    Script Date: 1/2/2020 5:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sevk](
	[sevktarihi] [nvarchar](50) NOT NULL,
	[dosyano] [nvarchar](50) NOT NULL,
	[polikinlik] [nvarchar](50) NULL,
	[saat] [nvarchar](50) NULL,
	[yapilanislem] [nvarchar](50) NULL,
	[drkod] [char](10) NULL,
	[miktar] [char](3) NULL,
	[birimfiyat] [nvarchar](20) NULL,
	[sıra] [int] NULL,
	[toplamtutar] [nvarchar](50) NULL,
	[taburcu] [bit] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'00001', CAST(N'2014-06-10T21:03:09.000' AS DateTime), CAST(N'2019-12-31T21:03:09.000' AS DateTime), N'Nakit', N'100')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'00001', CAST(N'2014-06-10T21:03:09.000' AS DateTime), CAST(N'2019-12-31T21:03:09.000' AS DateTime), N'Nakit', N'100')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'1', CAST(N'2019-12-11T22:48:22.000' AS DateTime), CAST(N'2019-12-25T22:48:22.000' AS DateTime), N'Senet', N'12')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'3', CAST(N'2019-12-11T22:48:22.000' AS DateTime), CAST(N'2019-12-11T22:48:22.000' AS DateTime), N'Senet', N'12')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'8', CAST(N'2019-11-20T23:00:04.000' AS DateTime), CAST(N'2019-11-27T23:00:04.000' AS DateTime), N'', N'')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'8', CAST(N'2019-11-23T23:00:04.000' AS DateTime), CAST(N'2019-11-27T23:00:04.000' AS DateTime), N'Nakit', N'')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'8', CAST(N'2019-11-27T23:00:04.000' AS DateTime), CAST(N'2019-11-27T23:00:04.000' AS DateTime), N'Nakit', N'5')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'5', CAST(N'2019-12-25T23:02:34.000' AS DateTime), CAST(N'2019-12-25T23:02:34.000' AS DateTime), N'', N'1')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'5', CAST(N'2019-11-27T23:04:03.000' AS DateTime), CAST(N'2019-11-28T23:04:03.000' AS DateTime), N'Kredi Karti - tek çekim', N'63')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'3', CAST(N'2015-07-15T23:09:24.000' AS DateTime), CAST(N'2019-12-02T23:09:24.000' AS DateTime), N'Çek', N'12')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'1', CAST(N'2019-12-15T00:00:00.000' AS DateTime), CAST(N'2019-12-15T00:00:00.000' AS DateTime), N'Kredi Karti - taksitli', N'1000')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'1', CAST(N'2019-12-15T00:00:00.000' AS DateTime), CAST(N'2019-12-11T22:48:22.000' AS DateTime), N'Kredi Karti - tek çekim', N'12')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'127', CAST(N'2019-12-28T14:07:06.000' AS DateTime), CAST(N'2019-12-28T14:07:06.000' AS DateTime), N'Nakit', N'150')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'127', CAST(N'2019-12-28T14:07:06.000' AS DateTime), CAST(N'2019-12-28T14:07:06.000' AS DateTime), N'Nakit', N'150')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'127', CAST(N'2019-12-28T14:07:06.000' AS DateTime), CAST(N'2019-12-28T14:07:06.000' AS DateTime), N'Nakit', N'150')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'127', CAST(N'2019-12-28T14:07:06.000' AS DateTime), CAST(N'2019-12-28T14:07:06.000' AS DateTime), N'Nakit', N'150')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'127', CAST(N'2019-12-28T14:07:06.000' AS DateTime), CAST(N'2019-12-28T14:07:06.000' AS DateTime), N'Nakit', N'150')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'128', CAST(N'2019-12-28T16:02:47.000' AS DateTime), CAST(N'2019-12-28T16:02:47.000' AS DateTime), N'Çek', N'12')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'1', CAST(N'2019-12-15T00:00:00.000' AS DateTime), CAST(N'2019-12-11T22:48:22.000' AS DateTime), N'Nakit', N'1212')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'1', CAST(N'2019-12-15T00:00:00.000' AS DateTime), CAST(N'2019-12-11T22:48:22.000' AS DateTime), N'Nakit', N'1221')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'1', CAST(N'2019-12-08T00:00:00.000' AS DateTime), CAST(N'2019-12-11T22:48:22.000' AS DateTime), N'Nakit', N'111111111')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'128', CAST(N'2019-12-27T00:00:00.000' AS DateTime), CAST(N'2019-12-27T20:57:27.000' AS DateTime), N'Nakit', N'12331')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'128', CAST(N'2019-12-27T00:00:00.000' AS DateTime), CAST(N'2019-12-27T20:57:27.000' AS DateTime), N'Nakit', N'12331')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'128', CAST(N'2019-12-28T16:02:47.000' AS DateTime), CAST(N'2019-12-28T16:02:47.000' AS DateTime), N'Nakit', N'123')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'128', CAST(N'2019-12-28T16:02:47.000' AS DateTime), CAST(N'2019-12-28T16:02:47.000' AS DateTime), N'Kredi Karti - tek çekim', N'12')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'129', CAST(N'2020-01-02T16:31:22.000' AS DateTime), CAST(N'2020-01-02T16:31:22.000' AS DateTime), N'Çek', N'10')
INSERT [dbo].[cikis] ([dosyano], [sevktarihi], [cikissaati], [odeme], [toplamtutar]) VALUES (N'123', CAST(N'2019-12-19T21:39:54.000' AS DateTime), CAST(N'2019-12-27T20:57:27.000' AS DateTime), N'Kredi Karti - taksitli', N'1000')
SET IDENTITY_INSERT [dbo].[hasta] ON 

INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'12111111111', 133, N'aaaaaaaaaaaaaaa', N'ASssaaaaaaaaaaa', N'SDASDA', CAST(N'2019-12-17T22:14:33.000' AS DateTime), N'asdas', N'sdasdasdsa', N'BAYAN', N'ABRh+', N'BEKAR', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'1212', 127, N'degil', N'caner', N'121', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'1212', N'1212', N'caner', N'', N'', N'121231', N'231', N'123', N'23', N'', N'', N'')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'123', 2, N'yeni', N'caner', N'121', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'1212', N'1212', N'caner', N'', N'', N'121231', N'231', N'123', N'23', N'', N'', N'')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'12301231923', 129, N'Büsraa', N'Kahraman', N'Kayseri', CAST(N'2019-12-17T22:14:33.000' AS DateTime), N'Ahmet', N'Sevgi', N'BAYAN', N'ABRh-', N'BEKAR', N'aslodkapsodko', N'06544984549', N'0654894789', N'aaaAaaaAaAAAA', N'06498748975', N'0564864897', N'AAaaasdasd')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'12312931092', 134, N'Kubra', N'Seher', N'AAAAAAAAAA', CAST(N'2019-12-09T16:53:00.000' AS DateTime), N'AAAA', N'aaaaaaaaa', N'BAYAN', N'ABRh+', N'EVLI', N'aaaaaaaaaaaaaa', N'12312312312', N'124124124', N'asdasd', N'12412', N'12', N'asda')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'4', 1, N'caner12', N'caner', N'asd', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'asd', N'asd', N'caner', N'ABRh+', N'EVLI', N'sd', N'asd', N'asdasd', N'kr', N'1', N'1', N'1')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'4444444', 126, N'caner', N'caner', N'asd', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'asd', N'asd', N'caner', N'ABRh+', N'EVLI', N'sd', N'asd', N'asdasd', N'kr', N'1', N'1', N'1')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'46582135081', 125, N'caner', N'caner', N'asd', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'asd', N'asd', N'caner', N'ABRh+', N'EVLI', N'sd', N'asd', N'asdasd', N'kr', N'1', N'1', N'1')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'46582135082', 124, N'caner', N'caner', N'asd', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'asd', N'asd', N'caner', N'ABRh+', N'EVLI', N'sd', N'asd', N'asdasd', N'kr', N'1', N'1', N'1')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'56415', 123, N'caner', N'caner', N'', CAST(N'2019-12-23T17:06:16.000' AS DateTime), N'', N'', N'BAY', N'ABRh+', N'BEKAR', N'', N'', N'', N'canerholding', N'', N'', N'')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'asd', 128, N'caner', N'caner', N'asdas', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'sd', N'sda', N'caner', N'', N'EVLI', N'da', N'dd', N'', N'', N'', N'', N'')
INSERT [dbo].[hasta] ([tckimlikno], [dosyano], [ad], [soyad], [dogumyeri], [dogumtarihi], [babaadi], [anneadi], [cinsiyet], [kangrubu], [medenihal], [adres], [tel], [kurumsicilno], [kurumadi], [yakintel], [yakinkurumsicilno], [yakinkurumadi]) VALUES (N'yeni', 3, N'degil', N'caner', N'121', CAST(N'2018-12-12T00:00:00.000' AS DateTime), N'1212', N'1212', N'caner', N'', N'', N'121231', N'231', N'123', N'23', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[hasta] OFF
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'yeni islem..', N'10')
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'muayene', N'50')
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'kan tahlili', N'15')
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'nöroloji tahlili', N'25')
INSERT [dbo].[islem] ([islemAdi], [birimFiyat]) VALUES (N'üroloji tahlili', N'45')
SET IDENTITY_INSERT [dbo].[kullanici] ON 

INSERT [dbo].[kullanici] ([kodu], [ad], [soyad], [sifre], [yetki], [evtel], [ceptel], [adres], [unvan], [isebaslama], [maas], [dogumyeri], [annead], [babaad], [cinsiyet], [kangrubu], [medenihal], [dogumtarihi], [tckimlikno], [username]) VALUES (1, N'Caner', N'Yalçin', N'12345', 1, N'', N'05370460652', N'360.cad 8/5 demetevler/ANKARA', N'Doktor', CAST(N'2020-01-01T22:20:14.000' AS DateTime), N'2500', N'eskisehir', N'Selvi', N'Mehmet', N'BAY', N'ABRh+', N'BEKAR', CAST(N'2019-12-25T10:40:02.000' AS DateTime), N'4658215082', N'caner')
INSERT [dbo].[kullanici] ([kodu], [ad], [soyad], [sifre], [yetki], [evtel], [ceptel], [adres], [unvan], [isebaslama], [maas], [dogumyeri], [annead], [babaad], [cinsiyet], [kangrubu], [medenihal], [dogumtarihi], [tckimlikno], [username]) VALUES (26, N'Ahmet', N'Yeser', N'12345', 1, N'', N'05165546515', N'345.cad 9/7 Sentepe/Ankara', N'Doktor', CAST(N'2020-01-01T22:20:29.000' AS DateTime), N'5000', N'Ankara', N'Selvi', N'Mehmet', N'', N'ABRh+', N'', CAST(N'1998-06-10T22:50:28.000' AS DateTime), N'41239349349', N'ahmet')
SET IDENTITY_INSERT [dbo].[kullanici] OFF
INSERT [dbo].[polikinlik] ([polikinlikadi], [durum], [aciklama]) VALUES (N'Polikinlik 2', 1, N'Su an müsait')
INSERT [dbo].[polikinlik] ([polikinlikadi], [durum], [aciklama]) VALUES (N'Polikinlik 3', 0, N'1212')
INSERT [dbo].[polikinlik] ([polikinlikadi], [durum], [aciklama]) VALUES (N'Polikinlik 4', 1, N'11')
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/27/2019', N'1', N'Polikinlik 1', N'1', N'1', N'1         ', N'1  ', N'1', 1, N'1', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 1', N'4:02 PM', N'muayene', N'1         ', N'1  ', N'50', 1, N'123', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/27/2019', N'', N'Polikinlik 2', N'12:00 AM', N'yeni islem..', N'          ', N'1  ', N'10', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019 12:00:00 AM', N'2', N'Polikinlik 1', NULL, NULL, NULL, NULL, NULL, 2, NULL, NULL)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019 12:00:00 AM', N'2', N'Polikinlik 1', NULL, NULL, NULL, NULL, NULL, 2, NULL, NULL)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 1', N'4:02 PM', N'yeni islem..', N'1         ', N'1  ', N'10', 1, N'123', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/27/2019', N'128', N'Polikinlik 1', N'12:00 AM', N'yeni islem..', N'26        ', N'1  ', N'10', 3, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 2', N'4:02 PM', N'muayene', N'1         ', N'1  ', N'50', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'1/1/2020', N'', N'Polikinlik 1', N'8:46 PM', N'yeni islem..', N'          ', N'1  ', N'10', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 1', N'4:02 PM', N'üroloji tahlili', N'          ', N'1  ', N'45', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 1', N'4:02 PM', N'üroloji tahlili', N'          ', N'1  ', N'45', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'1/2/2020', N'129', N'Polikinlik 1', N'4:31 PM', N'yeni islem..', N'26        ', N'1  ', N'10', 1, N'10', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 2', N'4:02 PM', N'muayene', N'1         ', N'1  ', N'50', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019 2:07:06 PM', N'127', N'Polikinlik 1', N'', N'muayene', N'          ', N'   ', N'50', 0, N'150', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019 2:07:06 PM', N'127', N'Polikinlik 1', N'', N'muayene', N'          ', N'   ', N'50', 0, N'150', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019 2:07:06 PM', N'127', N'Polikinlik 1', N'', N'muayene', N'          ', N'   ', N'50', 0, N'150', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019 2:07:06 PM', N'127', N'Polikinlik 1', N'', N'muayene', N'          ', N'   ', N'50', 0, N'150', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019 2:07:06 PM', N'127', N'Polikinlik 1', N'', N'muayene', N'          ', N'   ', N'50', 0, N'150', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 2', N'4:02 PM', N'yeni islem..', N'1         ', N'1  ', N'10', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 3', N'4:02 PM', N'muayene', N'1         ', N'1  ', N'50', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/15/2019', N'1', N'Polikinlik 1', N'00:00', N'muayene', N'1         ', N'1  ', N'50', 1, N'1221', 1)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/28/2019', N'128', N'Polikinlik 2', N'4:02 PM', N'yeni islem..', N'1         ', N'1  ', N'10', 1, N'', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/27/2019', N'128', N'Polikinlik 3', N'12:00 AM', N'yeni islem..', N'1         ', N'1  ', N'10', 1, N'200', 0)
INSERT [dbo].[sevk] ([sevktarihi], [dosyano], [polikinlik], [saat], [yapilanislem], [drkod], [miktar], [birimfiyat], [sıra], [toplamtutar], [taburcu]) VALUES (N'12/27/2019', N'128', N'Polikinlik 1', N'12:00 AM', N'muayene', N'1         ', N'2  ', N'50', 3, N'250', 0)
USE [master]
GO
ALTER DATABASE [SOHATS] SET  READ_WRITE 
GO
