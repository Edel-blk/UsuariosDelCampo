USE [master]
GO
/****** Object:  Database [EjemploBD]    Script Date: 14/12/2023 01:51:28 p. m. ******/
CREATE DATABASE [EjemploBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EjemploBD', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\EjemploBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EjemploBD_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\EjemploBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [EjemploBD] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EjemploBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EjemploBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EjemploBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EjemploBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EjemploBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EjemploBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [EjemploBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EjemploBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EjemploBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EjemploBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EjemploBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EjemploBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EjemploBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EjemploBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EjemploBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EjemploBD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EjemploBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EjemploBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EjemploBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EjemploBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EjemploBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EjemploBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EjemploBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EjemploBD] SET RECOVERY FULL 
GO
ALTER DATABASE [EjemploBD] SET  MULTI_USER 
GO
ALTER DATABASE [EjemploBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EjemploBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EjemploBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EjemploBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EjemploBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EjemploBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EjemploBD', N'ON'
GO
ALTER DATABASE [EjemploBD] SET QUERY_STORE = ON
GO
ALTER DATABASE [EjemploBD] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [EjemploBD]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 14/12/2023 01:51:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Direccion] [nvarchar](100) NOT NULL,
	[Nacionalidad] [nvarchar](30) NOT NULL,
	[Sexo] [nvarchar](1) NOT NULL,
	[RutaImagen] [nvarchar](100) NULL,
	[FechaActualizacion] [datetime] NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [Nombre], [FechaNacimiento], [Direccion], [Nacionalidad], [Sexo], [RutaImagen], [FechaActualizacion], [Activo]) VALUES (20, N'Juan Perez', CAST(N'1990-05-15T00:00:00.000' AS DateTime), N'Calle Principal 123', N'Mexicana', N'M', N'ruta/imagen1.jpg', CAST(N'2023-12-14T13:45:25.997' AS DateTime), 1)
INSERT [dbo].[Usuarios] ([ID], [Nombre], [FechaNacimiento], [Direccion], [Nacionalidad], [Sexo], [RutaImagen], [FechaActualizacion], [Activo]) VALUES (21, N'Maria Gomez', CAST(N'1985-08-20T00:00:00.000' AS DateTime), N'Avenida Secundaria 456', N'Estadounidense', N'F', N'ruta/imagen1.jpg', CAST(N'2023-12-14T13:46:28.130' AS DateTime), 0)
INSERT [dbo].[Usuarios] ([ID], [Nombre], [FechaNacimiento], [Direccion], [Nacionalidad], [Sexo], [RutaImagen], [FechaActualizacion], [Activo]) VALUES (22, N'Carlos Rodríguez', CAST(N'1985-08-20T00:00:00.000' AS DateTime), N'Avenida Secundaria 1', N'Otro', N'M', N'ruta/imagen2.jpg', CAST(N'2023-12-14T13:47:01.703' AS DateTime), 1)
INSERT [dbo].[Usuarios] ([ID], [Nombre], [FechaNacimiento], [Direccion], [Nacionalidad], [Sexo], [RutaImagen], [FechaActualizacion], [Activo]) VALUES (23, N'Ana Martinez', CAST(N'1990-05-15T00:00:00.000' AS DateTime), N'Calle', N'Mexicana', N'F', N'ruta/imagen1.jpg', CAST(N'2023-12-14T13:47:18.123' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [FechaActualizacion]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 14/12/2023 01:51:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteUser]
    @ID INT
AS
BEGIN
    DELETE FROM Usuarios WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 14/12/2023 01:51:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertUser]
    @name NVARCHAR(50),
    @bornDate DATETIME,
    @direction NVARCHAR(100),
    @country NVARCHAR(30),
    @genre NVARCHAR(1),
    @imagePath NVARCHAR(100),
    @active BIT
AS
BEGIN
    INSERT INTO usuarios (Nombre, FechaNacimiento, Direccion, Nacionalidad, Sexo, RutaImagen, Activo)
    VALUES (@name, @bornDate, @direction, @country, @genre, @imagePath, @active);

    SELECT SCOPE_IDENTITY() AS GeneratedID; -- Retorna el ID generado
END;
GO
/****** Object:  StoredProcedure [dbo].[SearchUser]    Script Date: 14/12/2023 01:51:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchUser]
    @ID INT
AS
BEGIN
    SELECT 
        ID,
        Nombre,
        FechaNacimiento,
        Direccion,
        Nacionalidad,
        Sexo,
        RutaImagen,
        Activo
    FROM usuarios
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 14/12/2023 01:51:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateUser]
    @id INT,
    @name NVARCHAR(50),
    @bornDate DATETIME,
    @direction NVARCHAR(100),
    @country NVARCHAR(30),
    @genre NVARCHAR(1),
    @imagePath NVARCHAR(100),
    @active BIT
AS
BEGIN
    UPDATE usuarios
    SET Nombre = @name,
        FechaNacimiento = @bornDate,
        Direccion = @direction,
        Nacionalidad = @country,
        Sexo = @genre,
        RutaImagen = @imagePath,
        Activo = @active,
		FechaActualizacion = GETDATE()
    WHERE ID = @id;
END;
GO
USE [master]
GO
ALTER DATABASE [EjemploBD] SET  READ_WRITE 
GO
