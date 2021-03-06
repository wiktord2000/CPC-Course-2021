USE [master]
GO
/****** Object:  Database [MoviesDB]    Script Date: 09/01/2022 22:19:05 ******/
CREATE DATABASE [MoviesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MoviesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MoviesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MoviesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MoviesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MoviesDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MoviesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MoviesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MoviesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MoviesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MoviesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MoviesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MoviesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MoviesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MoviesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MoviesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MoviesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MoviesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MoviesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MoviesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MoviesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MoviesDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MoviesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MoviesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MoviesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MoviesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MoviesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MoviesDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MoviesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MoviesDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MoviesDB] SET  MULTI_USER 
GO
ALTER DATABASE [MoviesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MoviesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MoviesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MoviesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MoviesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MoviesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MoviesDB', N'ON'
GO
ALTER DATABASE [MoviesDB] SET QUERY_STORE = OFF
GO
USE [MoviesDB]
GO
/****** Object:  Table [dbo].[Directors]    Script Date: 09/01/2022 22:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Directors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 09/01/2022 22:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[YearOfRelease] [int] NOT NULL,
	[DirectorId] [int] NOT NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Directors] ON 

INSERT [dbo].[Directors] ([Id], [FirstName], [LastName]) VALUES (6, N'Steven', N'Spielberg')
INSERT [dbo].[Directors] ([Id], [FirstName], [LastName]) VALUES (7, N'Peter', N'Jackson')
INSERT [dbo].[Directors] ([Id], [FirstName], [LastName]) VALUES (8, N'James', N'Cameron')
INSERT [dbo].[Directors] ([Id], [FirstName], [LastName]) VALUES (9, N'Quentin ', N'Tarantino')
SET IDENTITY_INSERT [dbo].[Directors] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([Id], [Title], [YearOfRelease], [DirectorId]) VALUES (10, N'Szeregowiec Ryan', 1998, 6)
INSERT [dbo].[Movies] ([Id], [Title], [YearOfRelease], [DirectorId]) VALUES (11, N'Park Jurajski', 1993, 6)
INSERT [dbo].[Movies] ([Id], [Title], [YearOfRelease], [DirectorId]) VALUES (12, N'Lista Schindlera', 1993, 6)
INSERT [dbo].[Movies] ([Id], [Title], [YearOfRelease], [DirectorId]) VALUES (13, N'King Kong', 2005, 7)
INSERT [dbo].[Movies] ([Id], [Title], [YearOfRelease], [DirectorId]) VALUES (14, N'Niebiańskie istoty', 1994, 7)
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
/****** Object:  Index [IX_Movies_DirectorId]    Script Date: 09/01/2022 22:19:05 ******/
CREATE NONCLUSTERED INDEX [IX_Movies_DirectorId] ON [dbo].[Movies]
(
	[DirectorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Movies]  WITH CHECK ADD  CONSTRAINT [FK_Movies_Directors_DirectorId] FOREIGN KEY([DirectorId])
REFERENCES [dbo].[Directors] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Movies] CHECK CONSTRAINT [FK_Movies_Directors_DirectorId]
GO
USE [master]
GO
ALTER DATABASE [MoviesDB] SET  READ_WRITE 
GO
