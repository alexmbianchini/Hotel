USE [master]
GO
/****** Object:  Database [db_a7b7c9_hotel]    Script Date: 2/11/2021 16:17:21 ******/
CREATE DATABASE [db_a7b7c9_hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_a78fa0_hotel_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_a7b7c9_hotel_data.mdf' , SIZE = 8192KB , MAXSIZE = 1024000KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'db_a78fa0_hotel_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_a7b7c9_hotel_log.ldf' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_a7b7c9_hotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_a7b7c9_hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_a7b7c9_hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET  MULTI_USER 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_a7b7c9_hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_a7b7c9_hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_a7b7c9_hotel', N'ON'
GO
ALTER DATABASE [db_a7b7c9_hotel] SET QUERY_STORE = OFF
GO
USE [db_a7b7c9_hotel]
GO
/****** Object:  Table [dbo].[COCHERAS]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COCHERAS](
	[numero] [int] NOT NULL,
	[precio] [money] NULL,
	[descripcion] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_numero_cocheras] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUENTA]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUENTA](
	[id_cuenta] [int] NOT NULL,
	[fecha_hora_facturacion] [datetime] NULL,
	[id_reserva] [int] NULL,
	[id_tarjeta] [int] NULL,
	[id_usuario] [int] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_id_cuenta] PRIMARY KEY CLUSTERED 
(
	[id_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_RESERVA]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_RESERVA](
	[id_detalle] [int] NOT NULL,
	[id_reserva] [int] NOT NULL,
	[numero_habitacion] [int] NOT NULL,
	[precio_unitario_habitacion] [money] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [PK_COMPUESTA] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC,
	[id_reserva] ASC,
	[numero_habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_SERVICIOS_CUENTA]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_SERVICIOS_CUENTA](
	[nro_cuenta] [int] NULL,
	[nro_habitacion] [int] NULL,
	[cod_producto] [int] NULL,
	[precio_unitario] [money] NULL,
	[fecha_hora] [datetime] NULL,
	[borrado_logico] [int] NULL,
	[id_detalle] [int] NOT NULL,
 CONSTRAINT [pk_detalle_serv] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[id_empleado] [int] NOT NULL,
	[tipo_doc] [int] NULL,
	[nro_doc] [int] NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[fecha_ingreso_trabajo] [datetime] NULL,
	[fecha_salida_trabajo] [datetime] NULL,
	[puesto] [int] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_id_empleados] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO_COCHERA]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO_COCHERA](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [PK_id_estado_cochera] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO_HABITACION]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO_HABITACION](
	[idEstado] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_id_EstadoHabitacion] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO_RESERVA]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO_RESERVA](
	[id_estado] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_id_estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HABITACIONES]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HABITACIONES](
	[numero] [int] NOT NULL,
	[piso] [int] NULL,
	[tipo_habitacion] [int] NULL,
	[precio] [money] NULL,
	[borrado_logico] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_numero_habitaciones] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HUESPEDES]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUESPEDES](
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[pais_residencia] [int] NULL,
	[numero_pasaporte] [varchar](50) NOT NULL,
	[borrado_logico] [int] NULL,
	[id] [int] NOT NULL,
	[mail] [varchar](50) NULL,
 CONSTRAINT [PK_HUESPEDES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MENU]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENU](
	[codigo_producto] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[precio] [money] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_cod_menu] PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAISES]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAISES](
	[id] [int] NOT NULL,
	[acronimo] [varchar](5) NULL,
	[nombre] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_pais] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PISOS]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PISOS](
	[numero] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_numero_piso] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PUESTOS]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTOS](
	[cod_puesto] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_cod_puestos] PRIMARY KEY CLUSTERED 
(
	[cod_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RESERVA]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESERVA](
	[id_reserva] [int] NOT NULL,
	[fecha_hora_reserva] [datetime] NULL,
	[id_huesped] [int] NULL,
	[fecha_hora_ingreso_estimada] [datetime] NULL,
	[fecha_hora_ingreso_real] [datetime] NULL,
	[fecha_hora_salida_estimada] [datetime] NULL,
	[fecha_hora_salida_real] [datetime] NULL,
	[id_usuario] [int] NULL,
	[id_vehiculo] [int] NULL,
	[cantidad_personas] [int] NULL,
	[estado] [int] NULL,
	[numero_cochera] [int] NULL,
	[precio_unitario_cochera] [money] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_id_reserva] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SESION]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SESION](
	[id_sesion] [int] NOT NULL,
	[fecha_hora_inicio] [datetime] NULL,
	[fecha_hora_fin] [datetime] NULL,
	[id_usuario] [int] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_id_sesion] PRIMARY KEY CLUSTERED 
(
	[id_sesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TARJETAS]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TARJETAS](
	[id_tarjeta] [int] NOT NULL,
	[nro_tarjeta] [bigint] NULL,
	[cod_tipo_tarjeta] [int] NULL,
	[fecha_caducidad] [date] NULL,
	[id_huesped] [int] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_ro_tarjeta] PRIMARY KEY CLUSTERED 
(
	[id_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_DOCUMENTO]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_DOCUMENTO](
	[tipo_doc] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_tipo_doc] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_HABITACION]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_HABITACION](
	[cod_tipo] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
	[descripcion] [varchar](max) NULL,
 CONSTRAINT [pk_cod_tipoHabitacion] PRIMARY KEY CLUSTERED 
(
	[cod_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_TARJETA]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_TARJETA](
	[codigo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_cod_tipos_tarj] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[id] [int] NOT NULL,
	[password] [varchar](50) NULL,
	[salt] [varbinary](max) NULL,
	[nombre] [varchar](50) NULL,
	[id_empleado] [int] NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [pk_id_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VEHICULOS]    Script Date: 2/11/2021 16:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICULOS](
	[patente] [varchar](15) NOT NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[id_huesped] [int] NULL,
	[id] [int] NOT NULL,
	[borrado_logico] [int] NULL,
 CONSTRAINT [PK_VEHICULOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (1, 500.0000, N'Cochera 1', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (2, 500.0000, N'Cochera 2', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (3, 500.0000, N'Cochera 3', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (4, 500.0000, N'Cochera 4', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (5, 500.0000, N'Cochera 5', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (6, 500.0000, N'Cochera 6', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (7, 500.0000, N'Cochera 7', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (8, 500.0000, N'Cochera 8', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (9, 500.0000, N'Cochera 9', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (10, 500.0000, N'Cochera 10', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (11, 500.0000, N'Cochera 11', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (12, 500.0000, N'Cochera 12', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (13, 500.0000, N'Cochera 13', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (14, 500.0000, N'Cochera 14', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (15, 500.0000, N'Cochera 15', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (16, 500.0000, N'Cochera 16', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (17, 500.0000, N'Cochera 17', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (18, 500.0000, N'Cochera 18', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (19, 500.0000, N'Cochera 19', 0, 1)
INSERT [dbo].[COCHERAS] ([numero], [precio], [descripcion], [borrado_logico], [estado]) VALUES (20, 500.0000, N'Cochera 20', 0, 1)
GO
INSERT [dbo].[CUENTA] ([id_cuenta], [fecha_hora_facturacion], [id_reserva], [id_tarjeta], [id_usuario], [borrado_logico]) VALUES (1, CAST(N'2021-10-20T00:00:00.000' AS DateTime), 2, 1, 5, 0)
INSERT [dbo].[CUENTA] ([id_cuenta], [fecha_hora_facturacion], [id_reserva], [id_tarjeta], [id_usuario], [borrado_logico]) VALUES (2, CAST(N'2021-10-20T00:00:00.000' AS DateTime), 3, 2, 5, 0)
INSERT [dbo].[CUENTA] ([id_cuenta], [fecha_hora_facturacion], [id_reserva], [id_tarjeta], [id_usuario], [borrado_logico]) VALUES (3, CAST(N'2021-10-20T00:00:00.000' AS DateTime), 4, 1, 5, 0)
GO
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 2, 8, 28500.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 3, 10, 10000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 4, 1, 8000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 5, 7, 20000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 6, 1, 8000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 7, 3, 8000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 8, 10, 10000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (1, 9, 9, 35900.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (2, 3, 2, 40000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (2, 4, 3, 8000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (2, 5, 11, 65000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (2, 6, 6, 16000.0000, 0)
INSERT [dbo].[DETALLE_RESERVA] ([id_detalle], [id_reserva], [numero_habitacion], [precio_unitario_habitacion], [borrado_logico]) VALUES (2, 7, 6, 16000.0000, 0)
GO
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (1, 8, 2, 1800.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (1, 8, 17, 300.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 2)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (1, 8, 22, 1100.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 3)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (1, 8, 13, 350.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 4)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (2, 10, 2, 1800.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 5)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (2, 10, 5, 650.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 6)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (2, 10, 20, 4000.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 7)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (2, 10, 21, 180.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 8)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (2, 2, 17, 300.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 9)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (2, 2, 15, 300.0000, CAST(N'2021-10-19T00:00:00.000' AS DateTime), 0, 10)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 1, 6, 650.0000, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 0, 11)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 1, 5, 650.0000, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 0, 12)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 1, 14, 250.0000, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 0, 13)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 1, 14, 250.0000, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 0, 14)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 3, 14, 250.0000, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 0, 15)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 3, 14, 250.0000, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 0, 16)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 1, 18, 200.0000, CAST(N'2021-10-17T00:00:00.000' AS DateTime), 0, 17)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 1, 23, 1350.0000, CAST(N'2021-10-17T00:00:00.000' AS DateTime), 0, 18)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 3, 20, 4000.0000, CAST(N'2021-10-18T00:00:00.000' AS DateTime), 0, 19)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 3, 21, 180.0000, CAST(N'2021-10-18T00:00:00.000' AS DateTime), 0, 20)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 3, 17, 300.0000, CAST(N'2021-10-18T00:00:00.000' AS DateTime), 0, 21)
INSERT [dbo].[DETALLE_SERVICIOS_CUENTA] ([nro_cuenta], [nro_habitacion], [cod_producto], [precio_unitario], [fecha_hora], [borrado_logico], [id_detalle]) VALUES (3, 3, 10, 1500.0000, CAST(N'2021-10-18T00:00:00.000' AS DateTime), 0, 22)
GO
INSERT [dbo].[EMPLEADOS] ([id_empleado], [tipo_doc], [nro_doc], [apellido], [nombre], [fecha_ingreso_trabajo], [fecha_salida_trabajo], [puesto], [borrado_logico]) VALUES (1, 1, 41525402, N'Bianchini', N'Alex', CAST(N'2021-09-17T00:00:00.000' AS DateTime), NULL, 2, 0)
INSERT [dbo].[EMPLEADOS] ([id_empleado], [tipo_doc], [nro_doc], [apellido], [nombre], [fecha_ingreso_trabajo], [fecha_salida_trabajo], [puesto], [borrado_logico]) VALUES (2, 1, 90415789, N'OHurn', N'Brock', CAST(N'2021-09-17T00:00:00.000' AS DateTime), CAST(N'2021-09-17T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[EMPLEADOS] ([id_empleado], [tipo_doc], [nro_doc], [apellido], [nombre], [fecha_ingreso_trabajo], [fecha_salida_trabajo], [puesto], [borrado_logico]) VALUES (3, 5, 42156753, N'Cagol', N'Fabrizio', CAST(N'2021-09-17T00:00:00.000' AS DateTime), NULL, 2, 0)
INSERT [dbo].[EMPLEADOS] ([id_empleado], [tipo_doc], [nro_doc], [apellido], [nombre], [fecha_ingreso_trabajo], [fecha_salida_trabajo], [puesto], [borrado_logico]) VALUES (4, 1, 42531679, N'Reale', N'Lucia', CAST(N'2021-09-17T00:00:00.000' AS DateTime), NULL, 2, 0)
INSERT [dbo].[EMPLEADOS] ([id_empleado], [tipo_doc], [nro_doc], [apellido], [nombre], [fecha_ingreso_trabajo], [fecha_salida_trabajo], [puesto], [borrado_logico]) VALUES (5, 1, 90123789, N'Ohurn', N'Brock', CAST(N'2021-09-17T00:00:00.000' AS DateTime), NULL, 1, 0)
INSERT [dbo].[EMPLEADOS] ([id_empleado], [tipo_doc], [nro_doc], [apellido], [nombre], [fecha_ingreso_trabajo], [fecha_salida_trabajo], [puesto], [borrado_logico]) VALUES (6, 1, 89546123, N'Perez', N'Juan', CAST(N'2021-09-20T00:00:00.000' AS DateTime), NULL, 7, 0)
INSERT [dbo].[EMPLEADOS] ([id_empleado], [tipo_doc], [nro_doc], [apellido], [nombre], [fecha_ingreso_trabajo], [fecha_salida_trabajo], [puesto], [borrado_logico]) VALUES (7, 4, 43370172, N'Cagol', N'Franco', CAST(N'2021-10-03T00:00:00.000' AS DateTime), NULL, 9, 0)
GO
INSERT [dbo].[ESTADO_COCHERA] ([id], [nombre], [borrado_logico]) VALUES (1, N'Libre', 0)
INSERT [dbo].[ESTADO_COCHERA] ([id], [nombre], [borrado_logico]) VALUES (2, N'Ocupado', 0)
GO
INSERT [dbo].[ESTADO_HABITACION] ([idEstado], [descripcion], [borrado_logico]) VALUES (1, N'Libre', 0)
INSERT [dbo].[ESTADO_HABITACION] ([idEstado], [descripcion], [borrado_logico]) VALUES (2, N'Ocupada', 0)
GO
INSERT [dbo].[ESTADO_RESERVA] ([id_estado], [descripcion], [borrado_logico]) VALUES (1, N'Reservado', 0)
INSERT [dbo].[ESTADO_RESERVA] ([id_estado], [descripcion], [borrado_logico]) VALUES (2, N'Ingresado', 0)
INSERT [dbo].[ESTADO_RESERVA] ([id_estado], [descripcion], [borrado_logico]) VALUES (3, N'Terminado', 0)
INSERT [dbo].[ESTADO_RESERVA] ([id_estado], [descripcion], [borrado_logico]) VALUES (4, N'Cancelado', 0)
GO
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (1, 3, 1, 8000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (2, 2, 7, 40000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (3, 1, 1, 8000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (4, 5, 8, 65000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (5, 1, 2, 12000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (6, 3, 3, 16000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (7, 3, 4, 20000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (8, 4, 5, 28500.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (9, 4, 6, 35900.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (10, 2, 6, 10000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (11, 5, 8, 65000.0000, 0, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (12, 4, 3, 66000.0000, 1, 1)
INSERT [dbo].[HABITACIONES] ([numero], [piso], [tipo_habitacion], [precio], [borrado_logico], [estado]) VALUES (13, 5, 1, 230000.0000, 1, 1)
GO
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Mariana Romina', N'Benitez', 13, N'ARG123456', 1, 1, N'mari123@gmail.com')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Santiago', N'Bruno', 46, N'CHI567234', 1, 2, N'titi@gmail.com')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'sdfghj', N'asdfgh', 24, N'ARG567234', 1, 3, N'sdfghjk')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Santiago', N'Bruno', 46, N'CHI567234', 0, 4, N'titi@hotmail.com')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Cristian', N'Fernandez', 13, N'ARG123456', 0, 5, N'cristian@gmail.com')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Fabrtzio', N'Kagol', 13, N'ARG433701', 0, 6, N'fabtrizio@gmail.com')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Franko', N'Cagol', 13, N'ARG433700', 0, 7, N'frankko@hotmail.com')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Alex', N'Cagol', 13, N'ARG433703', 0, 8, N'nose@hotmail.com')
INSERT [dbo].[HUESPEDES] ([nombre], [apellido], [pais_residencia], [numero_pasaporte], [borrado_logico], [id], [mail]) VALUES (N'Florencia', N'Rodriguez', 13, N'ARG987654', 0, 9, N'flor@hotmail.com')
GO
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (1, N'Ensalada Camarón', 1200.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (2, N'Ensalada Camarón y Pulpo', 1800.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (3, N'Ensalada Pollo', 800.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (4, N'Sopa Marinera', 1500.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (5, N'Consome de Pollo', 650.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (6, N'Consome de Ternera', 650.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (7, N'Sopa de Pollo', 700.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (8, N'Chupe de Pescado', 900.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (9, N'Ceviche Camaron', 1200.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (10, N'Ceviche Pulpo', 1500.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (11, N'Ceviche Pescado', 1050.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (12, N'Ceviche Mixto c/Chifles y arroz', 1900.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (13, N'Jugo Natural 500cc', 350.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (14, N'Sushi Pieza', 250.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (15, N'Coca-Cola 500cc', 300.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (16, N'Sprite 500cc', 300.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (17, N'Sprite 500cc', 300.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (18, N'Agua Muneral Evian 500cc', 200.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (19, N'Champagne CRISTAL', 19000.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (20, N'2012 Hidden Story Gapsted', 4000.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (21, N'Café Cortado', 180.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (22, N'Hamburguesa completa', 1100.0000, 0)
INSERT [dbo].[MENU] ([codigo_producto], [descripcion], [precio], [borrado_logico]) VALUES (23, N'Pastas plato c/salsa', 1350.0000, 0)
GO
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (1, N'AF', N'Afganistán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (2, N'AX', N'Islas Gland', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (3, N'AL', N'Albania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (4, N'DE', N'Alemania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (5, N'AD', N'Andorra', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (6, N'AO', N'Angola', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (7, N'AI', N'Anguilla', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (8, N'AQ', N'Antártida', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (9, N'AG', N'Antigua y Barbuda', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (10, N'AN', N'Antillas Holandesas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (11, N'SA', N'Arabia Saudí', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (12, N'DZ', N'Argelia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (13, N'AR', N'Argentina', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (14, N'AM', N'Armenia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (15, N'AW', N'Aruba', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (16, N'AU', N'Australia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (17, N'AT', N'Austria', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (18, N'AZ', N'Azerbaiyán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (19, N'BS', N'Bahamas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (20, N'BH', N'Bahréin', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (21, N'BD', N'Bangladesh', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (22, N'BB', N'Barbados', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (23, N'BY', N'Bielorrusia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (24, N'BE', N'Bélgica', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (25, N'BZ', N'Belice', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (26, N'BJ', N'Benin', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (27, N'BM', N'Bermudas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (28, N'BT', N'Bhután', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (29, N'BO', N'Bolivia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (30, N'BA', N'Bosnia y Herzegovina', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (31, N'BW', N'Botsuana', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (32, N'BV', N'Isla Bouvet', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (33, N'BR', N'Brasil', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (34, N'BN', N'Brunéi', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (35, N'BG', N'Bulgaria', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (36, N'BF', N'Burkina Faso', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (37, N'BI', N'Burundi', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (38, N'CV', N'Cabo Verde', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (39, N'KY', N'Islas Caimán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (40, N'KH', N'Camboya', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (41, N'CM', N'Camerún', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (42, N'CA', N'Canadá', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (43, N'CF', N'República Centroafricana', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (44, N'TD', N'Chad', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (45, N'CZ', N'República Checa', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (46, N'CL', N'Chile', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (47, N'CN', N'China', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (48, N'CY', N'Chipre', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (49, N'CX', N'Isla de Navidad', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (50, N'VA', N'Ciudad del Vaticano', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (51, N'CC', N'Islas Cocos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (52, N'CO', N'Colombia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (53, N'KM', N'Comoras', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (54, N'CD', N'República Democrática del Congo', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (55, N'CG', N'Congo', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (56, N'CK', N'Islas Cook', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (57, N'KP', N'Corea del Norte', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (58, N'KR', N'Corea del Sur', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (59, N'CI', N'Costa de Marfil', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (60, N'CR', N'Costa Rica', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (61, N'HR', N'Croacia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (62, N'CU', N'Cuba', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (63, N'DK', N'Dinamarca', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (64, N'DM', N'Dominica', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (65, N'DO', N'República Dominicana', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (66, N'EC', N'Ecuador', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (67, N'EG', N'Egipto', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (68, N'SV', N'El Salvador', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (69, N'AE', N'Emiratos Árabes Unidos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (70, N'ER', N'Eritrea', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (71, N'SK', N'Eslovaquia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (72, N'SI', N'Eslovenia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (73, N'ES', N'España', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (74, N'UM', N'Islas ultramarinas de Estados Unidos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (75, N'US', N'Estados Unidos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (76, N'EE', N'Estonia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (77, N'ET', N'Etiopía', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (78, N'FO', N'Islas Feroe', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (79, N'PH', N'Filipinas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (80, N'FI', N'Finlandia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (81, N'FJ', N'Fiyi', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (82, N'FR', N'Francia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (83, N'GA', N'Gabón', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (84, N'GM', N'Gambia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (85, N'GE', N'Georgia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (86, N'GS', N'Islas Georgias del Sur y Sandwich del Sur', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (87, N'GH', N'Ghana', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (88, N'GI', N'Gibraltar', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (89, N'GD', N'Granada', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (90, N'GR', N'Grecia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (91, N'GL', N'Groenlandia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (92, N'GP', N'Guadalupe', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (93, N'GU', N'Guam', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (94, N'GT', N'Guatemala', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (95, N'GF', N'Guayana Francesa', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (96, N'GN', N'Guinea', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (97, N'GQ', N'Guinea Ecuatorial', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (98, N'GW', N'Guinea-Bissau', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (99, N'GY', N'Guyana', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (100, N'HT', N'Haití', 0)
GO
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (101, N'HM', N'Islas Heard y McDonald', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (102, N'HN', N'Honduras', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (103, N'HK', N'Hong Kong', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (104, N'HU', N'Hungría', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (105, N'IN', N'India', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (106, N'ID', N'Indonesia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (107, N'IR', N'Irán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (108, N'IQ', N'Iraq', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (109, N'IE', N'Irlanda', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (110, N'IS', N'Islandia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (111, N'IL', N'Israel', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (112, N'IT', N'Italia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (113, N'JM', N'Jamaica', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (114, N'JP', N'Japón', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (115, N'JO', N'Jordania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (116, N'KZ', N'Kazajstán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (117, N'KE', N'Kenia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (118, N'KG', N'Kirguistán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (119, N'KI', N'Kiribati', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (120, N'KW', N'Kuwait', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (121, N'LA', N'Laos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (122, N'LS', N'Lesotho', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (123, N'LV', N'Letonia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (124, N'LB', N'Líbano', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (125, N'LR', N'Liberia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (126, N'LY', N'Libia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (127, N'LI', N'Liechtenstein', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (128, N'LT', N'Lituania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (129, N'LU', N'Luxemburgo', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (130, N'MO', N'Macao', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (131, N'MK', N'ARY Macedonia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (132, N'MG', N'Madagascar', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (133, N'MY', N'Malasia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (134, N'MW', N'Malawi', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (135, N'MV', N'Maldivas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (136, N'ML', N'Malí', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (137, N'MT', N'Malta', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (138, N'FK', N'Islas Malvinas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (139, N'MP', N'Islas Marianas del Norte', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (140, N'MA', N'Marruecos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (141, N'MH', N'Islas Marshall', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (142, N'MQ', N'Martinica', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (143, N'MU', N'Mauricio', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (144, N'MR', N'Mauritania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (145, N'YT', N'Mayotte', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (146, N'MX', N'México', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (147, N'FM', N'Micronesia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (148, N'MD', N'Moldavia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (149, N'MC', N'Mónaco', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (150, N'MN', N'Mongolia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (151, N'MS', N'Montserrat', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (152, N'MZ', N'Mozambique', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (153, N'MM', N'Myanmar', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (154, N'NA', N'Namibia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (155, N'NR', N'Nauru', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (156, N'NP', N'Nepal', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (157, N'NI', N'Nicaragua', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (158, N'NE', N'Níger', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (159, N'NG', N'Nigeria', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (160, N'NU', N'Niue', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (161, N'NF', N'Isla Norfolk', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (162, N'NO', N'Noruega', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (163, N'NC', N'Nueva Caledonia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (164, N'NZ', N'Nueva Zelanda', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (165, N'OM', N'Omán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (166, N'NL', N'Países Bajos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (167, N'PK', N'Pakistán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (168, N'PW', N'Palau', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (169, N'PS', N'Palestina', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (170, N'PA', N'Panamá', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (171, N'PG', N'Papúa Nueva Guinea', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (172, N'PY', N'Paraguay', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (173, N'PE', N'Perú', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (174, N'PN', N'Islas Pitcairn', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (175, N'PF', N'Polinesia Francesa', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (176, N'PL', N'Polonia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (177, N'PT', N'Portugal', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (178, N'PR', N'Puerto Rico', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (179, N'QA', N'Qatar', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (180, N'GB', N'Reino Unido', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (181, N'RE', N'Reunión', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (182, N'RW', N'Ruanda', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (183, N'RO', N'Rumania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (184, N'RU', N'Rusia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (185, N'EH', N'Sahara Occidental', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (186, N'SB', N'Islas Salomón', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (187, N'WS', N'Samoa', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (188, N'AS', N'Samoa Americana', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (189, N'KN', N'San Cristóbal y Nevis', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (190, N'SM', N'San Marino', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (191, N'PM', N'San Pedro y Miquelón', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (192, N'VC', N'San Vicente y las Granadinas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (193, N'SH', N'Santa Helena', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (194, N'LC', N'Santa Lucía', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (195, N'ST', N'Santo Tomé y Príncipe', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (196, N'SN', N'Senegal', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (197, N'CS', N'Serbia y Montenegro', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (198, N'SC', N'Seychelles', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (199, N'SL', N'Sierra Leona', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (200, N'SG', N'Singapur', 0)
GO
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (201, N'SY', N'Siria', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (202, N'SO', N'Somalia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (203, N'LK', N'Sri Lanka', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (204, N'SZ', N'Suazilandia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (205, N'ZA', N'Sudáfrica', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (206, N'SD', N'Sudán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (207, N'SE', N'Suecia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (208, N'CH', N'Suiza', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (209, N'SR', N'Surinam', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (210, N'SJ', N'Svalbard y Jan Mayen', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (211, N'TH', N'Tailandia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (212, N'TW', N'Taiwán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (213, N'TZ', N'Tanzania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (214, N'TJ', N'Tayikistán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (215, N'IO', N'Territorio Británico del Océano Índico', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (216, N'TF', N'Territorios Australes Franceses', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (217, N'TL', N'Timor Oriental', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (218, N'TG', N'Togo', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (219, N'TK', N'Tokelau', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (220, N'TO', N'Tonga', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (221, N'TT', N'Trinidad y Tobago', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (222, N'TN', N'Túnez', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (223, N'TC', N'Islas Turcas y Caicos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (224, N'TM', N'Turkmenistán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (225, N'TR', N'Turquía', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (226, N'TV', N'Tuvalu', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (227, N'UA', N'Ucrania', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (228, N'UG', N'Uganda', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (229, N'UY', N'Uruguay', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (230, N'UZ', N'Uzbekistán', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (231, N'VU', N'Vanuatu', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (232, N'VE', N'Venezuela', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (233, N'VN', N'Vietnam', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (234, N'VG', N'Islas Vírgenes Británicas', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (235, N'VI', N'Islas Vírgenes de los Estados Unidos', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (236, N'WF', N'Wallis y Futuna', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (237, N'YE', N'Yemen', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (238, N'DJ', N'Yibuti', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (239, N'ZM', N'Zambia', 0)
INSERT [dbo].[PAISES] ([id], [acronimo], [nombre], [borrado_logico]) VALUES (240, N'ZW', N'Zimbabue', 0)
GO
INSERT [dbo].[PISOS] ([numero], [nombre], [borrado_logico]) VALUES (1, N'Piso 1', 0)
INSERT [dbo].[PISOS] ([numero], [nombre], [borrado_logico]) VALUES (2, N'Piso 2', 0)
INSERT [dbo].[PISOS] ([numero], [nombre], [borrado_logico]) VALUES (3, N'Piso 3', 0)
INSERT [dbo].[PISOS] ([numero], [nombre], [borrado_logico]) VALUES (4, N'Piso 4', 0)
INSERT [dbo].[PISOS] ([numero], [nombre], [borrado_logico]) VALUES (5, N'Piso 5', 0)
GO
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (1, N'Gerente', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (2, N'Recepcionista', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (3, N'Botones', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (4, N'Concerje', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (5, N'Camarero', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (6, N'Barman', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (7, N'Seguridad', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (8, N'Limpieza', 0)
INSERT [dbo].[PUESTOS] ([cod_puesto], [descripcion], [borrado_logico]) VALUES (9, N'Servicios', 0)
GO
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), 4, CAST(N'2021-10-07T22:00:00.000' AS DateTime), NULL, CAST(N'2021-11-16T00:00:00.000' AS DateTime), NULL, 1, NULL, 2, 4, NULL, NULL, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (2, CAST(N'2021-10-11T00:00:00.000' AS DateTime), 4, CAST(N'2021-10-19T17:22:23.000' AS DateTime), CAST(N'2021-10-19T00:00:00.000' AS DateTime), CAST(N'2021-10-20T17:22:23.000' AS DateTime), CAST(N'2021-10-20T00:00:00.000' AS DateTime), 5, NULL, 2, 3, NULL, NULL, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (3, CAST(N'2021-10-11T00:00:00.000' AS DateTime), 6, CAST(N'2021-10-19T17:26:20.000' AS DateTime), CAST(N'2021-10-19T00:00:00.000' AS DateTime), CAST(N'2021-10-20T17:26:20.000' AS DateTime), CAST(N'2021-10-20T00:00:00.000' AS DateTime), 5, 6, 5, 3, 1, 500.0000, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (4, CAST(N'2021-10-11T00:00:00.000' AS DateTime), 4, CAST(N'2021-10-14T18:09:35.000' AS DateTime), CAST(N'2021-10-14T00:00:00.000' AS DateTime), CAST(N'2021-10-20T18:09:35.000' AS DateTime), CAST(N'2021-10-20T00:00:00.000' AS DateTime), 5, 2, 2, 3, 2, 500.0000, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (5, CAST(N'2021-10-12T00:00:00.000' AS DateTime), 4, CAST(N'2021-10-20T12:38:50.000' AS DateTime), NULL, CAST(N'2021-10-29T12:38:50.000' AS DateTime), NULL, 5, 3, 5, 4, 3, 500.0000, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (6, CAST(N'2021-10-12T00:00:00.000' AS DateTime), 5, CAST(N'2022-02-21T14:48:34.000' AS DateTime), NULL, CAST(N'2022-02-25T14:48:34.000' AS DateTime), NULL, 5, NULL, 4, 1, NULL, NULL, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (7, CAST(N'2021-10-12T00:00:00.000' AS DateTime), 9, CAST(N'2021-10-20T22:07:43.000' AS DateTime), NULL, CAST(N'2021-10-29T22:07:43.000' AS DateTime), NULL, 5, 7, 4, 4, 4, 500.0000, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (8, CAST(N'2021-10-12T00:00:00.000' AS DateTime), 9, CAST(N'2021-10-20T22:13:55.000' AS DateTime), NULL, CAST(N'2021-10-29T22:13:55.000' AS DateTime), NULL, 5, NULL, 2, 1, NULL, NULL, 0)
INSERT [dbo].[RESERVA] ([id_reserva], [fecha_hora_reserva], [id_huesped], [fecha_hora_ingreso_estimada], [fecha_hora_ingreso_real], [fecha_hora_salida_estimada], [fecha_hora_salida_real], [id_usuario], [id_vehiculo], [cantidad_personas], [estado], [numero_cochera], [precio_unitario_cochera], [borrado_logico]) VALUES (9, CAST(N'2021-10-13T00:00:00.000' AS DateTime), 4, CAST(N'2021-10-15T08:22:47.000' AS DateTime), NULL, CAST(N'2021-10-27T08:22:47.000' AS DateTime), NULL, 5, 3, 1, 1, 5, 500.0000, 0)
GO
INSERT [dbo].[TARJETAS] ([id_tarjeta], [nro_tarjeta], [cod_tipo_tarjeta], [fecha_caducidad], [id_huesped], [borrado_logico]) VALUES (1, 5282456647661269, 1, CAST(N'2028-08-30' AS Date), 4, 0)
INSERT [dbo].[TARJETAS] ([id_tarjeta], [nro_tarjeta], [cod_tipo_tarjeta], [fecha_caducidad], [id_huesped], [borrado_logico]) VALUES (2, 5282456647661054, 1, CAST(N'2028-08-30' AS Date), 6, 0)
GO
INSERT [dbo].[TIPO_DOCUMENTO] ([tipo_doc], [descripcion], [borrado_logico]) VALUES (1, N'DNI', 0)
INSERT [dbo].[TIPO_DOCUMENTO] ([tipo_doc], [descripcion], [borrado_logico]) VALUES (2, N'PASAPORTE', 0)
INSERT [dbo].[TIPO_DOCUMENTO] ([tipo_doc], [descripcion], [borrado_logico]) VALUES (3, N'LE', 0)
INSERT [dbo].[TIPO_DOCUMENTO] ([tipo_doc], [descripcion], [borrado_logico]) VALUES (4, N'LC', 0)
INSERT [dbo].[TIPO_DOCUMENTO] ([tipo_doc], [descripcion], [borrado_logico]) VALUES (5, N'CI', 0)
GO
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (1, N'Individual', 0, N'Ventilador, Cama Simple, Balcón
')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (2, N'Doble', 0, N'AC, Cama Doble, Baño c/bañera, Frigobar, SmartTv')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (3, N'Triple', 0, N'Aire Acondicionado, Cama Doble y Cama Simple, Bañera, Frigobar y SmarTV')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (4, N'Quad', 0, N'Aire Acondicionado, sala común, 2 baños, Cama Doble y 2 Camas Simples')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (5, N'Queen', 0, N'Aire Acondicionado, Cama Queen, Baño c/Bañera, SPA incluido, Mini Living.')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (6, N'King', 0, N'Aire Acondicionado, Cama King, Baño c/Bañera, SPA incluido, Mini Living.')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (7, N'Mini Suite', 0, N'Aire Acondicionado, Baño c/Bañera, Una Cama Individual, SmartTV, Jacuzzi con Hidromasajes')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (8, N'Master Suite', 0, N'Aire Acondicionado, 2 Habitaciones  con cama King, sala de estar, Servicio al Cuarto Free, 3 baños, Jacuzzi, Piscina y terraza privada.
')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (9, N'Cuadruple', 1, N'Vacia
')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (10, N'Cuadruple2', 1, N'Aire Acondicionado, sala común, 2 baños, 2 Camas Dobles.')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (11, N'Cuadruple', 1, N'Aire Acondicionado, sala común, 2 baños, 2 Camas Dobles.')
INSERT [dbo].[TIPO_HABITACION] ([cod_tipo], [nombre], [borrado_logico], [descripcion]) VALUES (12, N'Cuádriple', 1, N'Aire Acondicionado, frigobar')
GO
INSERT [dbo].[TIPOS_TARJETA] ([codigo], [descripcion], [borrado_logico]) VALUES (1, N'Débito', 0)
INSERT [dbo].[TIPOS_TARJETA] ([codigo], [descripcion], [borrado_logico]) VALUES (2, N'Crédito', 0)
GO
INSERT [dbo].[USUARIOS] ([id], [password], [salt], [nombre], [id_empleado], [borrado_logico]) VALUES (1, N'alex123!', NULL, N'alexmbianchini', 1, 0)
INSERT [dbo].[USUARIOS] ([id], [password], [salt], [nombre], [id_empleado], [borrado_logico]) VALUES (2, N'', NULL, N'brock', 2, 1)
INSERT [dbo].[USUARIOS] ([id], [password], [salt], [nombre], [id_empleado], [borrado_logico]) VALUES (3, N'', NULL, N'fabricagol', 3, 0)
INSERT [dbo].[USUARIOS] ([id], [password], [salt], [nombre], [id_empleado], [borrado_logico]) VALUES (4, N'lureale123!', NULL, N'lureale', 4, 0)
INSERT [dbo].[USUARIOS] ([id], [password], [salt], [nombre], [id_empleado], [borrado_logico]) VALUES (5, N'admin123!', NULL, N'admin', 5, 0)
INSERT [dbo].[USUARIOS] ([id], [password], [salt], [nombre], [id_empleado], [borrado_logico]) VALUES (6, N'juan123!', NULL, N'juancito', 6, 0)
INSERT [dbo].[USUARIOS] ([id], [password], [salt], [nombre], [id_empleado], [borrado_logico]) VALUES (7, N'fran123!', NULL, N'francagol', 7, 0)
GO
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'AGI591', N'Fiat', N'Cronos', 2, 1, 1)
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'LWX294', N'Ford', N'Focus', 4, 2, 0)
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'SG482FG', N'Fiat', N'Cronos', 4, 3, 0)
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'DF789KJ', N'Renault', N'Sandero', 5, 4, 0)
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'DFG567', N'Renault', N'12', 5, 5, 0)
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'IEH290', N'Fiat', N'Palio Weekend', 6, 6, 0)
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'RGD745', N'Fiat', N'Uno', 9, 7, 0)
INSERT [dbo].[VEHICULOS] ([patente], [marca], [modelo], [id_huesped], [id], [borrado_logico]) VALUES (N'IEH276', N'Fiat', N'Argo', 4, 8, 0)
GO
ALTER TABLE [dbo].[COCHERAS]  WITH CHECK ADD  CONSTRAINT [FK_cocheras_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[ESTADO_COCHERA] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[COCHERAS] CHECK CONSTRAINT [FK_cocheras_estado]
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD  CONSTRAINT [fk_cuenta_reserva] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[RESERVA] ([id_reserva])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CUENTA] CHECK CONSTRAINT [fk_cuenta_reserva]
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD  CONSTRAINT [fk_cuenta_tarjeta] FOREIGN KEY([id_tarjeta])
REFERENCES [dbo].[TARJETAS] ([id_tarjeta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CUENTA] CHECK CONSTRAINT [fk_cuenta_tarjeta]
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD  CONSTRAINT [fk_cuenta_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[USUARIOS] ([id])
GO
ALTER TABLE [dbo].[CUENTA] CHECK CONSTRAINT [fk_cuenta_usuario]
GO
ALTER TABLE [dbo].[DETALLE_RESERVA]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_HABITACIONES] FOREIGN KEY([numero_habitacion])
REFERENCES [dbo].[HABITACIONES] ([numero])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_RESERVA] CHECK CONSTRAINT [FK_DETALLE_HABITACIONES]
GO
ALTER TABLE [dbo].[DETALLE_RESERVA]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_RESERVA] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[RESERVA] ([id_reserva])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_RESERVA] CHECK CONSTRAINT [FK_DETALLE_RESERVA]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIOS_CUENTA]  WITH CHECK ADD  CONSTRAINT [fk_detServ_cuenta] FOREIGN KEY([nro_cuenta])
REFERENCES [dbo].[CUENTA] ([id_cuenta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_SERVICIOS_CUENTA] CHECK CONSTRAINT [fk_detServ_cuenta]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIOS_CUENTA]  WITH CHECK ADD  CONSTRAINT [fk_detServ_habitacion] FOREIGN KEY([nro_habitacion])
REFERENCES [dbo].[HABITACIONES] ([numero])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_SERVICIOS_CUENTA] CHECK CONSTRAINT [fk_detServ_habitacion]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIOS_CUENTA]  WITH CHECK ADD  CONSTRAINT [fk_detServ_producto] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[MENU] ([codigo_producto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_SERVICIOS_CUENTA] CHECK CONSTRAINT [fk_detServ_producto]
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD  CONSTRAINT [fk_empleados_puesto] FOREIGN KEY([puesto])
REFERENCES [dbo].[PUESTOS] ([cod_puesto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EMPLEADOS] CHECK CONSTRAINT [fk_empleados_puesto]
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD  CONSTRAINT [fk_empleados_tipoDoc] FOREIGN KEY([tipo_doc])
REFERENCES [dbo].[TIPO_DOCUMENTO] ([tipo_doc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EMPLEADOS] CHECK CONSTRAINT [fk_empleados_tipoDoc]
GO
ALTER TABLE [dbo].[HABITACIONES]  WITH CHECK ADD  CONSTRAINT [fk_habitaciones_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[ESTADO_HABITACION] ([idEstado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HABITACIONES] CHECK CONSTRAINT [fk_habitaciones_estado]
GO
ALTER TABLE [dbo].[HABITACIONES]  WITH CHECK ADD  CONSTRAINT [fk_habitaciones_piso] FOREIGN KEY([piso])
REFERENCES [dbo].[PISOS] ([numero])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HABITACIONES] CHECK CONSTRAINT [fk_habitaciones_piso]
GO
ALTER TABLE [dbo].[HABITACIONES]  WITH CHECK ADD  CONSTRAINT [fk_habitaciones_tipo] FOREIGN KEY([tipo_habitacion])
REFERENCES [dbo].[TIPO_HABITACION] ([cod_tipo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HABITACIONES] CHECK CONSTRAINT [fk_habitaciones_tipo]
GO
ALTER TABLE [dbo].[HUESPEDES]  WITH CHECK ADD  CONSTRAINT [fk_huespedes_pais] FOREIGN KEY([pais_residencia])
REFERENCES [dbo].[PAISES] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HUESPEDES] CHECK CONSTRAINT [fk_huespedes_pais]
GO
ALTER TABLE [dbo].[RESERVA]  WITH CHECK ADD  CONSTRAINT [fk_reserva_cochera] FOREIGN KEY([numero_cochera])
REFERENCES [dbo].[COCHERAS] ([numero])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RESERVA] CHECK CONSTRAINT [fk_reserva_cochera]
GO
ALTER TABLE [dbo].[RESERVA]  WITH CHECK ADD  CONSTRAINT [fk_reserva_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[ESTADO_RESERVA] ([id_estado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RESERVA] CHECK CONSTRAINT [fk_reserva_estado]
GO
ALTER TABLE [dbo].[RESERVA]  WITH CHECK ADD  CONSTRAINT [fk_reserva_huespedes] FOREIGN KEY([id_huesped])
REFERENCES [dbo].[HUESPEDES] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RESERVA] CHECK CONSTRAINT [fk_reserva_huespedes]
GO
ALTER TABLE [dbo].[RESERVA]  WITH CHECK ADD  CONSTRAINT [fk_reserva_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[USUARIOS] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RESERVA] CHECK CONSTRAINT [fk_reserva_usuario]
GO
ALTER TABLE [dbo].[RESERVA]  WITH CHECK ADD  CONSTRAINT [fk_reserva_vehiculos] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[VEHICULOS] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RESERVA] CHECK CONSTRAINT [fk_reserva_vehiculos]
GO
ALTER TABLE [dbo].[SESION]  WITH CHECK ADD  CONSTRAINT [fk_sesion_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[USUARIOS] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SESION] CHECK CONSTRAINT [fk_sesion_usuario]
GO
ALTER TABLE [dbo].[TARJETAS]  WITH CHECK ADD  CONSTRAINT [fk_tarjetas_codTipo] FOREIGN KEY([cod_tipo_tarjeta])
REFERENCES [dbo].[TIPOS_TARJETA] ([codigo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TARJETAS] CHECK CONSTRAINT [fk_tarjetas_codTipo]
GO
ALTER TABLE [dbo].[TARJETAS]  WITH CHECK ADD  CONSTRAINT [fk_tarjetas_huespedes] FOREIGN KEY([id_huesped])
REFERENCES [dbo].[HUESPEDES] ([id])
GO
ALTER TABLE [dbo].[TARJETAS] CHECK CONSTRAINT [fk_tarjetas_huespedes]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [fk_usuario_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [fk_usuario_empleado]
GO
ALTER TABLE [dbo].[VEHICULOS]  WITH CHECK ADD  CONSTRAINT [fk_vehiculos_huespedes] FOREIGN KEY([id_huesped])
REFERENCES [dbo].[HUESPEDES] ([id])
GO
ALTER TABLE [dbo].[VEHICULOS] CHECK CONSTRAINT [fk_vehiculos_huespedes]
GO
USE [master]
GO
ALTER DATABASE [db_a7b7c9_hotel] SET  READ_WRITE 
GO
