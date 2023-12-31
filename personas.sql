USE [master]
GO
/****** Object:  Database [Personas]    Script Date: 2/10/2023 16:55:36 ******/
CREATE DATABASE [Personas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Personas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Personas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Personas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Personas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Personas] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Personas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Personas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Personas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Personas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Personas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Personas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Personas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Personas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Personas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Personas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Personas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Personas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Personas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Personas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Personas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Personas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Personas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Personas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Personas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Personas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Personas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Personas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Personas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Personas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Personas] SET  MULTI_USER 
GO
ALTER DATABASE [Personas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Personas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Personas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Personas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Personas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Personas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Personas] SET QUERY_STORE = ON
GO
ALTER DATABASE [Personas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Personas]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 2/10/2023 16:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](25) NULL,
	[Apellido] [nchar](25) NULL,
	[Direccion] [nchar](25) NULL,
	[Edad] [int] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetAll]    Script Date: 2/10/2023 16:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAll] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select * from Persona
END
GO
/****** Object:  StoredProcedure [dbo].[UsuarioAdd]    Script Date: 2/10/2023 16:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UsuarioAdd]
	-- Add the parameters for the stored procedure here
	@Nombre as nvarchar(50),
	@Apellido as nvarchar(50),
	@Direccion as nvarchar(50),
	@Edad as int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	Insert Into Persona (Nombre, Apellido, Direccion, Edad)
	Values (@Nombre, @Apellido, @Direccion, @Edad)
END
GO
/****** Object:  StoredProcedure [dbo].[UsuarioDeleteByID]    Script Date: 2/10/2023 16:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UsuarioDeleteByID]
	-- Add the parameters for the stored procedure here
	@ID as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Persona where id= @id
END
GO
/****** Object:  StoredProcedure [dbo].[UsuarioUpdate]    Script Date: 2/10/2023 16:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UsuarioUpdate] 
	-- Add the parameters for the stored procedure here
	@ID as int,
	@Nombre as nvarchar(50),
	@Apellido as nvarchar(50),
	@Direccion as nvarchar(50),
	@Edad as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Persona set nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, edad = @edad where id = @ID
END
GO
USE [master]
GO
ALTER DATABASE [Personas] SET  READ_WRITE 
GO
