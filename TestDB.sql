USE [master]
GO
/****** Object:  Database [TestDB]    Script Date: 7/10/2022 2:14:30 PM ******/
CREATE DATABASE [TestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TestDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TestDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TestDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TestDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TestDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TestDB] SET  MULTI_USER 
GO
ALTER DATABASE [TestDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TestDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TestDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TestDB] SET QUERY_STORE = OFF
GO
USE [TestDB]
GO
/****** Object:  Table [dbo].[TodoAttachment]    Script Date: 7/10/2022 2:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodoAttachment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TodoID] [int] NOT NULL,
	[FilePath] [varchar](500) NOT NULL,
	[FileTitle] [varchar](500) NOT NULL,
	[FileExtension] [varchar](10) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TodoAttachment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TodoMaster]    Script Date: 7/10/2022 2:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodoMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](200) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[AssignedTo] [varchar](50) NULL,
	[AssignedOn] [datetime] NULL,
	[FeedBack] [varchar](200) NULL,
 CONSTRAINT [PK_TodoMaster] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 7/10/2022 2:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserPassword] [varchar](max) NOT NULL,
	[CIF] [varchar](50) NOT NULL,
	[FullName] [varchar](300) NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[MobileNo] [varchar](20) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TodoMaster] ON 

INSERT [dbo].[TodoMaster] ([ID], [Title], [Status], [CreatedOn], [CreatedBy], [AssignedTo], [AssignedOn], [FeedBack]) VALUES (1, N'Task 1', N'In Progress', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'Shourav', N'Shourav', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'')
INSERT [dbo].[TodoMaster] ([ID], [Title], [Status], [CreatedOn], [CreatedBy], [AssignedTo], [AssignedOn], [FeedBack]) VALUES (2, N'Task 2', N'In Progress', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'Shourav', N'Shourav', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'')
INSERT [dbo].[TodoMaster] ([ID], [Title], [Status], [CreatedOn], [CreatedBy], [AssignedTo], [AssignedOn], [FeedBack]) VALUES (3, N'Task 3', N'In Progress', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'Shourav', N'Shourav', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'')
INSERT [dbo].[TodoMaster] ([ID], [Title], [Status], [CreatedOn], [CreatedBy], [AssignedTo], [AssignedOn], [FeedBack]) VALUES (4, N'Task 4', N'New', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'Shourav', N'Shourav', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'')
INSERT [dbo].[TodoMaster] ([ID], [Title], [Status], [CreatedOn], [CreatedBy], [AssignedTo], [AssignedOn], [FeedBack]) VALUES (5, N'Task 5', N'New', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'Shourav', N'Shourav', CAST(N'2022-07-08T14:56:03.953' AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[TodoMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[UserAccount] ON 

INSERT [dbo].[UserAccount] ([ID], [UserName], [UserPassword], [CIF], [FullName], [Email], [MobileNo], [Gender], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy]) VALUES (8, N'Shourav', N'rPQdQ4e9F8E=', N'00.321', N'Shourav Kumar', N'shourav45@gmail.com', N'01675431289', N'Male', CAST(N'2022-07-08T08:06:30.833' AS DateTime), N'string', CAST(N'2022-07-08T08:06:30.833' AS DateTime), N'NULL')
SET IDENTITY_INSERT [dbo].[UserAccount] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Unique_UserName_UserAccount]    Script Date: 7/10/2022 2:14:30 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Unique_UserName_UserAccount] ON [dbo].[UserAccount]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TodoAttachment] ADD  CONSTRAINT [DF_TodoAttachment_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[TodoMaster] ADD  CONSTRAINT [DF_TodoMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[UserAccount] ADD  CONSTRAINT [DF_UserAccount_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
/****** Object:  StoredProcedure [dbo].[getTodoListByStatus]    Script Date: 7/10/2022 2:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<SHOURAV KUMAR BISWAS>
-- Create date: <08 JUL 2022>
-- Description:	<Description,,>
-- EXEC getTodoListByStatus 'NeW'
-- =============================================
CREATE PROCEDURE [dbo].[getTodoListByStatus]
(
 @TodoStatus varchar(50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT A.* from TodoMaster A
	WHERE A.Status = @TodoStatus
END
GO
/****** Object:  StoredProcedure [dbo].[getUserAccount]    Script Date: 7/10/2022 2:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<SHOURAV KUMAR BISWAS>
-- Create date: <08 JUL 2022>
-- Description:	<Description,,>
-- EXEC getUserAccount 'Shourav'
-- =============================================
CREATE PROCEDURE [dbo].[getUserAccount]
(
 @UserName varchar(50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT A.* from UserAccount A
	WHERE A.UserName = @UserName
END
GO
USE [master]
GO
ALTER DATABASE [TestDB] SET  READ_WRITE 
GO
