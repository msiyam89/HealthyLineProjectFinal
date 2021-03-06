USE [master]
GO
/****** Object:  Database [HealtyLine]    Script Date: 5/4/2020 11:28:58 PM ******/
CREATE DATABASE [HealtyLine]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HealtyLine', FILENAME = N'E:\SQL\MSSQL13.MSIYAM\MSSQL\DATA\HealtyLine.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HealtyLine_log', FILENAME = N'E:\SQL\MSSQL13.MSIYAM\MSSQL\DATA\HealtyLine_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HealtyLine] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HealtyLine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HealtyLine] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HealtyLine] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HealtyLine] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HealtyLine] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HealtyLine] SET ARITHABORT OFF 
GO
ALTER DATABASE [HealtyLine] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HealtyLine] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HealtyLine] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HealtyLine] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HealtyLine] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HealtyLine] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HealtyLine] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HealtyLine] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HealtyLine] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HealtyLine] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HealtyLine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HealtyLine] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HealtyLine] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HealtyLine] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HealtyLine] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HealtyLine] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HealtyLine] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HealtyLine] SET RECOVERY FULL 
GO
ALTER DATABASE [HealtyLine] SET  MULTI_USER 
GO
ALTER DATABASE [HealtyLine] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HealtyLine] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HealtyLine] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HealtyLine] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HealtyLine] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HealtyLine', N'ON'
GO
ALTER DATABASE [HealtyLine] SET QUERY_STORE = OFF
GO
USE [HealtyLine]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [HealtyLine]
GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserEmail] [nvarchar](500) NULL,
	[UserFullNameArabic] [nvarchar](500) NULL,
	[UserFullNameEnglish] [nvarchar](500) NULL,
	[UserName] [nvarchar](500) NULL,
	[Message] [nvarchar](max) NULL,
	[IsRegistered] [bit] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_ContactUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diseases]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diseases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameArabic] [nvarchar](500) NULL,
	[NameEnglish] [nvarchar](500) NULL,
 CONSTRAINT [PK_Diseases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodMainCategories]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodMainCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameArabic] [nvarchar](500) NULL,
	[NameEnglish] [nvarchar](500) NULL,
 CONSTRAINT [PK_FoodMainCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodSubCategories]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodSubCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FoodMainCategoryId] [int] NULL,
	[NameArabic] [nvarchar](500) NULL,
	[NameEnglish] [nvarchar](500) NULL,
 CONSTRAINT [PK_FoodSubCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipes]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameArabic] [nvarchar](500) NULL,
	[NameEnglish] [nvarchar](500) NULL,
 CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipesIngredients]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipesIngredients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecipeId] [int] NULL,
	[Ingredients] [nvarchar](500) NULL,
 CONSTRAINT [PK_RecipesIngredients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipesSteps]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipesSteps](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecipeId] [int] NULL,
	[Details] [nvarchar](max) NULL,
 CONSTRAINT [PK_RecipesSteps] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDeseases]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDeseases](
	[Id] [int] NOT NULL,
	[ProfileId] [int] NULL,
	[DiseasesId] [int] NULL,
 CONSTRAINT [PK_UserDeseases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 5/4/2020 11:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullNameArabic] [nvarchar](500) NULL,
	[FullNameEnglish] [nvarchar](500) NULL,
	[Gender] [bit] NULL,
	[Birthdate] [datetime] NULL,
	[Email] [nvarchar](200) NULL,
	[MobileNumber] [nvarchar](200) NULL,
	[CurrentWeight] [float] NULL,
	[TargetWeight] [float] NULL,
	[Height] [float] NULL,
	[IdealWeight] [float] NULL,
	[CreateBy] [nvarchar](100) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdateDate] [datetime] NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FoodSubCategories]  WITH CHECK ADD  CONSTRAINT [FK_FoodSubCategories_FoodMainCategories] FOREIGN KEY([FoodMainCategoryId])
REFERENCES [dbo].[FoodMainCategories] ([Id])
GO
ALTER TABLE [dbo].[FoodSubCategories] CHECK CONSTRAINT [FK_FoodSubCategories_FoodMainCategories]
GO
ALTER TABLE [dbo].[RecipesIngredients]  WITH CHECK ADD  CONSTRAINT [FK_RecipesIngredients_Recipes] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([Id])
GO
ALTER TABLE [dbo].[RecipesIngredients] CHECK CONSTRAINT [FK_RecipesIngredients_Recipes]
GO
ALTER TABLE [dbo].[RecipesSteps]  WITH CHECK ADD  CONSTRAINT [FK_RecipesSteps_Recipes] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([Id])
GO
ALTER TABLE [dbo].[RecipesSteps] CHECK CONSTRAINT [FK_RecipesSteps_Recipes]
GO
ALTER TABLE [dbo].[UserDeseases]  WITH CHECK ADD  CONSTRAINT [FK_UserDeseases_Diseases] FOREIGN KEY([DiseasesId])
REFERENCES [dbo].[Diseases] ([Id])
GO
ALTER TABLE [dbo].[UserDeseases] CHECK CONSTRAINT [FK_UserDeseases_Diseases]
GO
ALTER TABLE [dbo].[UserDeseases]  WITH CHECK ADD  CONSTRAINT [FK_UserDeseases_UserProfile] FOREIGN KEY([ProfileId])
REFERENCES [dbo].[UserProfile] ([Id])
GO
ALTER TABLE [dbo].[UserDeseases] CHECK CONSTRAINT [FK_UserDeseases_UserProfile]
GO
USE [master]
GO
ALTER DATABASE [HealtyLine] SET  READ_WRITE 
GO
