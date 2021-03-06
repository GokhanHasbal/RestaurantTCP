USE [master]
GO
/****** Object:  Database [Restoran]    Script Date: 16.03.2022 14:08:01 ******/
CREATE DATABASE [Restoran]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restoran', FILENAME = N'/var/opt/mssql/data/Restoran.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Restoran_log', FILENAME = N'/var/opt/mssql/data/Restoran_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Restoran] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restoran].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restoran] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restoran] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restoran] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restoran] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restoran] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restoran] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restoran] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restoran] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restoran] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restoran] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restoran] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restoran] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restoran] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restoran] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restoran] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Restoran] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restoran] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restoran] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restoran] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restoran] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restoran] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restoran] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restoran] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Restoran] SET  MULTI_USER 
GO
ALTER DATABASE [Restoran] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [Restoran] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restoran] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restoran] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Restoran] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Restoran] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Restoran', N'ON'
GO
ALTER DATABASE [Restoran] SET QUERY_STORE = OFF
GO
USE [Restoran]
GO
/****** Object:  Table [dbo].[Adisyon]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adisyon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonelId] [int] NULL,
	[MasaId] [int] NULL,
	[KisiSayisi] [int] NULL,
	[OlusturmaTarihi] [date] NULL,
	[KapatmaTarihi] [date] NULL,
	[Durum] [bit] NULL,
	[ToplamFiyat] [float] NULL,
	[Hazir] [bit] NOT NULL,
 CONSTRAINT [PK__Adisyon__3214EC07E096FC92] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kategori] [nvarchar](101) NULL,
	[Aciklama] [nchar](100) NULL,
 CONSTRAINT [PK__Kategori__3214EC07D0D202EF] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Masalar]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Soyad] [nvarchar](100) NULL,
	[KullaniciAdi] [nvarchar](100) NULL,
	[Sifre] [nvarchar](100) NULL,
	[YetkiId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdisyonId] [int] NULL,
	[UrunId] [int] NULL,
	[Aciklama] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
	[Adet] [int] NULL,
 CONSTRAINT [PK_AdisyonUrun] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Aciklama] [nvarchar](100) NULL,
	[Resim] [nvarchar](250) NULL,
	[Fiyat] [float] NULL,
	[Durum] [bit] NULL,
	[KategoriId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetki]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetki](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Yetki] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Adisyon] ON 

INSERT [dbo].[Adisyon] ([Id], [PersonelId], [MasaId], [KisiSayisi], [OlusturmaTarihi], [KapatmaTarihi], [Durum], [ToplamFiyat], [Hazir]) VALUES (16, 2, 1, 1, CAST(N'2022-03-14' AS Date), CAST(N'2022-03-14' AS Date), 0, NULL, 0)
INSERT [dbo].[Adisyon] ([Id], [PersonelId], [MasaId], [KisiSayisi], [OlusturmaTarihi], [KapatmaTarihi], [Durum], [ToplamFiyat], [Hazir]) VALUES (17, 2, 2, 1, CAST(N'2022-03-14' AS Date), CAST(N'2022-03-14' AS Date), 0, NULL, 0)
INSERT [dbo].[Adisyon] ([Id], [PersonelId], [MasaId], [KisiSayisi], [OlusturmaTarihi], [KapatmaTarihi], [Durum], [ToplamFiyat], [Hazir]) VALUES (18, 2, 1, 1, CAST(N'2022-03-14' AS Date), CAST(N'2022-03-16' AS Date), 0, NULL, 0)
INSERT [dbo].[Adisyon] ([Id], [PersonelId], [MasaId], [KisiSayisi], [OlusturmaTarihi], [KapatmaTarihi], [Durum], [ToplamFiyat], [Hazir]) VALUES (19, 2, 2, 1, CAST(N'2022-03-14' AS Date), CAST(N'2022-03-14' AS Date), 0, NULL, 0)
INSERT [dbo].[Adisyon] ([Id], [PersonelId], [MasaId], [KisiSayisi], [OlusturmaTarihi], [KapatmaTarihi], [Durum], [ToplamFiyat], [Hazir]) VALUES (20, 2, 3, 1, CAST(N'2022-03-16' AS Date), CAST(N'2022-03-16' AS Date), 0, NULL, 0)
INSERT [dbo].[Adisyon] ([Id], [PersonelId], [MasaId], [KisiSayisi], [OlusturmaTarihi], [KapatmaTarihi], [Durum], [ToplamFiyat], [Hazir]) VALUES (21, 2, 5, 1, CAST(N'2022-03-16' AS Date), CAST(N'2022-03-16' AS Date), 0, NULL, 0)
INSERT [dbo].[Adisyon] ([Id], [PersonelId], [MasaId], [KisiSayisi], [OlusturmaTarihi], [KapatmaTarihi], [Durum], [ToplamFiyat], [Hazir]) VALUES (22, 2, 1, 1, CAST(N'2022-03-16' AS Date), NULL, 1, NULL, 1)
SET IDENTITY_INSERT [dbo].[Adisyon] OFF
GO
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (1, N'Ana Yemekler', N'asdasd                                                                                              ')
INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (2, N'Aparatifler', N'asdasdasd                                                                                           ')
INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (3, N'Tatlılar', N'asdasdas                                                                                            ')
INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (4, N'Çorbalar', N'asdasd                                                                                              ')
INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (5, N'Salatalar', N'asdasda                                                                                             ')
INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (6, N'İçecekler', N'asdsadas                                                                                            ')
INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (8, N'sdaasd', N'asdasd                                                                                              ')
INSERT [dbo].[Kategoriler] ([Id], [Kategori], [Aciklama]) VALUES (9, N'sdaasd', N'asdasd                                                                                              ')
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
GO
SET IDENTITY_INSERT [dbo].[Masalar] ON 

INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (1, N'Masa1', 1)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (2, N'Masa2', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (3, N'Masa3', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (4, N'Masa4', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (5, N'Masa5', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (6, N'Masa6', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (7, N'Masa7', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (8, N'Masa8', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (9, N'Masa9', 0)
INSERT [dbo].[Masalar] ([Id], [Ad], [Durum]) VALUES (10, N'Masa10', 0)
SET IDENTITY_INSERT [dbo].[Masalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [KullaniciAdi], [Sifre], [YetkiId]) VALUES (2, N'Cihan', N'Alkaya', N'cihan', N'123', 3)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [KullaniciAdi], [Sifre], [YetkiId]) VALUES (3, N'Ahmet', N'Şekerci', N'ahmet', N'123', 2)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [KullaniciAdi], [Sifre], [YetkiId]) VALUES (4, N'Fatih', N'Dengiz', N'fatih', N'123', 3)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [KullaniciAdi], [Sifre], [YetkiId]) VALUES (5, N'Gökhan', N'Hasbal', N'gokhan', N'123', 1)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [KullaniciAdi], [Sifre], [YetkiId]) VALUES (6, N'Sezer', N'sdfsdfsd', N'sezer', N'123', 3)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Siparis] ON 

INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (24, 16, 2, NULL, 1, 2)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (25, 16, 7, NULL, 1, 2)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (26, 16, 6, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (27, 16, 5, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (28, 17, 7, NULL, 0, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (29, 17, 2, NULL, 0, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (30, 17, 1, NULL, 0, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (31, 17, 8, NULL, 0, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (32, 18, 2, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (33, 18, 6, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (34, 18, 5, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (35, 18, 6, NULL, 1, 4)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (36, 18, 5, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (37, 19, 2, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (38, 19, 6, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (39, 19, 5, NULL, 1, 5)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (40, 19, 1, NULL, 0, 5)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (41, 18, 6, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (42, 20, 2, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (43, 20, 6, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (44, 21, 2, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (45, 21, 5, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (46, 21, 1, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (47, 22, 2, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (48, 22, 6, NULL, 1, 1)
INSERT [dbo].[Siparis] ([Id], [AdisyonId], [UrunId], [Aciklama], [Durum], [Adet]) VALUES (49, 22, 5, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[Siparis] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (1, N'Mercimek Çorbası', N'çorba', N'corba.jpeg', 10, 1, 4)
INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (2, N'Karnıyarık', N'yemek', N'pa.jpeg', 30, 1, 1)
INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (3, N'Ayran', N'ayran', N'ayran', 5, 1, 6)
INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (4, N'Gavurdağı Salatası', N'salata', N'salat', 25, 1, 5)
INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (5, N'Sütlaç', N'tatli', N'süt', 100, 1, 3)
INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (6, N'Patates Kızartma', N'kızartma', N'pattes', 15, 1, 2)
INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (7, N'Kavurma Güveç', N'asda', N'asd', 50, 1, 1)
INSERT [dbo].[Urunler] ([Id], [Ad], [Aciklama], [Resim], [Fiyat], [Durum], [KategoriId]) VALUES (8, N'Tavuk Suyu Çorba', N'çorba', N'a', 12, 1, 4)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetki] ON 

INSERT [dbo].[Yetki] ([Id], [Yetki], [Durum]) VALUES (1, N'Müdür', 1)
INSERT [dbo].[Yetki] ([Id], [Yetki], [Durum]) VALUES (2, N'Şef', 1)
INSERT [dbo].[Yetki] ([Id], [Yetki], [Durum]) VALUES (3, N'Garson', 1)
SET IDENTITY_INSERT [dbo].[Yetki] OFF
GO
ALTER TABLE [dbo].[Adisyon] ADD  CONSTRAINT [DF_Adisyon_Hazir]  DEFAULT ((0)) FOR [Hazir]
GO
ALTER TABLE [dbo].[Adisyon]  WITH CHECK ADD  CONSTRAINT [FK_Adisyon_Masalar] FOREIGN KEY([MasaId])
REFERENCES [dbo].[Masalar] ([Id])
GO
ALTER TABLE [dbo].[Adisyon] CHECK CONSTRAINT [FK_Adisyon_Masalar]
GO
ALTER TABLE [dbo].[Adisyon]  WITH CHECK ADD  CONSTRAINT [FK_Adisyon_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[Adisyon] CHECK CONSTRAINT [FK_Adisyon_Personel]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Yetki] FOREIGN KEY([YetkiId])
REFERENCES [dbo].[Yetki] ([Id])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Yetki]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonSiparis_Adisyon] FOREIGN KEY([AdisyonId])
REFERENCES [dbo].[Adisyon] ([Id])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_AdisyonSiparis_Adisyon]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([Id])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Urunler]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Kategoriler] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategoriler] ([Id])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Kategoriler]
GO
/****** Object:  StoredProcedure [dbo].[adisyonEkle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[adisyonEkle]
@masaid int,
@personelid int,
@kisisayisi int,
@otarih datetime,
@durum bit
as
begin
insert into Adisyon(MasaId,PersonelId,KisiSayisi,OlusturmaTarihi,Durum)
values(@masaid,@personelid,@kisisayisi,@otarih,@durum)
end
begin
update Masalar set Durum=1 where Masalar.Id=@masaid
end
begin
select*from Adisyon where MasaId=@masaid and Durum=1
end
GO
/****** Object:  StoredProcedure [dbo].[adisyonGetir]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[adisyonGetir]
as
begin
	select * from Adisyon
end
GO
/****** Object:  StoredProcedure [dbo].[adisyonGetirId]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[adisyonGetirId]
@adisyonId int
as
begin
	select * from Adisyon where Id = @adisyonId
end
GO
/****** Object:  StoredProcedure [dbo].[adisyonGuncelle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[adisyonGuncelle]
@adisyonId int,
@personelId int,
@masaId int,
@kisiSayisi int,
@olusturmaTarih date,
@kapatmaTarih date,
@durum bit,
@toplamFiyat float
as
begin
	update Adisyon
	set
	    PersonelId = @personelId,
		MasaId = @masaId,
		KisiSayisi = @kisiSayisi,
		OlusturmaTarihi = @olusturmaTarih,
		KapatmaTarihi = @kapatmaTarih,
		Durum = @durum,
		ToplamFiyat = @toplamFiyat
	where Id = @adisyonId
end
GO
/****** Object:  StoredProcedure [dbo].[adisyonkapat]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[adisyonkapat]
@adisyonid int,
@masaid int,
@ktarih datetime,
@durum bit
as
begin
update Adisyon set KapatmaTarihi=@ktarih,Durum=0 where Id=@adisyonid and Durum=1
end
begin
update Masalar set Durum=0 where Masalar.Id=@masaid
end
begin
select*from Adisyon where MasaId=@masaid and Durum=1
end
GO
/****** Object:  StoredProcedure [dbo].[adisyonSil]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[adisyonSil]
@adisyonId int
as
begin
	delete from Adisyon where Id=@adisyonId
end
GO
/****** Object:  StoredProcedure [dbo].[kategoriEkle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[kategoriEkle]
@kategori nvarchar(100),
@aciklama nvarchar(100)
as
begin
	insert into Kategoriler(Kategori,Aciklama)
	Values(@kategori,@aciklama)
end
GO
/****** Object:  StoredProcedure [dbo].[kategoriGetir]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[kategoriGetir]
as
begin
	select * from Kategoriler
end
GO
/****** Object:  StoredProcedure [dbo].[kategoriGetirId]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[kategoriGetirId]
@kategoriId int
as
begin
	select * from Kategoriler where Id = @kategoriId
end
GO
/****** Object:  StoredProcedure [dbo].[kategoriGuncelle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[kategoriGuncelle]
@kategoriId int,
@kategori nvarchar(100),
@aciklama nvarchar(100)
as
begin
	update Kategoriler
	set
	    Kategori = @kategori,
		Aciklama = @aciklama
	where Id = @kategoriId
end
GO
/****** Object:  StoredProcedure [dbo].[kategoriSil]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[kategoriSil]
@kategoriId int
as
begin
	delete from Kategoriler where Id=@kategoriId;
end
GO
/****** Object:  StoredProcedure [dbo].[masaAdisyonGoster]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[masaAdisyonGoster]
@masaId int
as
begin
    select Adisyon.Id,Urunler.Ad,Siparis.Adet,Fiyat*Siparis.Adet as 'Fiyat' from Masalar inner join Adisyon
on(Masalar.Id=Adisyon.MasaId) inner join Siparis
on(Adisyon.Id=Siparis.AdisyonId) inner join Urunler
on(Urunler.Id=Siparis.UrunId) where Masalar.Id=@masaId and
Adisyon.Durum=1 and Masalar.Durum=1
end
GO
/****** Object:  StoredProcedure [dbo].[masaSiparisGoster]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[masaSiparisGoster]
as
begin
	select Urunler.Ad As "urun Adı" ,Siparis.Adet as "Sipariş Adet" ,Urunler.Fiyat as "Adet Fiyatı", Siparis.Aciklama,Adisyon.ToplamFiyat 
	from Urunler 
	inner join Siparis on Urunler.Id = Siparis.UrunId
	inner join Adisyon on Adisyon.Id = Siparis.AdisyonId
end
GO
/****** Object:  StoredProcedure [dbo].[personelEkle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[personelEkle]
@ad nvarchar(100),
@soyad nvarchar(100),
@kullaniciAdi nvarchar(100),
@sifre nvarchar(100),
@yetkiId int
as
begin
	insert into Personel(Ad,Soyad,KullaniciAdi,Sifre,YetkiId)
	Values(@ad,@soyad,@kullaniciAdi,@sifre,@yetkiId)
end
GO
/****** Object:  StoredProcedure [dbo].[personelGetir]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[personelGetir]
as
begin
	select * from Personel
end
GO
/****** Object:  StoredProcedure [dbo].[personelGetirId]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[personelGetirId]
@personelId int
as
begin
	select * from Personel where Id = @personelId
end
GO
/****** Object:  StoredProcedure [dbo].[personelGuncelle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[personelGuncelle]
@personelId int,
@ad nvarchar(100),
@soyad nvarchar(100),
@kullaniciAdi nvarchar(100),
@sifre nvarchar(100),
@yetkiId int
as
begin
	update Personel
	set
	    ad = @ad,
		Soyad = @soyad,
		KullaniciAdi = @kullaniciAdi,
		Sifre = @sifre,
		YetkiId = @yetkiId
	where Id = @personelId
end
GO
/****** Object:  StoredProcedure [dbo].[personelSil]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[personelSil]
@personelId int
as
begin
	delete from Urunler where Id=@personelId;
end
GO
/****** Object:  StoredProcedure [dbo].[SiparisGetir]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SiparisGetir]
as
begin
	select * from Siparis 
end
GO
/****** Object:  StoredProcedure [dbo].[SiparisGetirId]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SiparisGetirId]
@siparisId int
as
begin
	select * from Siparis where Id=@siparisId
end
GO
/****** Object:  StoredProcedure [dbo].[SiparisGuncelle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SiparisGuncelle]
@siparisId int,
@adisyonId int,
@urunId int,
@aciklama nvarchar(100),
@durum bit,
@adet int
as
begin
	update Siparis 
		Set 
			AdisyonId = @adisyonId,
			UrunId = @urunId ,
			Aciklama = @aciklama,
			Durum = @durum,
			Adet = @adet
		where Id = @siparisId
end
GO
/****** Object:  StoredProcedure [dbo].[SiparislerSil]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SiparislerSil]
@adisyonId int
as
begin
    delete from Siparis where AdisyonId = @adisyonId
end
GO
/****** Object:  StoredProcedure [dbo].[SiparisSil]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SiparisSil]
@siparisId int
as
begin
	delete from Siparis where Id = @siparisId
end
GO
/****** Object:  StoredProcedure [dbo].[SiparisVer]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SiparisVer]
@AdisyonId int,
@UrunId int,
@Adet int
as
begin
    insert into Siparis(AdisyonId,Aciklama,UrunId,Adet,Durum) values(@AdisyonId,NULL,@UrunId,@Adet,0)
end
begin
    select Siparis.Id,Ad,Siparis.Adet from Siparis inner join Urunler
    on(Siparis.UrunId=Urunler.Id) where AdisyonId=@AdisyonId
end
GO
/****** Object:  StoredProcedure [dbo].[urunlerEkle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[urunlerEkle]
@ad nvarchar(100),
@aciklama nvarchar(100),
@resim nvarchar(250),
@fiyat float,
@durum bit,
@kategoriId int
as
begin
	insert into Urunler(Ad,Aciklama,Resim,Fiyat,Durum,KategoriId)
	Values(@ad,@aciklama,@resim,@fiyat,@durum,@kategoriId)
end
GO
/****** Object:  StoredProcedure [dbo].[urunleriGetir]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[urunleriGetir]
as
begin
	select * from Urunler
end
GO
/****** Object:  StoredProcedure [dbo].[urunleriGetirId]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[urunleriGetirId]
@urunId int
as
begin
	select * from Kategoriler where Id = @urunId
end
GO
/****** Object:  StoredProcedure [dbo].[urunleriGuncelle]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[urunleriGuncelle]
@urunlerId int,
@ad nvarchar(100),
@aciklama nvarchar(100),
@resim nvarchar(250),
@fiyat float,
@durum bit,
@kategoriId int
as
begin
	update Urunler
	set
	    ad = @ad,
		Aciklama = @aciklama,
		Resim = @resim,
		Fiyat = @fiyat,
		Durum = @durum,
		KategoriId = @kategoriId
	where Id = @urunlerId
end

GO
/****** Object:  StoredProcedure [dbo].[urunlerSil]    Script Date: 16.03.2022 14:08:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[urunlerSil]
@urunId int
as
begin
	delete from Urunler where Id=@urunId;
end
GO
USE [master]
GO
ALTER DATABASE [Restoran] SET  READ_WRITE 
GO
