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
