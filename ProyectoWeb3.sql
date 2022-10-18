USE [master]
GO
/****** Object:  Database [ProyectoWeb3]    Script Date: 18/10/2022 09:34:07 ******/
CREATE DATABASE [ProyectoWeb3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoWeb3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoWeb3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoWeb3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoWeb3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProyectoWeb3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoWeb3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoWeb3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoWeb3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoWeb3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoWeb3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoWeb3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoWeb3] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoWeb3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoWeb3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoWeb3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoWeb3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoWeb3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectoWeb3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProyectoWeb3] SET QUERY_STORE = OFF
GO
USE [ProyectoWeb3]
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 18/10/2022 09:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo](
	[IdGrupo] [int] IDENTITY(1,1) NOT NULL,
	[Grupo] [char](1) NOT NULL,
	[IdSeleccion1] [int] NOT NULL,
	[IdSeleccion2] [int] NOT NULL,
	[IdSeleccion3] [int] NOT NULL,
	[IdSeleccion4] [int] NOT NULL,
 CONSTRAINT [PK_Grupo] PRIMARY KEY CLUSTERED 
(
	[IdGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partido]    Script Date: 18/10/2022 09:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partido](
	[IdPartido] [int] IDENTITY(1,1) NOT NULL,
	[IdSeleccion1] [int] NOT NULL,
	[IdSeleccion2] [int] NOT NULL,
	[GolesSeleccion1] [int] NOT NULL,
	[GolesSeleccion2] [int] NOT NULL,
 CONSTRAINT [PK_Partido] PRIMARY KEY CLUSTERED 
(
	[IdPartido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seleccion]    Script Date: 18/10/2022 09:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seleccion](
	[IdSeleccion] [int] IDENTITY(1,1) NOT NULL,
	[Seleccion] [varchar](50) NOT NULL,
	[Confederacion] [varchar](50) NULL,
	[Clasificada] [bit] NULL,
 CONSTRAINT [PK_Seleccion] PRIMARY KEY CLUSTERED 
(
	[IdSeleccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 18/10/2022 09:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_SeleccionGrupo1] FOREIGN KEY([IdSeleccion1])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_SeleccionGrupo1]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_SeleccionGrupo2] FOREIGN KEY([IdSeleccion2])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_SeleccionGrupo2]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_SeleccionGrupo3] FOREIGN KEY([IdSeleccion3])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_SeleccionGrupo3]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_SeleccionGrupo4] FOREIGN KEY([IdSeleccion4])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_SeleccionGrupo4]
GO
ALTER TABLE [dbo].[Partido]  WITH CHECK ADD  CONSTRAINT [FK_Seleccion1] FOREIGN KEY([IdSeleccion1])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[Partido] CHECK CONSTRAINT [FK_Seleccion1]
GO
ALTER TABLE [dbo].[Partido]  WITH CHECK ADD  CONSTRAINT [FK_Seleccion2] FOREIGN KEY([IdSeleccion2])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[Partido] CHECK CONSTRAINT [FK_Seleccion2]
GO
USE [master]
GO
ALTER DATABASE [ProyectoWeb3] SET  READ_WRITE 
GO
INSERT INTO [dbo].[Seleccion]
           ([Seleccion]
           ,[Confederacion]
           ,[Clasificada])
     VALUES
           ('Brasil'
           ,'CONMEBOL'
           ,1),
		   ('Bolivia'
           ,'CONMEBOL'
           ,0),
		   ('Argentina'
           ,'CONMEBOL'
           ,1),
		   ('Chile'
           ,'CONMEBOL'
           ,0),
		   ('Colombia'
           ,'CONMEBOL'
           ,0),
		   ('Ecuador'
           ,'CONMEBOL'
           ,1),
		   ('Uruguay'
           ,'CONMEBOL'
           ,1),
		   ('Peru'
           ,'CONMEBOL'
           ,1),
		   ('Venezuela'
           ,'CONMEBOL'
           ,1),
		   ('Paraguay'
           ,'CONMEBOL'
           ,0),
		   ('Qatar'
           ,'AFC'
           ,1),
		   ('Alemania'
           ,'UEFA'
           ,1),
		   ('Dinamarca'
           ,'UEFA'
           ,1),
		   ('Francia'
           ,'UEFA'
           ,1),
		   ('Belgica'
           ,'UEFA'
           ,1),
		   ('Croacia'
           ,'UEFA'
           ,1),
		   ('España'
           ,'UEFA'
           ,1),
		   ('Serbia'
           ,'UEFA'
           ,1),
		   ('Inglaterra'
           ,'UEFA'
           ,1),
		    ('Suiza'
           ,'UEFA'
           ,1),
		   	('Holanda'
           ,'UEFA'
           ,1),
		   ('Iran'
           ,'AFC'
           ,1),
		   ('Corea del Sur'
           ,'AFC'
           ,1),
		   ('Japon'
           ,'AFC'
           ,1),
		   ('Arabia Saudi'
           ,'AFC'
           ,1),
		   ('Canada'
           ,'CONCACAF'
           ,1),
		   ('Estados Unidos'
           ,'CONCACAF'
           ,1),
		   ('Mexico'
           ,'CONCACAF'
           ,1),
		   ('Ghana'
           ,'CAF'
           ,1),
		   ('Senegal'
           ,'CAF'
           ,1),
		   ('Polonia'
           ,'UEFA'
           ,1),
		   ('Portugal'
           ,'UEFA'
           ,1),
		   ('Tunez'
           ,'CAF'
           ,1),
		   ('Marruecos'
           ,'CAF'
           ,1),
		   ('Camerun'
           ,'CAF'
           ,1),
		   ('Gales'
           ,'UEFA'
           ,1),
		   ('Australia'
           ,'AFC'
           ,1),
		   ('Escocia'
           ,'UEFA'
           ,0),
		   ('Italia'
           ,'UEFA'
           ,0),
		   ('Suecia'
           ,'UEFA'
           ,0),
		   ('Macedonia'
           ,'UEFA'
           ,0),
		   ('Turquia'
           ,'UEFA'
           ,0),
		   ('Rusia'
           ,'UEFA'
           ,0),
		   ('Honduras'
           ,'CONCACAF'
           ,0),
		   ('Costa Rica'
           ,'CONCACAF'
           ,1)
GO


INSERT INTO Grupo (Grupo,IdSeleccion1,IdSeleccion2, IdSeleccion3, IdSeleccion4) VALUES
					('A',11,6,30,21),('B',19,22,27,36),('C',3,25,28,31),('D',14,37,13,33),('E',17,46,12,24),('F',15,26,34,16),('G',1,18,20,35),('H',32,29,7,23);
GO

--SELECT * FROM Seleccion;

--SELECT * FROM Grupo;