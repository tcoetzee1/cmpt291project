USE [master]
GO
/****** Object:  Database [Project291]    Script Date: 2018-06-06 10:20:04 PM ******/
CREATE DATABASE [Project291]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project291', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Project291.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Project291_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Project291_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Project291] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project291].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project291] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project291] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project291] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project291] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project291] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project291] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project291] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project291] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project291] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project291] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project291] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project291] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project291] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project291] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project291] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Project291] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project291] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project291] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project291] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project291] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project291] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project291] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project291] SET RECOVERY FULL 
GO
ALTER DATABASE [Project291] SET  MULTI_USER 
GO
ALTER DATABASE [Project291] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project291] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project291] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project291] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Project291] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project291', N'ON'
GO
USE [Project291]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 2018-06-06 10:20:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[BID] [int] NOT NULL,
	[location] [nchar](15) NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Car]    Script Date: 2018-06-06 10:20:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[VID] [int] NOT NULL,
	[Type_ID] [int] NULL,
	[BID] [int] NULL,
	[Miles] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[VID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CarType]    Script Date: 2018-06-06 10:20:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarType](
	[Type_ID] [int] NOT NULL,
	[Price] [int] NULL,
	[car_type_name] [nchar](10) NULL,
 CONSTRAINT [PK_CarType] PRIMARY KEY CLUSTERED 
(
	[Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2018-06-06 10:20:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [nchar](50) NULL,
	[LName] [nchar](50) NULL,
	[City] [nchar](50) NULL,
	[Street] [nchar](50) NULL,
	[Postal_Code] [nchar](20) NULL,
	[Credit_Card] [nchar](20) NULL,
	[Goldstar] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2018-06-06 10:20:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EID] [int] NOT NULL,
	[FName] [nchar](15) NULL,
	[LName] [nchar](15) NULL,
	[City] [nchar](15) NULL,
	[start_date] [nchar](15) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentalHistory]    Script Date: 2018-06-06 10:20:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalHistory](
	[Transaction_ID] [int] NOT NULL,
	[CID] [int] NULL,
	[EID] [int] NULL,
	[from_BID] [int] NULL,
	[delivered_to_BID] [int] NULL,
	[checkin_date] [nchar](10) NULL,
	[rental_duration] [nchar](10) NULL,
	[late_fee] [int] NULL,
	[checkout_date] [nchar](10) NULL,
	[booking_status] [int] NULL,
	[real_checkout_date] [nchar](10) NULL,
	[VID] [nchar](10) NULL,
 CONSTRAINT [PK_RentalHistory] PRIMARY KEY CLUSTERED 
(
	[Transaction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Branch] ([BID], [location]) VALUES (1, N'Calgary        ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (2, N'Edmonton       ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (3, N'Vancouver      ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (4, N'New York City  ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (5, N'Seattle        ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (6, N'Red Deer       ')
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (11, 1, 1, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (12, 1, 2, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (13, 1, 3, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (14, 2, 4, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (15, 2, 5, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (16, 2, 6, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (17, 3, 1, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (18, 3, 2, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (19, 3, 3, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (20, 4, 4, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (21, 4, 5, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (22, 4, 6, 10000)
INSERT [dbo].[CarType] ([Type_ID], [Price], [car_type_name]) VALUES (1, 500, N'Car       ')
INSERT [dbo].[CarType] ([Type_ID], [Price], [car_type_name]) VALUES (2, 600, N'SUV       ')
INSERT [dbo].[CarType] ([Type_ID], [Price], [car_type_name]) VALUES (3, 700, N'Truck     ')
INSERT [dbo].[CarType] ([Type_ID], [Price], [car_type_name]) VALUES (4, 800, N'Sports Car')
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CID], [FName], [LName], [City], [Street], [Postal_Code], [Credit_Card], [Goldstar]) VALUES (77782, N'Eric                                              ', N'Smith                                             ', N'Calgary                                           ', N'123 Fake Street                                   ', N'T1S 1A5             ', N'1234-1234-1234-1234 ', 0)
INSERT [dbo].[Customer] ([CID], [FName], [LName], [City], [Street], [Postal_Code], [Credit_Card], [Goldstar]) VALUES (77783, N'Sam                                               ', N'Pools                                             ', N'Edmonton                                          ', N'7905 78 Street                                    ', N'T0E 1K8             ', N'2345-3456-4567-5678 ', 0)
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Employee] ([EID], [FName], [LName], [City], [start_date]) VALUES (8888, N'Mark           ', N'Roberts        ', N'Calgary        ', N'2009           ')
INSERT [dbo].[Employee] ([EID], [FName], [LName], [City], [start_date]) VALUES (8889, N'Fred           ', N'Holder         ', N'Edmonton       ', N'2013           ')
INSERT [dbo].[RentalHistory] ([Transaction_ID], [CID], [EID], [from_BID], [delivered_to_BID], [checkin_date], [rental_duration], [late_fee], [checkout_date], [booking_status], [real_checkout_date], [VID]) VALUES (3566, 77782, 8888, 1, 1, N'6/9/2017  ', N'monthly   ', 0, N'6/18/2017 ', 1, N'6/18/2017 ', N'11        ')
USE [master]
GO
ALTER DATABASE [Project291] SET  READ_WRITE 
GO
