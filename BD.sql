USE [master]
GO
/****** Object:  Database [VentasElectronica]    Script Date: 13/10/2023 12:42:27 ******/
CREATE DATABASE [VentasElectronica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VentasElectronica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\VentasElectronica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VentasElectronica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\VentasElectronica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [VentasElectronica] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VentasElectronica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VentasElectronica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VentasElectronica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VentasElectronica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VentasElectronica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VentasElectronica] SET ARITHABORT OFF 
GO
ALTER DATABASE [VentasElectronica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VentasElectronica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VentasElectronica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VentasElectronica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VentasElectronica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VentasElectronica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VentasElectronica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VentasElectronica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VentasElectronica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VentasElectronica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VentasElectronica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VentasElectronica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VentasElectronica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VentasElectronica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VentasElectronica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VentasElectronica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VentasElectronica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VentasElectronica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VentasElectronica] SET  MULTI_USER 
GO
ALTER DATABASE [VentasElectronica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VentasElectronica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VentasElectronica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VentasElectronica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VentasElectronica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VentasElectronica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VentasElectronica] SET QUERY_STORE = ON
GO
ALTER DATABASE [VentasElectronica] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [VentasElectronica]
GO
USE [VentasElectronica]
GO
/****** Object:  Sequence [dbo].[MiSecuencia]    Script Date: 13/10/2023 12:42:27 ******/
CREATE SEQUENCE [dbo].[MiSecuencia] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
/****** Object:  UserDefinedTableType [dbo].[VentasTipo]    Script Date: 13/10/2023 12:42:27 ******/
CREATE TYPE [dbo].[VentasTipo] AS TABLE(
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL
)
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[NombrePermiso] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolesPermisos]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesPermisos](
	[IdRolesPermisos] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdPermiso] [int] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_RolesPermisos] PRIMARY KEY CLUSTERED 
(
	[IdRolesPermisos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[func_ListaPermisosYRoles]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_ListaPermisosYRoles]
(
 @idrol int
 )
 RETURNS TABLE
 AS
 RETURN
 (
    Select P.NombrePermiso From Permisos as P INNER JOIN RolesPermisos as R on P.IdPermiso = R.IdPermiso
    where R.IdRol = @idrol and R.Estado = 1
 )
GO
/****** Object:  Table [dbo].[Categorías]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorías](
	[IdCategoría] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Categorías] PRIMARY KEY CLUSTERED 
(
	[IdCategoría] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[Dirección] [varchar](200) NOT NULL,
	[NúmeroDeCelular] [varchar](50) NOT NULL,
	[CorreoElectronico] [varchar](50) NOT NULL,
	[IdTipoCliente] [int] NOT NULL,
	[Nit] [varchar](50) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](100) NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Género] [varchar](50) NOT NULL,
	[DPI] [varchar](50) NOT NULL,
	[Dirección] [varchar](200) NOT NULL,
	[Télefono] [varchar](50) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[NúmeroCorrelativo] [int] NOT NULL,
	[LetradeSerie] [varchar](10) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Garantías]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Garantías](
	[IdGarantía] [int] IDENTITY(1,1) NOT NULL,
	[TiempoDeGarantíaEnDias] [int] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Garantías] PRIMARY KEY CLUSTERED 
(
	[IdGarantía] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetodosDePago]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodosDePago](
	[IdMétodoDePago] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_MetodosDePago] PRIMARY KEY CLUSTERED 
(
	[IdMétodoDePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripción] [varchar](50) NOT NULL,
	[Precio_de_Venta] [money] NOT NULL,
	[IdMarca] [int] NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Stock] [int] NOT NULL,
	[ExistenciaMínima] [int] NOT NULL,
	[IdGarantía] [int] NOT NULL,
	[IdCategoría] [int] NOT NULL,
	[FechadeIngreso] [date] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductosVenta]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductosVenta](
	[IdProductoVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_ProductosVenta] PRIMARY KEY CLUSTERED 
(
	[IdProductoVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Dirección] [varchar](50) NOT NULL,
	[Télefono] [varchar](200) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SolicitudProductosaProveedores]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SolicitudProductosaProveedores](
	[IdSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[CantidadSolicitada] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_SolicitudProductosaProveedores] PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposdeClientes]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposdeClientes](
	[IdTipoCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[PorcentajeDescuentoEspecial] [int] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_TiposdeClientes] PRIMARY KEY CLUSTERED 
(
	[IdTipoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](250) NOT NULL,
	[IdRol] [int] NOT NULL,
	[Estado] [tinyint] NOT NULL,
	[IdEmpleado] [int] NULL,
 CONSTRAINT [PK_IdUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Subtotal] [money] NOT NULL,
	[Descuento] [money] NOT NULL,
	[Total] [money] NOT NULL,
	[Comentario] [varchar](250) NOT NULL,
	[IdMétodoDePago] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[IdFactura] [int] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorías] ON 

INSERT [dbo].[Categorías] ([IdCategoría], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Televisores', N'Todo tipo de televisiones', 1)
INSERT [dbo].[Categorías] ([IdCategoría], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Refrigeradoras', N'Para alimentos', 1)
INSERT [dbo].[Categorías] ([IdCategoría], [Nombre], [Descripcion], [Estado]) VALUES (3, N'Télefonos Celulares', N'Telefonos celulares (Smartphones)', 1)
SET IDENTITY_INSERT [dbo].[Categorías] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([IdCliente], [Nombres], [Apellidos], [Dirección], [NúmeroDeCelular], [CorreoElectronico], [IdTipoCliente], [Nit], [Estado]) VALUES (1, N'Jose ', N'Martinez', N'Xela', N'45122154', N'Juanito@gmail.com', 1, N'833964-3', 1)
INSERT [dbo].[Clientes] ([IdCliente], [Nombres], [Apellidos], [Dirección], [NúmeroDeCelular], [CorreoElectronico], [IdTipoCliente], [Nit], [Estado]) VALUES (2, N'Fernanda', N'Galicia', N'Huehuetenango', N'78965412', N'Ferdita@fer.com', 1, N'899654-2', 1)
INSERT [dbo].[Clientes] ([IdCliente], [Nombres], [Apellidos], [Dirección], [NúmeroDeCelular], [CorreoElectronico], [IdTipoCliente], [Nit], [Estado]) VALUES (3, N'Juan', N'Mariazcus', N'Xela', N'23236565', N'n/a', 2, N'655454-9', 1)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([IdEmpleado], [Nombres], [Apellidos], [FechaNacimiento], [Género], [DPI], [Dirección], [Télefono], [Estado]) VALUES (1, N'Mauricio', N'Garcia', CAST(N'2003-01-28' AS Date), N'Masculino', N'3351144070901', N'Xela', N'46131012', 1)
INSERT [dbo].[Empleados] ([IdEmpleado], [Nombres], [Apellidos], [FechaNacimiento], [Género], [DPI], [Dirección], [Télefono], [Estado]) VALUES (2, N'Nilmar ', N'Perez', CAST(N'2023-09-07' AS Date), N'Masculino', N'34419503827209', N'La esperanza', N'77676777', 1)
INSERT [dbo].[Empleados] ([IdEmpleado], [Nombres], [Apellidos], [FechaNacimiento], [Género], [DPI], [Dirección], [Télefono], [Estado]) VALUES (3, N'Ingeniero', N'Enrique', CAST(N'2023-09-18' AS Date), N'Masculino', N'3351144070900', N'Xela', N'46131012', 1)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Garantías] ON 

INSERT [dbo].[Garantías] ([IdGarantía], [TiempoDeGarantíaEnDias], [Estado]) VALUES (1, 180, 1)
INSERT [dbo].[Garantías] ([IdGarantía], [TiempoDeGarantíaEnDias], [Estado]) VALUES (2, 60, 1)
SET IDENTITY_INSERT [dbo].[Garantías] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([IdMarca], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Panasonic', N'Marca de electronicos', 1)
INSERT [dbo].[Marcas] ([IdMarca], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Samsung', N'Marca de todo tipo de electronicos y electrodomesticos', 1)
INSERT [dbo].[Marcas] ([IdMarca], [Nombre], [Descripcion], [Estado]) VALUES (3, N'LG', N'Marca de electronicos y electrodomesticos', 1)
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[MetodosDePago] ON 

INSERT [dbo].[MetodosDePago] ([IdMétodoDePago], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Efectivo', N'Pago efectivo', 1)
INSERT [dbo].[MetodosDePago] ([IdMétodoDePago], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Cheque', N'Pago por medio de chequera', 1)
INSERT [dbo].[MetodosDePago] ([IdMétodoDePago], [Nombre], [Descripcion], [Estado]) VALUES (3, N'Tarjeta', N'Pago por medio de tarjeta de credito o debito.', 1)
SET IDENTITY_INSERT [dbo].[MetodosDePago] OFF
GO
SET IDENTITY_INSERT [dbo].[Permisos] ON 

INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (1, N'Usuarios')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (2, N'Empleados')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (3, N'Clientes')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (4, N'Proveedores')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (5, N'Productos')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (6, N'Categorias de Productos')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (7, N'Marcas')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (8, N'Reportes')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (9, N'Roles')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (10, N'Garantias')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (11, N'Metodos de Pago')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (12, N'Tipos de Clientes')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (13, N'Ventas')
INSERT [dbo].[Permisos] ([IdPermiso], [NombrePermiso]) VALUES (14, N'Solicitud de productos a proveedor')
SET IDENTITY_INSERT [dbo].[Permisos] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Descripción], [Precio_de_Venta], [IdMarca], [Modelo], [Stock], [ExistenciaMínima], [IdGarantía], [IdCategoría], [FechadeIngreso], [IdProveedor], [Estado]) VALUES (1, N'Samsung Galaxy S23 Ultra', N'Telefono mas nuevo de samsung', 9500.0000, 2, N'Galaxy', 25, 1, 1, 3, CAST(N'2023-10-13' AS Date), 1, 1)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Descripción], [Precio_de_Venta], [IdMarca], [Modelo], [Stock], [ExistenciaMínima], [IdGarantía], [IdCategoría], [FechadeIngreso], [IdProveedor], [Estado]) VALUES (2, N'Refrigeradora Panasonic', N'Una de las ultimas refrigeradoras de panasonic', 3500.0000, 1, N'BT55', 10, 1, 2, 2, CAST(N'2023-10-13' AS Date), 2, 1)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Descripción], [Precio_de_Venta], [IdMarca], [Modelo], [Stock], [ExistenciaMínima], [IdGarantía], [IdCategoría], [FechadeIngreso], [IdProveedor], [Estado]) VALUES (3, N'Televisor Smart LG de 32 pulgadas', N'Plasma smart de 32 pulgadas', 1500.0000, 3, N'AI ThinQ 32LQ630BPSA', 20, 1, 1, 1, CAST(N'2023-10-13' AS Date), 3, 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([IdProveedor], [Nombre], [Dirección], [Télefono], [Estado]) VALUES (1, N'Samsung Guatemala', N'Boulevar Liberacion', N'77674512', 1)
INSERT [dbo].[Proveedores] ([IdProveedor], [Nombre], [Dirección], [Télefono], [Estado]) VALUES (2, N'Panasonic Guatemala', N'Sexta Avenida, Guatemala', N'77679889', 1)
INSERT [dbo].[Proveedores] ([IdProveedor], [Nombre], [Dirección], [Télefono], [Estado]) VALUES (3, N'LG Panama', N'Ciudad de Panama', N'77672325', 1)
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([IdRol], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Administrador', N'Persona que posee acceso a todo el sistema', 1)
INSERT [dbo].[Roles] ([IdRol], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Bodeguero', N'Persona encargada de alimentar el sistema de bodega, ingreso de productos del proveedor.', 1)
INSERT [dbo].[Roles] ([IdRol], [Nombre], [Descripcion], [Estado]) VALUES (3, N'Cajero', N'Persona que solo podrá cobrar', 1)
INSERT [dbo].[Roles] ([IdRol], [Nombre], [Descripcion], [Estado]) VALUES (4, N'Gerente', N'Persona que podra observar los reportes y realizar pedidos a proveedores', 1)
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[RolesPermisos] ON 

INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (1, 1, 1, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (2, 1, 2, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (3, 1, 3, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (4, 1, 4, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (5, 1, 5, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (6, 1, 6, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (7, 1, 7, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (8, 1, 8, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (9, 1, 9, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (10, 1, 10, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (11, 1, 11, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (12, 1, 12, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (13, 1, 13, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (14, 1, 14, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (16, 2, 1, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (17, 2, 2, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (18, 2, 3, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (19, 2, 4, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (20, 2, 5, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (21, 2, 6, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (22, 2, 7, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (23, 2, 8, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (24, 2, 9, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (25, 2, 10, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (26, 2, 11, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (27, 2, 12, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (28, 2, 13, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (29, 2, 14, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (31, 3, 1, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (32, 3, 2, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (33, 3, 3, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (34, 3, 4, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (35, 3, 5, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (36, 3, 6, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (37, 3, 7, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (38, 3, 8, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (39, 3, 9, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (40, 3, 10, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (41, 3, 11, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (42, 3, 12, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (43, 3, 13, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (44, 3, 14, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (45, 4, 1, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (46, 4, 2, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (47, 4, 3, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (48, 4, 4, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (49, 4, 5, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (50, 4, 6, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (51, 4, 7, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (52, 4, 8, 1)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (53, 4, 9, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (54, 4, 10, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (55, 4, 11, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (56, 4, 12, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (57, 4, 13, 0)
INSERT [dbo].[RolesPermisos] ([IdRolesPermisos], [IdRol], [IdPermiso], [Estado]) VALUES (58, 4, 14, 1)
SET IDENTITY_INSERT [dbo].[RolesPermisos] OFF
GO
SET IDENTITY_INSERT [dbo].[SolicitudProductosaProveedores] ON 

INSERT [dbo].[SolicitudProductosaProveedores] ([IdSolicitud], [IdProducto], [IdProveedor], [CantidadSolicitada], [Estado]) VALUES (1, 1, 1, 25, 2)
INSERT [dbo].[SolicitudProductosaProveedores] ([IdSolicitud], [IdProducto], [IdProveedor], [CantidadSolicitada], [Estado]) VALUES (2, 2, 2, 10, 2)
INSERT [dbo].[SolicitudProductosaProveedores] ([IdSolicitud], [IdProducto], [IdProveedor], [CantidadSolicitada], [Estado]) VALUES (3, 3, 3, 20, 2)
SET IDENTITY_INSERT [dbo].[SolicitudProductosaProveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposdeClientes] ON 

INSERT [dbo].[TiposdeClientes] ([IdTipoCliente], [Nombre], [Descripcion], [PorcentajeDescuentoEspecial], [Estado]) VALUES (1, N'Cliente normal', N'Cliente que no cuenta con ningun trato especial', 0, 1)
INSERT [dbo].[TiposdeClientes] ([IdTipoCliente], [Nombre], [Descripcion], [PorcentajeDescuentoEspecial], [Estado]) VALUES (2, N'Cliente Preferencial', N'Cliente que nos compra mas de lo habitual', 3, 1)
SET IDENTITY_INSERT [dbo].[TiposdeClientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Usuario], [Contraseña], [IdRol], [Estado], [IdEmpleado]) VALUES (1, N'admin', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
/****** Object:  Index [UQ__Constrai]    Script Date: 13/10/2023 12:42:27 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [UQ__Constrai] UNIQUE NONCLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Facturas] ADD  DEFAULT (NEXT VALUE FOR [MiSecuencia]) FOR [NúmeroCorrelativo]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_TiposdeClientes] FOREIGN KEY([IdTipoCliente])
REFERENCES [dbo].[TiposdeClientes] ([IdTipoCliente])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_TiposdeClientes]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorías] FOREIGN KEY([IdCategoría])
REFERENCES [dbo].[Categorías] ([IdCategoría])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorías]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Garantías] FOREIGN KEY([IdGarantía])
REFERENCES [dbo].[Garantías] ([IdGarantía])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Garantías]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marcas] ([IdMarca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
ALTER TABLE [dbo].[ProductosVenta]  WITH CHECK ADD  CONSTRAINT [FK_ProductosVenta_Productos1] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[ProductosVenta] CHECK CONSTRAINT [FK_ProductosVenta_Productos1]
GO
ALTER TABLE [dbo].[ProductosVenta]  WITH CHECK ADD  CONSTRAINT [FK_ProductosVenta_Ventas1] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
GO
ALTER TABLE [dbo].[ProductosVenta] CHECK CONSTRAINT [FK_ProductosVenta_Ventas1]
GO
ALTER TABLE [dbo].[RolesPermisos]  WITH CHECK ADD  CONSTRAINT [FK_RolesPermisos_Permisos] FOREIGN KEY([IdPermiso])
REFERENCES [dbo].[Permisos] ([IdPermiso])
GO
ALTER TABLE [dbo].[RolesPermisos] CHECK CONSTRAINT [FK_RolesPermisos_Permisos]
GO
ALTER TABLE [dbo].[RolesPermisos]  WITH CHECK ADD  CONSTRAINT [FK_RolesPermisos_Roles] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([IdRol])
GO
ALTER TABLE [dbo].[RolesPermisos] CHECK CONSTRAINT [FK_RolesPermisos_Roles]
GO
ALTER TABLE [dbo].[SolicitudProductosaProveedores]  WITH CHECK ADD  CONSTRAINT [FK_SolicitudProductosaProveedores_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[SolicitudProductosaProveedores] CHECK CONSTRAINT [FK_SolicitudProductosaProveedores_Productos]
GO
ALTER TABLE [dbo].[SolicitudProductosaProveedores]  WITH CHECK ADD  CONSTRAINT [FK_SolicitudProductosaProveedores_Proveedores] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedores] ([IdProveedor])
GO
ALTER TABLE [dbo].[SolicitudProductosaProveedores] CHECK CONSTRAINT [FK_SolicitudProductosaProveedores_Proveedores]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_IdUsuario_Roles] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([IdRol])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_IdUsuario_Roles]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleados]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleados] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleados]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Facturas] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Facturas] ([IdFactura])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Facturas]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_MetodosDePago] FOREIGN KEY([IdMétodoDePago])
REFERENCES [dbo].[MetodosDePago] ([IdMétodoDePago])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_MetodosDePago]
GO
/****** Object:  StoredProcedure [dbo].[spVentas]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spVentas]
    @letra AS NVARCHAR(50),
    @fecha AS DATETIME,
    @idcliente AS INT,
    @subtotal AS MONEY,
    @descuento AS MONEY,
    @total AS MONEY,
    @comentario AS NVARCHAR(250),
    @idmetododepago AS INT,
    @idempleado AS INT,
    @ventasTabla AS VentasTipo READONLY,  
    @mensaje AS VARCHAR(250) OUTPUT
AS
BEGIN
    Declare @IdAutor INT, @idfactura INT, @idventa INT, @stockDisponible INT, @unidadesminimas INT
    Begin Try
        Begin Tran Ventas
        DECLARE @VentaCursor CURSOR
        DECLARE @IdProducto INT
        DECLARE @Cantidad INT
		Insert Into Facturas(LetradeSerie,Estado) Values (@letra,1)
        Select @idfactura=SCOPE_IDENTITY()
		Insert Into Ventas(Fecha, IdCliente, Subtotal, Descuento, Total, Comentario, IdMétodoDePago, IdEmpleado, IdFactura, Estado) Values (@fecha, @idcliente, @subtotal, @descuento, @total, @comentario, @idmetododepago,@idempleado,@idfactura,1)
        Select @idventa=SCOPE_IDENTITY()
        SET @VentaCursor = CURSOR FOR
            SELECT IdProducto, Cantidad FROM @ventasTabla

        OPEN @VentaCursor
        FETCH NEXT FROM @VentaCursor INTO @IdProducto, @Cantidad

        WHILE @@FETCH_STATUS = 0
        BEGIN
            Select @stockDisponible = Stock FROM Productos WHERE IdProducto = @idproducto
			Select @unidadesminimas = ExistenciaMínima FROM Productos WHERE IdProducto = @idproducto
			IF @stockDisponible >= @cantidad AND (@stockDisponible - @cantidad) >= @unidadesminimas
            BEGIN
                Insert Into ProductosVenta(IdVenta,IdProducto,Cantidad, Estado) Values (@idventa, @IdProducto, @Cantidad, 1)
                UPDATE Productos SET Stock = Stock - @Cantidad WHERE IdProducto = @IdProducto
            END
            ELSE
            BEGIN
                Set @mensaje = 'ERROR: Stock insuficiente o por debajo del mínimo para realizar la venta'
                RollBack Tran Ventas
                CLOSE @VentaCursor
                DEALLOCATE @VentaCursor
                RETURN  
            END

            FETCH NEXT FROM @VentaCursor INTO @IdProducto, @Cantidad
        END

        CLOSE @VentaCursor
        DEALLOCATE @VentaCursor

        Set @mensaje='Se realizó la venta con éxito'
        Commit Tran Ventas
    End Try
    Begin Catch
        Set @mensaje='ERROR: Venta inválida, revise los datos ingresados. Detalles del error: ' + ERROR_MESSAGE()
        RollBack Tran Ventas
    End Catch
END
GO
/****** Object:  Trigger [dbo].[Solicituddeproductoscompletada]    Script Date: 13/10/2023 12:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Solicituddeproductoscompletada]
ON [dbo].[SolicitudProductosaProveedores]
FOR UPDATE
AS
BEGIN
    DECLARE @IdProduct int;
	DECLARE @stock int;
    SELECT @IdProduct = IdProducto FROM INSERTED;
	SELECT @stock = CantidadSolicitada FROM INSERTED;
    UPDATE Productos SET Stock = Stock + @stock
	WHERE IdProducto = @IdProduct
END
GO
ALTER TABLE [dbo].[SolicitudProductosaProveedores] ENABLE TRIGGER [Solicituddeproductoscompletada]
GO
USE [master]
GO
ALTER DATABASE [VentasElectronica] SET  READ_WRITE 
GO
