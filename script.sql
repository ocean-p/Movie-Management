USE [master]
GO
/****** Object:  Database [Pe2021]    Script Date: 4/10/2021 3:24:13 PM ******/
CREATE DATABASE [Pe2021]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pe2021', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pe2021.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pe2021_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pe2021_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Pe2021] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pe2021].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pe2021] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pe2021] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pe2021] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pe2021] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pe2021] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pe2021] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Pe2021] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pe2021] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pe2021] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pe2021] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pe2021] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pe2021] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pe2021] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pe2021] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pe2021] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Pe2021] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pe2021] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pe2021] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pe2021] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pe2021] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pe2021] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pe2021] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pe2021] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pe2021] SET  MULTI_USER 
GO
ALTER DATABASE [Pe2021] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pe2021] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pe2021] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pe2021] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pe2021] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pe2021] SET QUERY_STORE = OFF
GO
USE [Pe2021]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 4/10/2021 3:24:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[title] [varchar](100) NOT NULL,
	[year] [int] NOT NULL,
	[length] [int] NULL,
	[genre] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[title] ASC,
	[year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Empire Strikes Back', 1980, 111, N'fantasy')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Exciting', 2000, 150, N'comedy')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Gone With the Wind', 1938, 238, N'drama')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'haha', 2003, 200, N'hai huoc')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Happy', 2018, 200, N'comdey')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Happy', 2020, 100, N'action')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'King Kong', 1933, 100, N'drama')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'King Kong', 2005, 187, N'drama')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Logan''s run', 1976, 150, N'sciFi')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Pretty Woman', 1990, 119, N'comedy')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Star Trek', 1979, 132, N'sciFi')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Star Trek: Nemesis', 2002, 116, N'comedy')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Star Wars', 1977, 130, N'sciFi')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Star Wars', 2017, 180, N'sciFi')
INSERT [dbo].[Movies] ([title], [year], [length], [genre]) VALUES (N'Terms of Endearment', 1983, 132, N'romance')
USE [master]
GO
ALTER DATABASE [Pe2021] SET  READ_WRITE 
GO
