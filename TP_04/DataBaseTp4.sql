USE [master]
GO
/****** Object:  Database [HELADERIA_DB]    Script Date: 20/6/2022 02:50:53 ******/
CREATE DATABASE [HELADERIA_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HELADERIA_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER06\MSSQL\DATA\HELADERIA_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HELADERIA_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER06\MSSQL\DATA\HELADERIA_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HELADERIA_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HELADERIA_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HELADERIA_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HELADERIA_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HELADERIA_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HELADERIA_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HELADERIA_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [HELADERIA_DB] SET  MULTI_USER 
GO
ALTER DATABASE [HELADERIA_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HELADERIA_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HELADERIA_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HELADERIA_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HELADERIA_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HELADERIA_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HELADERIA_DB', N'ON'
GO
ALTER DATABASE [HELADERIA_DB] SET QUERY_STORE = OFF
GO
USE [HELADERIA_DB]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 20/6/2022 02:50:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[numSocio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[alta] [date] NOT NULL,
	[estaActivo] [bit] NOT NULL,
 CONSTRAINT [PK_CLIENTES_1] PRIMARY KEY CLUSTERED 
(
	[numSocio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CLIENTES] ON 

INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (1, N'Blanca', N'Miguez', 43678874, CAST(N'2022-04-04' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (2, N'Marcelo', N'Dominguez', 26446005, CAST(N'2022-05-26' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (4, N'Lililana', N'Cordero', 38214362, CAST(N'2022-02-27' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (5, N'Blas', N'Llorens', 24703867, CAST(N'2022-05-22' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (6, N'Rosa', N'Prada', 30890986, CAST(N'2022-03-25' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (7, N'Moisés', N'Luque', 38893602, CAST(N'2022-04-15' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (8, N'Camila', N'Viña', 31789732, CAST(N'2022-03-12' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (9, N'Silvia', N'Cordero', 22587685, CAST(N'2022-05-11' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (10, N'Ángel', N'Ripoll', 40861760, CAST(N'2022-05-09' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (11, N'Alba', N'Miguez', 46281035, CAST(N'2022-03-22' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (12, N'Camila', N'Luque', 15782926, CAST(N'2022-05-15' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (13, N'Silvia', N'Echevarría', 43935298, CAST(N'2022-04-30' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (14, N'Ariel', N'Ponce', 25746167, CAST(N'2022-05-10' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (15, N'Miguel', N'Ortiz', 20552795, CAST(N'2022-04-06' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (16, N'Blas', N'Ripoll', 37772337, CAST(N'2022-06-01' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (17, N'Lililana', N'Mosquera', 24472362, CAST(N'2022-05-09' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (18, N'Miguel', N'Cortez', 24526477, CAST(N'2022-04-17' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (19, N'Miguel', N'Benitez', 14390030, CAST(N'2022-04-08' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (20, N'Emiliano', N'Heredia', 35699044, CAST(N'2022-05-11' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (21, N'Lililana', N'Prada', 14801716, CAST(N'2022-03-26' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (22, N'Ángel', N'Ortiz', 37371782, CAST(N'2022-04-19' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (23, N'Manuel', N'Luque', 18768882, CAST(N'2022-04-30' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (24, N'Ángel', N'Soto', 42027190, CAST(N'2022-05-29' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (25, N'José', N'Heredia', 16471226, CAST(N'2022-04-11' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (26, N'Brunilda', N'Garcia', 11847536, CAST(N'2022-05-25' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (27, N'Miguel', N'Galán', 16896633, CAST(N'2022-04-30' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (28, N'ViViana', N'Miguez', 22604270, CAST(N'2022-05-26' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (29, N'Lililana', N'Ponce', 17880879, CAST(N'2022-05-16' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (30, N'Rosa', N'Miralles', 32851970, CAST(N'2022-03-27' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (31, N'Ariel', N'Garcia', 29353973, CAST(N'2022-04-04' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (32, N'Alba', N'Ortiz', 45848496, CAST(N'2022-05-09' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (33, N'Manuel', N'Ponce', 14658016, CAST(N'2022-03-12' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (34, N'Leo', N'Sandoval', 47270401, CAST(N'2022-04-04' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (35, N'Alba', N'Miguez', 29696948, CAST(N'2022-04-17' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (36, N'Lililana', N'Mosquera', 14827968, CAST(N'2022-05-28' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (37, N'ViViana', N'Frutos', 11887562, CAST(N'2022-04-20' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (38, N'Ámbar', N'Leocadio', 27594375, CAST(N'2022-03-14' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (39, N'Valeria', N'Cortez', 45572170, CAST(N'2022-03-02' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (40, N'Blas', N'Bello', 35605437, CAST(N'2022-05-27' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (41, N'Lina', N'Prada', 41960085, CAST(N'2022-05-22' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (42, N'Blas', N'Llorens', 15410381, CAST(N'2022-05-16' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (43, N'Rodrigo', N'Leocadio', 43408881, CAST(N'2022-04-24' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (44, N'Emiliano', N'Prada', 40550827, CAST(N'2022-03-22' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (45, N'Ámbar', N'Ponce', 25625983, CAST(N'2022-03-14' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (46, N'Teobaldo', N'Mendizábal', 24812577, CAST(N'2022-06-01' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (47, N'Victoria', N'Córdoba', 18141343, CAST(N'2022-04-08' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (48, N'Ámbar', N'Mendizábal', 45937848, CAST(N'2022-05-03' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (49, N'Alba', N'Cordero', 30396637, CAST(N'2022-04-23' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (50, N'Rosa', N'Llorens', 12669902, CAST(N'2022-03-13' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (51, N'Florencia', N'Cortez', 15698494, CAST(N'2022-04-23' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (52, N'Pedro', N'Palma', 53876276, CAST(N'2022-06-05' AS Date), 0)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (53, N'José', N'Serra', 44635294, CAST(N'2022-04-04' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (54, N'Rosa', N'Serra', 39903005, CAST(N'2022-04-30' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (55, N'Silvia', N'Llorens', 43566550, CAST(N'2022-06-02' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (56, N'Emiliano', N'Bello', 38733375, CAST(N'2022-04-13' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (57, N'Silvia', N'Serra', 27374771, CAST(N'2022-06-09' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (58, N'Mateo', N'Miralles', 24370084, CAST(N'2022-06-09' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (59, N'Blas', N'Córdoba', 44669533, CAST(N'2022-05-16' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (60, N'Marcelo', N'Benitez', 37960276, CAST(N'2022-03-13' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (61, N'Miguel', N'Ortiz', 36250747, CAST(N'2022-05-12' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (62, N'Florencia', N'Galán', 32170366, CAST(N'2022-03-14' AS Date), 1)
INSERT [dbo].[CLIENTES] ([numSocio], [nombre], [apellido], [dni], [alta], [estaActivo]) VALUES (63, N'Blas', N'Llorens', 32587521, CAST(N'2022-05-24' AS Date), 1)
SET IDENTITY_INSERT [dbo].[CLIENTES] OFF
GO
USE [master]
GO
ALTER DATABASE [HELADERIA_DB] SET  READ_WRITE 
GO
