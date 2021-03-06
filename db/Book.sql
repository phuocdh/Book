USE [master]
GO
/****** Object:  Database [Book]    Script Date: 06/21/2017 00:19:33 ******/
CREATE DATABASE [Book] ON  PRIMARY 
( NAME = N'Book', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Book.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Book_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Book_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Book] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Book].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Book] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Book] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Book] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Book] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Book] SET ARITHABORT OFF
GO
ALTER DATABASE [Book] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Book] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Book] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Book] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Book] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Book] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Book] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Book] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Book] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Book] SET  DISABLE_BROKER
GO
ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Book] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Book] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Book] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Book] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Book] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Book] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Book] SET  READ_WRITE
GO
ALTER DATABASE [Book] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Book] SET  MULTI_USER
GO
ALTER DATABASE [Book] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Book] SET DB_CHAINING OFF
GO
USE [Book]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 06/21/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [varchar](10) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Cover] [varchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[CreateTime] [date] NULL,
	[LastUpdateTime] [date] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role]    Script Date: 06/21/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [varchar](10) NOT NULL,
	[RoleType] [int] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 06/21/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [varchar](10) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreateTime] [date] NULL,
	[LastUpdateTime] [date] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spGetAuthor]    Script Date: 06/21/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL

CREATE PROCEDURE [dbo].[spGetAuthor] 

AS
BEGIN
	SELECT A.Id,A.Description,A.Title,A.CreateTime,A.LastUpdateTime 
	From [Author] as A
END
GO
/****** Object:  Table [dbo].[Book]    Script Date: 06/21/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [varchar](10) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Author] [varchar](10) NOT NULL,
	[Cover] [varchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Publisher] [varchar](50) NULL,
	[CategoryId] [varchar](10) NULL,
	[Year] [int] NULL,
	[CreateTime] [date] NULL,
	[LastUpdateTime] [date] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 06/21/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [varchar](10) NOT NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Role] [varchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spGetCategory]    Script Date: 06/21/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL

CREATE PROCEDURE [dbo].[spGetCategory] 

AS
BEGIN
	SELECT C.Id,C.Title,C.Description,C.CreateTime,C.LastUpdateTime
	From [Category] as C
END
GO
/****** Object:  StoredProcedure [dbo].[spGetBooks]    Script Date: 06/21/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL

CREATE PROCEDURE [dbo].[spGetBooks] 

AS
BEGIN
	SELECT B.Id,B.Title,B.Cover,B.Description,B.Year,B.CreateTime,B.LastUpdateTime,B.Author,B.CategoryId  From [Book] as B
END
GO
/****** Object:  ForeignKey [FK_Book_Author]    Script Date: 06/21/2017 00:19:35 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([Author])
REFERENCES [dbo].[Author] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
/****** Object:  ForeignKey [FK_Book_Category]    Script Date: 06/21/2017 00:19:35 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category]
GO
/****** Object:  ForeignKey [FK_User_Role]    Script Date: 06/21/2017 00:19:35 ******/
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([Role])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
