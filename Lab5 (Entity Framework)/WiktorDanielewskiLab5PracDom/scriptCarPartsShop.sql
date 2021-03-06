USE [master]
GO
/****** Object:  Database [CarPartsShop]    Script Date: 19/12/2021 01:10:31 ******/
CREATE DATABASE [CarPartsShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarPartsShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarPartsShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarPartsShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarPartsShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarPartsShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarPartsShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarPartsShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarPartsShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarPartsShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarPartsShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarPartsShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarPartsShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarPartsShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarPartsShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarPartsShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarPartsShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarPartsShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarPartsShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarPartsShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarPartsShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarPartsShop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CarPartsShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarPartsShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarPartsShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarPartsShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarPartsShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarPartsShop] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [CarPartsShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarPartsShop] SET RECOVERY FULL 
GO
ALTER DATABASE [CarPartsShop] SET  MULTI_USER 
GO
ALTER DATABASE [CarPartsShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarPartsShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarPartsShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarPartsShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarPartsShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarPartsShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarPartsShop', N'ON'
GO
ALTER DATABASE [CarPartsShop] SET QUERY_STORE = OFF
GO
USE [CarPartsShop]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/12/2021 01:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarParts]    Script Date: 19/12/2021 01:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarParts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ProducentID] [int] NOT NULL,
	[Availability] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_CarParts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Opinions]    Script Date: 19/12/2021 01:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opinions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CarPartID] [int] NOT NULL,
	[Header] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[Rate] [int] NOT NULL,
 CONSTRAINT [PK_Opinions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 19/12/2021 01:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CarPartID] [int] NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producents]    Script Date: 19/12/2021 01:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[HeadOffice] [nvarchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
 CONSTRAINT [PK_Producents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211215230430_init', N'3.1.22')
GO
SET IDENTITY_INSERT [dbo].[CarParts] ON 

INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (1, N'Klocki hamulcowe', 1, 8, 380)
INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (2, N'Klocki hamulcowe', 3, 3, 300)
INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (15, N'Filtr paliwa', 4, 4, 50)
INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (16, N'Filtr powietrza', 1, 2, 30)
INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (17, N'Akumulator', 1, 8, 320)
INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (18, N'Akumulator', 3, 0, 250)
INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (19, N'Olej 5W40 4L', 21, 3, 130)
INSERT [dbo].[CarParts] ([ID], [Name], [ProducentID], [Availability], [Price]) VALUES (20, N'Olej 5W30 4L', 21, 0, 160)
SET IDENTITY_INSERT [dbo].[CarParts] OFF
GO
SET IDENTITY_INSERT [dbo].[Opinions] ON 

INSERT [dbo].[Opinions] ([ID], [CarPartID], [Header], [Description], [Rate]) VALUES (2, 1, N'Ok', N'Szybka dostawa. Przedmiot zgodny z opisem.', 6)
INSERT [dbo].[Opinions] ([ID], [CarPartID], [Header], [Description], [Rate]) VALUES (3, 2, N'Przeciętne', N'Dosyć szybko się zużyły.', 3)
INSERT [dbo].[Opinions] ([ID], [CarPartID], [Header], [Description], [Rate]) VALUES (4, 19, N'Bardzo dobry', N'Olej jest bardzo dobrej jakości.', 6)
INSERT [dbo].[Opinions] ([ID], [CarPartID], [Header], [Description], [Rate]) VALUES (9, 18, N'Słabo', N'Produkt przyszedł uszkodzony.', 1)
SET IDENTITY_INSERT [dbo].[Opinions] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [CarPartID], [Number]) VALUES (5, 18, 10)
INSERT [dbo].[Orders] ([ID], [CarPartID], [Number]) VALUES (6, 20, 12)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Producents] ON 

INSERT [dbo].[Producents] ([ID], [Name], [HeadOffice], [PhoneNumber]) VALUES (1, N'Bosh', N'Wrocław', 567322988)
INSERT [dbo].[Producents] ([ID], [Name], [HeadOffice], [PhoneNumber]) VALUES (3, N'NGK', N'Kraków', 567222112)
INSERT [dbo].[Producents] ([ID], [Name], [HeadOffice], [PhoneNumber]) VALUES (4, N'Febi-Bilstein', N'Warszawa', 734123666)
INSERT [dbo].[Producents] ([ID], [Name], [HeadOffice], [PhoneNumber]) VALUES (21, N'Castrol', N'Wrocław', 567232123)
SET IDENTITY_INSERT [dbo].[Producents] OFF
GO
/****** Object:  Index [IX_CarParts_ProducentID]    Script Date: 19/12/2021 01:10:31 ******/
CREATE NONCLUSTERED INDEX [IX_CarParts_ProducentID] ON [dbo].[CarParts]
(
	[ProducentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Opinions_CarPartID]    Script Date: 19/12/2021 01:10:31 ******/
CREATE NONCLUSTERED INDEX [IX_Opinions_CarPartID] ON [dbo].[Opinions]
(
	[CarPartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_CarPartID]    Script Date: 19/12/2021 01:10:31 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CarPartID] ON [dbo].[Orders]
(
	[CarPartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CarParts]  WITH CHECK ADD  CONSTRAINT [FK_CarParts_Producents_ProducentID] FOREIGN KEY([ProducentID])
REFERENCES [dbo].[Producents] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarParts] CHECK CONSTRAINT [FK_CarParts_Producents_ProducentID]
GO
ALTER TABLE [dbo].[Opinions]  WITH CHECK ADD  CONSTRAINT [FK_Opinions_CarParts_CarPartID] FOREIGN KEY([CarPartID])
REFERENCES [dbo].[CarParts] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Opinions] CHECK CONSTRAINT [FK_Opinions_CarParts_CarPartID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_CarParts_CarPartID] FOREIGN KEY([CarPartID])
REFERENCES [dbo].[CarParts] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_CarParts_CarPartID]
GO
USE [master]
GO
ALTER DATABASE [CarPartsShop] SET  READ_WRITE 
GO
