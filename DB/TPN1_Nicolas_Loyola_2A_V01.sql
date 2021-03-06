USE [master]
GO
/****** Object:  Database [TPN1_Nicolas_Loyola_2A]    Script Date: 19/9/2021 13:47:40 ******/
CREATE DATABASE [TPN1_Nicolas_Loyola_2A]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TPN1_Nicolas_Loyola_2A', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TPN1_Nicolas_Loyola_2A.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TPN1_Nicolas_Loyola_2A_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TPN1_Nicolas_Loyola_2A_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPN1_Nicolas_Loyola_2A].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET  MULTI_USER 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET QUERY_STORE = OFF
GO
USE [TPN1_Nicolas_Loyola_2A]
GO
/****** Object:  Table [dbo].[Deportista]    Script Date: 19/9/2021 13:47:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportista](
	[NroSocio] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[FechaNac] [date] NULL,
	[Entrenador_Legajo] [int] NULL,
	[Medallas] [int] NULL,
 CONSTRAINT [PK_Deportista] PRIMARY KEY CLUSTERED 
(
	[NroSocio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejercicio]    Script Date: 19/9/2021 13:47:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicio](
	[Id_ejercicio] [int] NOT NULL,
	[Detalle] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[Id_ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrenador]    Script Date: 19/9/2021 13:47:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrenador](
	[Legajo] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
 CONSTRAINT [PK_Entrenador] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rutina]    Script Date: 19/9/2021 13:47:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutina](
	[Cod_Rutina] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Deportista_NroSocio] [int] NOT NULL,
 CONSTRAINT [PK_Cod_Rutina] PRIMARY KEY CLUSTERED 
(
	[Cod_Rutina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rutina_Ejercicio]    Script Date: 19/9/2021 13:47:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutina_Ejercicio](
	[Cod_Rutina] [int] NOT NULL,
	[Id_Ejercicio] [int] NOT NULL,
 CONSTRAINT [PK_Rutina_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[Cod_Rutina] ASC,
	[Id_Ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Deportista] ([NroSocio], [Nombre], [Apellido], [FechaNac], [Entrenador_Legajo], [Medallas]) VALUES (1, N'Matias', N'Gonzalez', CAST(N'1991-05-05' AS Date), 123, NULL)
GO
INSERT [dbo].[Ejercicio] ([Id_ejercicio], [Detalle]) VALUES (1, N'Sentadillas')
INSERT [dbo].[Ejercicio] ([Id_ejercicio], [Detalle]) VALUES (2, N'Abdominales Laterales')
INSERT [dbo].[Ejercicio] ([Id_ejercicio], [Detalle]) VALUES (3, N'Press con mancuernas')
GO
INSERT [dbo].[Entrenador] ([Legajo], [Nombre], [Apellido]) VALUES (123, N'Pepe', N'Martinez')
INSERT [dbo].[Entrenador] ([Legajo], [Nombre], [Apellido]) VALUES (124, N'Nico', N'Loyola')
GO
SET IDENTITY_INSERT [dbo].[Rutina] ON 

INSERT [dbo].[Rutina] ([Cod_Rutina], [Descripcion], [Deportista_NroSocio]) VALUES (1, N'Rutina Nico 1', 1)
SET IDENTITY_INSERT [dbo].[Rutina] OFF
GO
ALTER TABLE [dbo].[Deportista]  WITH CHECK ADD  CONSTRAINT [FK_Deportista_Entrenador] FOREIGN KEY([Entrenador_Legajo])
REFERENCES [dbo].[Entrenador] ([Legajo])
GO
ALTER TABLE [dbo].[Deportista] CHECK CONSTRAINT [FK_Deportista_Entrenador]
GO
ALTER TABLE [dbo].[Rutina]  WITH CHECK ADD  CONSTRAINT [FK_Rutina_Deportista] FOREIGN KEY([Deportista_NroSocio])
REFERENCES [dbo].[Deportista] ([NroSocio])
GO
ALTER TABLE [dbo].[Rutina] CHECK CONSTRAINT [FK_Rutina_Deportista]
GO
ALTER TABLE [dbo].[Rutina_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Rutina_Ejercicio_Ejercicio] FOREIGN KEY([Id_Ejercicio])
REFERENCES [dbo].[Ejercicio] ([Id_ejercicio])
GO
ALTER TABLE [dbo].[Rutina_Ejercicio] CHECK CONSTRAINT [FK_Rutina_Ejercicio_Ejercicio]
GO
ALTER TABLE [dbo].[Rutina_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_RutinaEjer_Rutina] FOREIGN KEY([Cod_Rutina])
REFERENCES [dbo].[Rutina] ([Cod_Rutina])
GO
ALTER TABLE [dbo].[Rutina_Ejercicio] CHECK CONSTRAINT [FK_RutinaEjer_Rutina]
GO
USE [master]
GO
ALTER DATABASE [TPN1_Nicolas_Loyola_2A] SET  READ_WRITE 
GO
