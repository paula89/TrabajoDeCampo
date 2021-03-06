USE [TCSecurity]
GO
/****** Object:  Table [dbo].[Backup]    Script Date: 19/09/2020 1:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Backup](
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Path] [nvarchar](256) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 19/09/2020 1:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [nvarchar](512) NOT NULL,
	[Criticidad] [nvarchar](50) NOT NULL,
	[Usuario] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuracion]    Script Date: 19/09/2020 1:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuracion](
	[Id] [nvarchar](50) NOT NULL,
	[Clave] [nvarchar](50) NOT NULL,
	[Value] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Configuracion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 19/09/2020 1:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [nvarchar](50) NOT NULL,
	[role] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 19/09/2020 1:47:22 ******/
USE [TCSecurity]
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/11/2020 2:24:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios](
	[Usuario] [nchar](10) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](150) NOT NULL,
	[Permisos] [nvarchar](150) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[Habilitado] [bit] NOT NULL,
	[DVH] [decimal](18, 0) NOT NULL,
	[Idioma] [nvarchar](10) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  StoredProcedure [dbo].[spFull_Backup]    Script Date: 19/09/2020 1:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spFull_Backup]

@ruta varchar(100)

as

DECLARE @Return INT
SET @Return = 0 


BEGIN TRY

		BACKUP DATABASE TCSecurity
		TO DISK = @ruta 
		WITH FORMAT,   
		NAME = 'Full Backup of security db';  

		SET @Return = 1	
	
END TRY 
BEGIN CATCH   
	--ROLLBACK TRAN
	SET @Return = 0	
END CATCH
RETURN @Return

GO
/****** Object:  StoredProcedure [dbo].[spRestoreBackup]    Script Date: 19/09/2020 1:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spRestoreBackup]

@ruta varchar(100)

as

DECLARE @Return INT
SET @Return = 0 


BEGIN TRY

	RESTORE DATABASE TCSecurity FROM DISK = @ruta

END TRY 
BEGIN CATCH   
	--ROLLBACK TRAN
	SET @Return = 0	
END CATCH
RETURN @Return

GO
