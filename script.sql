USE [master]
GO
/****** Object:  Database [MarketManagerBD]    Script Date: 18/01/2024 11:58:27 ******/
CREATE DATABASE [MarketManagerBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MarketManagerBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MarketManagerBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MarketManagerBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MarketManagerBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MarketManagerBD] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MarketManagerBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MarketManagerBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MarketManagerBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MarketManagerBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MarketManagerBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MarketManagerBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [MarketManagerBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MarketManagerBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MarketManagerBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MarketManagerBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MarketManagerBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MarketManagerBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MarketManagerBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MarketManagerBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MarketManagerBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MarketManagerBD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MarketManagerBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MarketManagerBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MarketManagerBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MarketManagerBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MarketManagerBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MarketManagerBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MarketManagerBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MarketManagerBD] SET RECOVERY FULL 
GO
ALTER DATABASE [MarketManagerBD] SET  MULTI_USER 
GO
ALTER DATABASE [MarketManagerBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MarketManagerBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MarketManagerBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MarketManagerBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MarketManagerBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MarketManagerBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MarketManagerBD', N'ON'
GO
ALTER DATABASE [MarketManagerBD] SET QUERY_STORE = ON
GO
ALTER DATABASE [MarketManagerBD] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MarketManagerBD]
GO
/****** Object:  Table [dbo].[cargo]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cargo](
	[codigo_cargo] [int] NOT NULL,
	[nombre_cargo] [varchar](20) NOT NULL,
	[descripcion] [text] NOT NULL,
	[sueldo] [money] NOT NULL,
 CONSTRAINT [PK_cargo] PRIMARY KEY CLUSTERED 
(
	[codigo_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[codigo_categoria] [varchar](10) NOT NULL,
	[nombre_categoria] [varchar](10) NOT NULL,
	[descripcion] [text] NOT NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[codigo_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[id_compra] [int] NOT NULL,
	[codigo_proveedor] [int] NOT NULL,
	[cedula_usuario] [varchar](11) NOT NULL,
	[monto] [money] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_compra] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_compra]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_compra](
	[id_compra] [int] NOT NULL,
	[codigo_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_total] [money] NOT NULL,
 CONSTRAINT [PK_detalle_compra] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC,
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[codigo_factura] [int] NOT NULL,
	[codigo_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_total] [money] NOT NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[codigo_factura] ASC,
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[cedula_empleado] [varchar](11) NOT NULL,
	[codigo_cargo] [int] NOT NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[cedula_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[cedula_persona] [varchar](11) NOT NULL,
	[nombre_persona] [varchar](20) NOT NULL,
	[apellido_persona] [varchar](20) NOT NULL,
	[direccion] [text] NULL,
	[telefono] [varchar](12) NULL,
	[correo] [varchar](30) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[cedula_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[codigo_producto] [int] NOT NULL,
	[nombre_producto] [varchar](20) NOT NULL,
	[marca] [varchar](20) NOT NULL,
	[descripcion] [text] NOT NULL,
	[precio_compra] [money] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[codigo_categoria] [varchar](10) NOT NULL,
	[inventario] [int] NOT NULL,
	[anaquel] [int] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[codigo_proveedor] [int] NOT NULL,
	[nombre_proveedor] [varchar](30) NOT NULL,
	[ubicacion] [text] NOT NULL,
	[cedula_contacto] [varchar](11) NOT NULL,
	[nombre_contacto] [varchar](20) NOT NULL,
	[telefono] [int] NOT NULL,
	[correo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[codigo_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[codigo_rol] [varchar](10) NOT NULL,
	[nombre_rol] [varchar](15) NOT NULL,
	[descripcion] [text] NOT NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[codigo_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[cedula] [int] NOT NULL,
	[nombre_usuario] [varchar](20) NOT NULL,
	[contraseña] [varchar](20) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[codigo_rol] [varchar](10) NOT NULL,
 CONSTRAINT [PK_usuario_1] PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[codigo_factura] [int] NOT NULL,
	[cedula_usuario] [varchar](11) NOT NULL,
	[cedula_persona] [varchar](11) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[monto] [money] NOT NULL,
 CONSTRAINT [PK_venta_1] PRIMARY KEY CLUSTERED 
(
	[codigo_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_compra_proveedor] FOREIGN KEY([codigo_proveedor])
REFERENCES [dbo].[proveedor] ([codigo_proveedor])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_compra_proveedor]
GO
ALTER TABLE [dbo].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_compra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[compra] ([id_compra])
GO
ALTER TABLE [dbo].[detalle_compra] CHECK CONSTRAINT [FK_detalle_compra_compra]
GO
ALTER TABLE [dbo].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_producto] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[producto] ([codigo_producto])
GO
ALTER TABLE [dbo].[detalle_compra] CHECK CONSTRAINT [FK_detalle_compra_producto]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_producto] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[producto] ([codigo_producto])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_producto]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_venta] FOREIGN KEY([codigo_factura])
REFERENCES [dbo].[venta] ([codigo_factura])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_venta]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_cargo] FOREIGN KEY([codigo_cargo])
REFERENCES [dbo].[cargo] ([codigo_cargo])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_cargo]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_categoria] FOREIGN KEY([codigo_categoria])
REFERENCES [dbo].[categoria] ([codigo_categoria])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_categoria]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol] FOREIGN KEY([codigo_rol])
REFERENCES [dbo].[rol] ([codigo_rol])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_rol]
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EditarUsuario](

@cedula_persona varchar (11),
@nombre_persona varchar (20),
@apellido_persona varchar(20),
@direccion text,
@telefono varchar (12),
@correo varchar (30),
@Respuesta  bit output,
@Mensaje varchar (500) output
)
as
begin
set @Respuesta = 0
set @Mensaje = ''

if not exists(select * from persona where cedula_persona = @cedula_persona and cedula_persona != @cedula_persona)

begin

update persona set
cedula_persona = @cedula_persona,
nombre_persona = @nombre_persona,
apellido_persona=@apellido_persona,
direccion=@direccion,
telefono= @telefono,
correo=@correo
where cedula_persona = @cedula_persona

set @Respuesta = 1

end
else
set @Mensaje = 'Cedula ya existente'
end
GO
/****** Object:  StoredProcedure [dbo].[RegistrarUsuario]    Script Date: 18/01/2024 11:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarUsuario](

@cedula_persona varchar (11),
@nombre_persona varchar (20),
@apellido_persona varchar(20),
@direccion text,
@telefono varchar (12),
@correo varchar (30),
/*@UsuarioResultado int output,*/
@Mensaje varchar (500) output
)
as
begin

/*set @UsuarioResultado = 0*/
set @Mensaje = ''

if not exists(select * from persona where cedula_persona = @cedula_persona)
begin

insert into persona(cedula_persona, nombre_persona, apellido_persona, direccion, telefono, correo) values
(@cedula_persona, @nombre_persona, @apellido_persona, @direccion, @telefono, @correo)

/*set @UsuarioResultado = SCOPE_IDENTITY()*/

end
else
set @Mensaje = 'Ya hay un usuario existente con esta cedula'
end
GO
USE [master]
GO
ALTER DATABASE [MarketManagerBD] SET  READ_WRITE 
GO
