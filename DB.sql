USE [master]
GO
/****** Object:  Database [OgrenciBilgiSistemi]    Script Date: 26.12.2016 02:25:34 ******/
CREATE DATABASE [OgrenciBilgiSistemi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OgrenciBilgiSistemi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OgrenciBilgiSistemi.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OgrenciBilgiSistemi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OgrenciBilgiSistemi_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OgrenciBilgiSistemi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET ARITHABORT OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET RECOVERY FULL 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET  MULTI_USER 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [OgrenciBilgiSistemi]
GO
/****** Object:  Table [dbo].[AkademikBirimler]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AkademikBirimler](
	[AkademikBirimID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](100) NOT NULL,
 CONSTRAINT [PK_AkademikBirimler] PRIMARY KEY CLUSTERED 
(
	[AkademikBirimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bolumler](
	[BolumID] [int] IDENTITY(1,1) NOT NULL,
	[BolumAd] [varchar](50) NOT NULL,
	[AkademikBirimID] [int] NOT NULL,
 CONSTRAINT [PK_Bolumler] PRIMARY KEY CLUSTERED 
(
	[BolumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dersler]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dersler](
	[DersID] [int] IDENTITY(1,1) NOT NULL,
	[DersKodu] [varchar](50) NOT NULL,
	[DersAd] [varchar](75) NOT NULL,
	[BolumID] [int] NOT NULL,
	[DonemNo] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Devamsizlik]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devamsizlik](
	[OgrID] [int] NOT NULL,
	[DersID] [int] NOT NULL,
	[Tarih] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Donemler]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Donemler](
	[DonemNo] [int] IDENTITY(1,1) NOT NULL,
	[DonemID] [varchar](50) NOT NULL,
	[DonemAd] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Donemler] PRIMARY KEY CLUSTERED 
(
	[DonemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[OgrID] [int] IDENTITY(1,1) NOT NULL,
	[No] [int] NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Soyad] [varchar](50) NOT NULL,
	[BolumID] [int] NOT NULL,
	[Sifre] [int] NOT NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[OgrID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OgrenciNotlar]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OgrenciNotlar](
	[NotID] [int] NOT NULL,
	[OgrID] [int] NOT NULL,
	[DonemNo] [int] NULL,
	[SinavTip] [int] NOT NULL,
	[DersKodu] [varchar](50) NOT NULL,
	[Notu] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OgretimElemaniDers]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgretimElemaniDers](
	[OEID] [int] NOT NULL,
	[DersID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OgretimElemanlari]    Script Date: 26.12.2016 02:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OgretimElemanlari](
	[OEID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](50) NOT NULL,
	[Soyad] [varchar](50) NOT NULL,
	[TC] [int] NOT NULL,
	[BolumID] [int] NOT NULL,
	[SicilNo] [int] NOT NULL,
	[Sifre] [varchar](50) NULL,
 CONSTRAINT [PK_OgretimElemanlari] PRIMARY KEY CLUSTERED 
(
	[OEID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[AkademikBirimler] ON 

INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (1, N'Diş Hekimliği Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (2, N'Eczacılık Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (3, N'TUSAŞ-Kazan Meslek Yüksekokulu')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (4, N'Edebiyat Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (5, N'Endüstriyel Sanatlar Eğitim Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (6, N'Fen Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (1005, N'Güzel Sanatlar Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (1007, N'İktisadi ve İdari Bilimler Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (1017, N'Ticaret ve Turizm Eğitim Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (1018, N'Tıp Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (1019, N'Teknoloji Fakültesi')
INSERT [dbo].[AkademikBirimler] ([AkademikBirimID], [Ad]) VALUES (1020, N'Teknik Eğitim Fakültesi')
SET IDENTITY_INSERT [dbo].[AkademikBirimler] OFF
SET IDENTITY_INSERT [dbo].[Bolumler] ON 

INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2, N'Klinik Bilimler', 1)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2036, N'Temel Bilimler', 1)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2037, N'Eczacılık Teknolojisi', 2)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2038, N'Eczacılık Meslek Bilimleri', 2)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2039, N'Bilgisayar Teknolojileri', 3)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2040, N'Motorlu Araçlar ve Ulaştırma Teknolojileri', 3)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2041, N'Ulaştırma Hizmetleri', 3)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2042, N'Yönetim ve Organizasyon', 3)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2043, N'Arkeoloji', 4)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2044, N'Batı Dilleri ve Edebiyatçıları', 4)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2045, N'Tarih', 4)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2046, N'Endüstriyel Teknoloji Bölümü', 5)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2047, N'Biyoloji', 6)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2048, N'Fizik', 6)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2049, N'Kimya', 6)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2051, N'Resim', 1005)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2052, N'Heykel', 1005)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2053, N'İktisat', 1007)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2054, N'İşletme', 1007)
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd], [AkademikBirimID]) VALUES (2056, N'Maliye', 1007)
SET IDENTITY_INSERT [dbo].[Bolumler] OFF
SET IDENTITY_INSERT [dbo].[Dersler] ON 

INSERT [dbo].[Dersler] ([DersID], [DersKodu], [DersAd], [BolumID], [DonemNo]) VALUES (1, N'BL-110', N'Görsel Programcılık', 2, 33)
SET IDENTITY_INSERT [dbo].[Dersler] OFF
SET IDENTITY_INSERT [dbo].[Donemler] ON 

INSERT [dbo].[Donemler] ([DonemNo], [DonemID], [DonemAd]) VALUES (33, N'2016-2017', N'Güz')
INSERT [dbo].[Donemler] ([DonemNo], [DonemID], [DonemAd]) VALUES (34, N'2016-2017', N'Bahar')
SET IDENTITY_INSERT [dbo].[Donemler] OFF
SET IDENTITY_INSERT [dbo].[Ogrenciler] ON 

INSERT [dbo].[Ogrenciler] ([OgrID], [No], [Ad], [Soyad], [BolumID], [Sifre]) VALUES (4, 153801017, N'Muhammed', N'KARAKOYUN', 2, 2051)
INSERT [dbo].[Ogrenciler] ([OgrID], [No], [Ad], [Soyad], [BolumID], [Sifre]) VALUES (1008, 153801019, N'ahmet', N'candan', 0, 153)
INSERT [dbo].[Ogrenciler] ([OgrID], [No], [Ad], [Soyad], [BolumID], [Sifre]) VALUES (1009, 15380120, N'Serhat Sefa', N'Akpınar', 1, 1588)
INSERT [dbo].[Ogrenciler] ([OgrID], [No], [Ad], [Soyad], [BolumID], [Sifre]) VALUES (1011, 153801018, N'Serhat Sefa', N'Akpınar', 2039, 123654)
SET IDENTITY_INSERT [dbo].[Ogrenciler] OFF
INSERT [dbo].[OgretimElemaniDers] ([OEID], [DersID]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[OgretimElemanlari] ON 

INSERT [dbo].[OgretimElemanlari] ([OEID], [Adi], [Soyad], [TC], [BolumID], [SicilNo], [Sifre]) VALUES (1, N'Muhammed', N'KARAKOYUN', 161624, 2, 1563, N'ss')
SET IDENTITY_INSERT [dbo].[OgretimElemanlari] OFF
/****** Object:  Index [IX_DersID]    Script Date: 26.12.2016 02:25:34 ******/
ALTER TABLE [dbo].[Dersler] ADD  CONSTRAINT [IX_DersID] UNIQUE NONCLUSTERED 
(
	[DersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_DersKodu]    Script Date: 26.12.2016 02:25:34 ******/
ALTER TABLE [dbo].[Dersler] ADD  CONSTRAINT [IX_DersKodu] UNIQUE NONCLUSTERED 
(
	[DersKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bolumler]  WITH CHECK ADD  CONSTRAINT [FK_Bolumler_AkademikBirimler] FOREIGN KEY([AkademikBirimID])
REFERENCES [dbo].[AkademikBirimler] ([AkademikBirimID])
GO
ALTER TABLE [dbo].[Bolumler] CHECK CONSTRAINT [FK_Bolumler_AkademikBirimler]
GO
ALTER TABLE [dbo].[Devamsizlik]  WITH CHECK ADD  CONSTRAINT [FK_Devamsizlik_Ogrenciler] FOREIGN KEY([OgrID])
REFERENCES [dbo].[Ogrenciler] ([OgrID])
GO
ALTER TABLE [dbo].[Devamsizlik] CHECK CONSTRAINT [FK_Devamsizlik_Ogrenciler]
GO
ALTER TABLE [dbo].[OgrenciNotlar]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciNotlar_Dersler] FOREIGN KEY([DersKodu])
REFERENCES [dbo].[Dersler] ([DersKodu])
GO
ALTER TABLE [dbo].[OgrenciNotlar] CHECK CONSTRAINT [FK_OgrenciNotlar_Dersler]
GO
ALTER TABLE [dbo].[OgrenciNotlar]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciNotlar_Donemler] FOREIGN KEY([DonemNo])
REFERENCES [dbo].[Donemler] ([DonemNo])
GO
ALTER TABLE [dbo].[OgrenciNotlar] CHECK CONSTRAINT [FK_OgrenciNotlar_Donemler]
GO
ALTER TABLE [dbo].[OgrenciNotlar]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciNotlar_Ogrenciler] FOREIGN KEY([OgrID])
REFERENCES [dbo].[Ogrenciler] ([OgrID])
GO
ALTER TABLE [dbo].[OgrenciNotlar] CHECK CONSTRAINT [FK_OgrenciNotlar_Ogrenciler]
GO
ALTER TABLE [dbo].[OgretimElemaniDers]  WITH CHECK ADD  CONSTRAINT [FK_OgretimElemaniDers_Dersler] FOREIGN KEY([DersID])
REFERENCES [dbo].[Dersler] ([DersID])
GO
ALTER TABLE [dbo].[OgretimElemaniDers] CHECK CONSTRAINT [FK_OgretimElemaniDers_Dersler]
GO
ALTER TABLE [dbo].[OgretimElemaniDers]  WITH CHECK ADD  CONSTRAINT [FK_OgretimElemaniDers_OgretimElemanlari] FOREIGN KEY([OEID])
REFERENCES [dbo].[OgretimElemanlari] ([OEID])
GO
ALTER TABLE [dbo].[OgretimElemaniDers] CHECK CONSTRAINT [FK_OgretimElemaniDers_OgretimElemanlari]
GO
USE [master]
GO
ALTER DATABASE [OgrenciBilgiSistemi] SET  READ_WRITE 
GO
