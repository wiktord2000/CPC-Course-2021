USE [master]
GO
/****** Object:  Database [ShoeStore]    Script Date: 22/11/2021 04:26:47 ******/
CREATE DATABASE [ShoeStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShoeStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ShoeStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShoeStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ShoeStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ShoeStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShoeStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShoeStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShoeStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShoeStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShoeStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShoeStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShoeStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShoeStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShoeStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShoeStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShoeStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShoeStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShoeStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShoeStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShoeStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShoeStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShoeStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShoeStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShoeStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShoeStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShoeStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShoeStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShoeStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShoeStore] SET RECOVERY FULL 
GO
ALTER DATABASE [ShoeStore] SET  MULTI_USER 
GO
ALTER DATABASE [ShoeStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShoeStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShoeStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShoeStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShoeStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShoeStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShoeStore', N'ON'
GO
ALTER DATABASE [ShoeStore] SET QUERY_STORE = OFF
GO
USE [ShoeStore]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[City] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[BuildingNumber] [int] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CollaborativeShops]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollaborativeShops](
	[Name] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
 CONSTRAINT [PK_CollaborativeShops] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Opinions]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opinions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeID] [int] NOT NULL,
	[ClientID] [int] NULL,
	[Description] [nvarchar](50) NULL,
	[Rate] [int] NOT NULL,
 CONSTRAINT [PK_Opinions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersToShop]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersToShop](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeID] [int] NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_OrdersToShop] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producents]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producents](
	[Name] [nvarchar](50) NOT NULL,
	[Headquarters] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Producent] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reclamation]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reclamation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Reclamation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shoes]    Script Date: 22/11/2021 04:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shoes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProducentName] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Size] [int] NOT NULL,
	[Male] [bit] NOT NULL,
	[Availability] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Shoes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [PhoneNumber], [City], [Street], [BuildingNumber]) VALUES (6, N'Wiktor', N'Danielewski', 765123112, N'Wrocław', N'Reja', 17)
INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [PhoneNumber], [City], [Street], [BuildingNumber]) VALUES (8, N'Jan', N'Kowalski', 787111233, N'Kalisz', N'Wyszyńskiego', 3)
INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [PhoneNumber], [City], [Street], [BuildingNumber]) VALUES (9, N'Szymon', N'Danielewski', 888111333, N'Wrocław', N'Konarskiego', 18)
INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [PhoneNumber], [City], [Street], [BuildingNumber]) VALUES (10, N'Adrian', N'Tomczak', 999111333, N'Kraków', N'3 Maja', 67)
INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [PhoneNumber], [City], [Street], [BuildingNumber]) VALUES (11, N'Kuba', N'Szos', 671901123, N'Wrocław', N'Reja', 100)
INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [PhoneNumber], [City], [Street], [BuildingNumber]) VALUES (12, N'Katarzyna', N'Nowak', 787132123, N'Kalisz', N'Górnośląska', 5)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
INSERT [dbo].[CollaborativeShops] ([Name], [City], [Street], [Email], [PhoneNumber]) VALUES (N'AddidasPolska', N'Wrocław', N'Grunwaldzka', N'addidas.wroc@gmail.com', 787777111)
INSERT [dbo].[CollaborativeShops] ([Name], [City], [Street], [Email], [PhoneNumber]) VALUES (N'NewBalancePolska', N'Warszawa', N'Żelazna', N'newballance.warszawa@gmail.com', 676113233)
INSERT [dbo].[CollaborativeShops] ([Name], [City], [Street], [Email], [PhoneNumber]) VALUES (N'NikePolska', N'Wrocław', N'Grunwaldzka', N'nike.wroclaw@gmail.com', 781331333)
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [PhoneNumber]) VALUES (1, N'Janusz', N'Dopierała', 888555211)
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [PhoneNumber]) VALUES (2, N'Barbara', N'Grzelak', 899113223)
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [PhoneNumber]) VALUES (3, N'Szymon', N'Kot', 903211333)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Opinions] ON 

INSERT [dbo].[Opinions] ([ID], [ShoeID], [ClientID], [Description], [Rate]) VALUES (2, 1, 6, N'Bardzo wytrzymałe', 5)
INSERT [dbo].[Opinions] ([ID], [ShoeID], [ClientID], [Description], [Rate]) VALUES (3, 2, 8, N'Nie polecam', 1)
INSERT [dbo].[Opinions] ([ID], [ShoeID], [ClientID], [Description], [Rate]) VALUES (6, 8, 9, N'OK', 4)
SET IDENTITY_INSERT [dbo].[Opinions] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [ShoeID], [ClientID], [Date]) VALUES (1, 6, 12, CAST(N'2021-11-21T23:58:00.000' AS DateTime))
INSERT [dbo].[Orders] ([ID], [ShoeID], [ClientID], [Date]) VALUES (2, 9, 10, CAST(N'2021-11-20T21:11:00.000' AS DateTime))
INSERT [dbo].[Orders] ([ID], [ShoeID], [ClientID], [Date]) VALUES (4, 4, 11, CAST(N'2021-11-19T20:56:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdersToShop] ON 

INSERT [dbo].[OrdersToShop] ([ID], [ShoeID], [Number]) VALUES (1, 5, 10)
INSERT [dbo].[OrdersToShop] ([ID], [ShoeID], [Number]) VALUES (2, 2, 5)
INSERT [dbo].[OrdersToShop] ([ID], [ShoeID], [Number]) VALUES (3, 10, 6)
SET IDENTITY_INSERT [dbo].[OrdersToShop] OFF
GO
INSERT [dbo].[Producents] ([Name], [Headquarters]) VALUES (N'Adidas', N'Kraków')
INSERT [dbo].[Producents] ([Name], [Headquarters]) VALUES (N'New Balance', N'Warszawa')
INSERT [dbo].[Producents] ([Name], [Headquarters]) VALUES (N'Nike', N'Wrocław')
GO
SET IDENTITY_INSERT [dbo].[Reclamation] ON 

INSERT [dbo].[Reclamation] ([ID], [ShoeID], [EmployeeID], [ClientID], [Description]) VALUES (1, 2, 2, 8, N'Rozkleił się czubek butów')
SET IDENTITY_INSERT [dbo].[Reclamation] OFF
GO
SET IDENTITY_INSERT [dbo].[Shoes] ON 

INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (1, N'Adidas', N'Barricade', 45, 1, 4, 312)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (2, N'Adidas', N'Barricade', 44, 1, 2, 312)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (3, N'Adidas', N'Barricade', 43, 1, 7, 312)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (4, N'Nike', N'Air Max 95', 46, 1, 6, 250)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (5, N'Nike', N'Air Max 95', 44, 1, 7, 250)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (6, N'Nike', N'Zoom Freak 3', 38, 0, 5, 278)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (8, N'Nike', N'Zoom Freak', 39, 0, 4, 278)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (9, N'New Balance', N'Classic', 44, 1, 3, 200)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (10, N'New Balance', N'Classic', 39, 0, 0, 200)
INSERT [dbo].[Shoes] ([ID], [ProducentName], [Model], [Size], [Male], [Availability], [Price]) VALUES (11, N'New Balance', N'Classic', 38, 0, 3, 230)
SET IDENTITY_INSERT [dbo].[Shoes] OFF
GO
ALTER TABLE [dbo].[Opinions]  WITH CHECK ADD  CONSTRAINT [FK_Opinions_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Opinions] CHECK CONSTRAINT [FK_Opinions_Clients]
GO
ALTER TABLE [dbo].[Opinions]  WITH CHECK ADD  CONSTRAINT [FK_Opinions_Shoes] FOREIGN KEY([ShoeID])
REFERENCES [dbo].[Shoes] ([ID])
GO
ALTER TABLE [dbo].[Opinions] CHECK CONSTRAINT [FK_Opinions_Shoes]
GO
ALTER TABLE [dbo].[OrdersToShop]  WITH CHECK ADD  CONSTRAINT [FK_OrdersToShop_Shoes] FOREIGN KEY([ShoeID])
REFERENCES [dbo].[Shoes] ([ID])
GO
ALTER TABLE [dbo].[OrdersToShop] CHECK CONSTRAINT [FK_OrdersToShop_Shoes]
GO
ALTER TABLE [dbo].[Reclamation]  WITH CHECK ADD  CONSTRAINT [FK_Reclamation_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Reclamation] CHECK CONSTRAINT [FK_Reclamation_Clients]
GO
ALTER TABLE [dbo].[Reclamation]  WITH CHECK ADD  CONSTRAINT [FK_Reclamation_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([ID])
GO
ALTER TABLE [dbo].[Reclamation] CHECK CONSTRAINT [FK_Reclamation_Employees]
GO
ALTER TABLE [dbo].[Reclamation]  WITH CHECK ADD  CONSTRAINT [FK_Reclamation_Shoes] FOREIGN KEY([ShoeID])
REFERENCES [dbo].[Shoes] ([ID])
GO
ALTER TABLE [dbo].[Reclamation] CHECK CONSTRAINT [FK_Reclamation_Shoes]
GO
ALTER TABLE [dbo].[Shoes]  WITH CHECK ADD  CONSTRAINT [FK_Shoes_Producents] FOREIGN KEY([ProducentName])
REFERENCES [dbo].[Producents] ([Name])
GO
ALTER TABLE [dbo].[Shoes] CHECK CONSTRAINT [FK_Shoes_Producents]
GO
USE [master]
GO
ALTER DATABASE [ShoeStore] SET  READ_WRITE 
GO
