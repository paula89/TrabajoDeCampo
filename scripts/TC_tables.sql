USE [TC]
GO
/****** Object:  Table [dbo].[MateriaPrima]    Script Date: 19/09/2020 1:56:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaPrima](
	[IdMateriaPrima] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Proveedor] [nvarchar](50) NOT NULL,
	[Cantidad] [float] NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Comentario] [nvarchar](150) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NOT NULL,
	[Habilitada] [bit] NOT NULL,
 CONSTRAINT [PK_MateriaPrima] PRIMARY KEY CLUSTERED 
(
	[IdMateriaPrima] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




USE [TC]
GO

/****** Object:  Table [dbo].[Herramientas]    Script Date: 13/11/2020 2:21:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Herramientas](
	[IdHerramienta] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Proveedor] [nvarchar](50) NOT NULL,
	[Comentario] [nvarchar](100) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[TiempoDeUso] [float] NOT NULL,
	[Habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Herramientas] PRIMARY KEY CLUSTERED 
(
	[IdHerramienta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [TC]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 13/11/2020 2:22:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productos](
	[IdProducto] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Comentario] [nvarchar](50) NULL,
	[MateriasPrimas] [nvarchar](50) NOT NULL,
	[Herramientas] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [TC]
GO

/****** Object:  Table [dbo].[Promociones]    Script Date: 13/11/2020 2:23:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Promociones](
	[IdPromocion] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descuento] [int] NOT NULL,
	[Vigencia] [datetime] NOT NULL,
	[Comentario] [nvarchar](50) NULL,
	[Habilitado] [bit] NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
 CONSTRAINT [PK_Promociones] PRIMARY KEY CLUSTERED 
(
	[IdPromocion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO








