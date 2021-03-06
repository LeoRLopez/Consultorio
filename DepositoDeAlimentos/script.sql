USE [Deposito]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClasificaEn]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClasificaEn](
	[IdClasificaEn] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClasificaEn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Envase]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Envase](
	[IdEnvase] [int] IDENTITY(1,1) NOT NULL,
	[Peso] [float] NULL,
	[Volumen] [float] NULL,
	[Descripcion] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEnvase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EstadoLote]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoLote](
	[Codigo] [varchar](1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FichaInventario]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FichaInventario](
	[IdFichaInventario] [int] IDENTITY(1,1) NOT NULL,
	[IdLote] [int] NOT NULL,
	[CodigoEstadoLote] [varchar](1) NOT NULL,
	[Año] [int] NULL,
	[Semana] [date] NULL,
	[OberservacionesGenerales] [varchar](150) NULL,
	[IdTecnicoBromatologico] [int] NOT NULL,
 CONSTRAINT [PK__FichaInv__672E4C6D8DB0304B] PRIMARY KEY CLUSTERED 
(
	[IdFichaInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Incluye]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incluye](
	[IdIncluye] [int] IDENTITY(1,1) NOT NULL,
	[NroMarcoRegulatorio] [varchar](1) NOT NULL,
	[IdVerificacion] [int] NOT NULL,
	[NombreTecnico] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIncluye] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ListaVerificacion]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaVerificacion](
	[IdListaVerificacion] [int] IDENTITY(1,1) NOT NULL,
	[IdVerificacion] [int] NOT NULL,
	[IdFichaInventario] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Resultado] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdListaVerificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lote]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lote](
	[IdLote] [int] IDENTITY(1,1) NOT NULL,
	[FechaEntrada] [date] NULL,
	[FechaRetiro] [date] NULL,
	[CantidadAlmacenada] [int] NULL,
	[IdPresentado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marca]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[NombreMarca] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MarcoRegulatorio]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MarcoRegulatorio](
	[Nro] [varchar](1) NOT NULL,
	[Duracion] [varchar](1) NULL,
	[TemperaturaMinima] [float] NULL,
	[TemperaturaMaxima] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Presentado]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presentado](
	[IdPresentado] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdEnvase] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPresentado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[RNE] [char](6) NOT NULL,
	[RNPA] [char](7) NOT NULL,
	[IdMarca] [int] NOT NULL,
	[NombreFantasIa] [varchar](50) NOT NULL,
	[Descripcion] [varchar](150) NULL,
	[FechaEmision] [date] NULL,
	[FechaVencimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReguladoPor]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReguladoPor](
	[IdReguladoPor] [int] IDENTITY(1,1) NOT NULL,
	[IdPresentado] [int] NOT NULL,
	[NroMarcoRegulatorio] [varchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReguladoPor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TecnicoBromatologico]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TecnicoBromatologico](
	[TecnicoId] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [nvarchar](100) NOT NULL,
	[DNI] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TecnicoBromatologico] PRIMARY KEY CLUSTERED 
(
	[TecnicoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Verificacion]    Script Date: 30-Nov-18 14:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Verificacion](
	[IdVerificacion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVerificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (1, N'Cagegoria 1')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (2, N'Cagegoria 2')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (3, N'Cagegoria 3')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[ClasificaEn] ON 

INSERT [dbo].[ClasificaEn] ([IdClasificaEn], [IdProducto], [IdCategoria]) VALUES (1, 1, 1)
INSERT [dbo].[ClasificaEn] ([IdClasificaEn], [IdProducto], [IdCategoria]) VALUES (2, 2, 2)
INSERT [dbo].[ClasificaEn] ([IdClasificaEn], [IdProducto], [IdCategoria]) VALUES (3, 1, 3)
INSERT [dbo].[ClasificaEn] ([IdClasificaEn], [IdProducto], [IdCategoria]) VALUES (4, 3, 1)
INSERT [dbo].[ClasificaEn] ([IdClasificaEn], [IdProducto], [IdCategoria]) VALUES (5, 2, 3)
SET IDENTITY_INSERT [dbo].[ClasificaEn] OFF
SET IDENTITY_INSERT [dbo].[Envase] ON 

INSERT [dbo].[Envase] ([IdEnvase], [Peso], [Volumen], [Descripcion]) VALUES (1, 1, 2, N'envase test')
INSERT [dbo].[Envase] ([IdEnvase], [Peso], [Volumen], [Descripcion]) VALUES (2, 2, 2, N'envase test 2')
SET IDENTITY_INSERT [dbo].[Envase] OFF
INSERT [dbo].[EstadoLote] ([Codigo], [Descripcion]) VALUES (N'D', N'Distribuido')
INSERT [dbo].[EstadoLote] ([Codigo], [Descripcion]) VALUES (N'P', N'En sotck')
SET IDENTITY_INSERT [dbo].[FichaInventario] ON 

INSERT [dbo].[FichaInventario] ([IdFichaInventario], [IdLote], [CodigoEstadoLote], [Año], [Semana], [OberservacionesGenerales], [IdTecnicoBromatologico]) VALUES (2, 1, N'D', 2018, CAST(N'2018-01-01' AS Date), N'test', 1)
SET IDENTITY_INSERT [dbo].[FichaInventario] OFF
SET IDENTITY_INSERT [dbo].[ListaVerificacion] ON 

INSERT [dbo].[ListaVerificacion] ([IdListaVerificacion], [IdVerificacion], [IdFichaInventario], [Fecha], [Hora], [Resultado]) VALUES (1, 1, 2, CAST(N'2018-01-11' AS Date), CAST(N'14:25:00' AS Time), N'Ok')
SET IDENTITY_INSERT [dbo].[ListaVerificacion] OFF
SET IDENTITY_INSERT [dbo].[Lote] ON 

INSERT [dbo].[Lote] ([IdLote], [FechaEntrada], [FechaRetiro], [CantidadAlmacenada], [IdPresentado]) VALUES (1, CAST(N'2018-12-01' AS Date), CAST(N'2018-12-10' AS Date), 10, 1)
SET IDENTITY_INSERT [dbo].[Lote] OFF
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([IdMarca], [NombreMarca]) VALUES (1, N'Marca 1')
INSERT [dbo].[Marca] ([IdMarca], [NombreMarca]) VALUES (2, N'Marca 2')
INSERT [dbo].[Marca] ([IdMarca], [NombreMarca]) VALUES (3, N'Marca 3')
SET IDENTITY_INSERT [dbo].[Marca] OFF
INSERT [dbo].[MarcoRegulatorio] ([Nro], [Duracion], [TemperaturaMinima], [TemperaturaMaxima]) VALUES (N'1', N'1', 1, 1)
INSERT [dbo].[MarcoRegulatorio] ([Nro], [Duracion], [TemperaturaMinima], [TemperaturaMaxima]) VALUES (N'2', N'2', 2, 2)
INSERT [dbo].[MarcoRegulatorio] ([Nro], [Duracion], [TemperaturaMinima], [TemperaturaMaxima]) VALUES (N'3', N'3', 3, 3)
SET IDENTITY_INSERT [dbo].[Presentado] ON 

INSERT [dbo].[Presentado] ([IdPresentado], [IdProducto], [IdEnvase]) VALUES (1, 1, 1)
INSERT [dbo].[Presentado] ([IdPresentado], [IdProducto], [IdEnvase]) VALUES (2, 1, 2)
INSERT [dbo].[Presentado] ([IdPresentado], [IdProducto], [IdEnvase]) VALUES (3, 2, 1)
INSERT [dbo].[Presentado] ([IdPresentado], [IdProducto], [IdEnvase]) VALUES (4, 3, 2)
SET IDENTITY_INSERT [dbo].[Presentado] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [RNE], [RNPA], [IdMarca], [NombreFantasIa], [Descripcion], [FechaEmision], [FechaVencimiento]) VALUES (1, N'1     ', N'1      ', 1, N'Producto 1', N'test', CAST(N'2018-11-01' AS Date), CAST(N'2019-11-01' AS Date))
INSERT [dbo].[Producto] ([IdProducto], [RNE], [RNPA], [IdMarca], [NombreFantasIa], [Descripcion], [FechaEmision], [FechaVencimiento]) VALUES (2, N'2     ', N'2      ', 2, N'Producto 2', N'test 2', CAST(N'2018-11-01' AS Date), CAST(N'2019-11-01' AS Date))
INSERT [dbo].[Producto] ([IdProducto], [RNE], [RNPA], [IdMarca], [NombreFantasIa], [Descripcion], [FechaEmision], [FechaVencimiento]) VALUES (3, N'3     ', N'3      ', 3, N'Producto 3', N'test 3', CAST(N'2018-11-01' AS Date), CAST(N'2020-11-01' AS Date))
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[TecnicoBromatologico] ON 

INSERT [dbo].[TecnicoBromatologico] ([TecnicoId], [NombreCompleto], [DNI]) VALUES (1, N'Tecnico Bromatologico 1', N'1')
INSERT [dbo].[TecnicoBromatologico] ([TecnicoId], [NombreCompleto], [DNI]) VALUES (2, N'Tecnico Bromatologico 2', N'2')
INSERT [dbo].[TecnicoBromatologico] ([TecnicoId], [NombreCompleto], [DNI]) VALUES (3, N'Tecnico Bromatologico 3', N'3')
SET IDENTITY_INSERT [dbo].[TecnicoBromatologico] OFF
SET IDENTITY_INSERT [dbo].[Verificacion] ON 

INSERT [dbo].[Verificacion] ([IdVerificacion], [Descripcion]) VALUES (1, N'Tipo Verificacion 1')
INSERT [dbo].[Verificacion] ([IdVerificacion], [Descripcion]) VALUES (2, N'Tipo Verificacion 2')
INSERT [dbo].[Verificacion] ([IdVerificacion], [Descripcion]) VALUES (3, N'Tipo Verificacion 3')
SET IDENTITY_INSERT [dbo].[Verificacion] OFF
ALTER TABLE [dbo].[ClasificaEn]  WITH CHECK ADD  CONSTRAINT [FK_ClasificaEn_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[ClasificaEn] CHECK CONSTRAINT [FK_ClasificaEn_Categoria]
GO
ALTER TABLE [dbo].[ClasificaEn]  WITH CHECK ADD  CONSTRAINT [FK_ClasificaEn_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[ClasificaEn] CHECK CONSTRAINT [FK_ClasificaEn_Producto]
GO
ALTER TABLE [dbo].[FichaInventario]  WITH CHECK ADD  CONSTRAINT [FK_FichaInventario_TecnicoBromatologico] FOREIGN KEY([IdTecnicoBromatologico])
REFERENCES [dbo].[TecnicoBromatologico] ([TecnicoId])
GO
ALTER TABLE [dbo].[FichaInventario] CHECK CONSTRAINT [FK_FichaInventario_TecnicoBromatologico]
GO
ALTER TABLE [dbo].[FichaInventario]  WITH CHECK ADD  CONSTRAINT [FK__FichaInve__Codig__36B12243] FOREIGN KEY([CodigoEstadoLote])
REFERENCES [dbo].[EstadoLote] ([Codigo])
GO
ALTER TABLE [dbo].[FichaInventario] CHECK CONSTRAINT [FK__FichaInve__Codig__36B12243]
GO
ALTER TABLE [dbo].[FichaInventario]  WITH CHECK ADD  CONSTRAINT [FK__FichaInve__IdLot__35BCFE0A] FOREIGN KEY([IdLote])
REFERENCES [dbo].[Lote] ([IdLote])
GO
ALTER TABLE [dbo].[FichaInventario] CHECK CONSTRAINT [FK__FichaInve__IdLot__35BCFE0A]
GO
ALTER TABLE [dbo].[Incluye]  WITH CHECK ADD FOREIGN KEY([IdVerificacion])
REFERENCES [dbo].[Verificacion] ([IdVerificacion])
GO
ALTER TABLE [dbo].[Incluye]  WITH CHECK ADD FOREIGN KEY([NroMarcoRegulatorio])
REFERENCES [dbo].[MarcoRegulatorio] ([Nro])
GO
ALTER TABLE [dbo].[ListaVerificacion]  WITH CHECK ADD  CONSTRAINT [FK__ListaVeri__IdFic__46E78A0C] FOREIGN KEY([IdFichaInventario])
REFERENCES [dbo].[FichaInventario] ([IdFichaInventario])
GO
ALTER TABLE [dbo].[ListaVerificacion] CHECK CONSTRAINT [FK__ListaVeri__IdFic__46E78A0C]
GO
ALTER TABLE [dbo].[ListaVerificacion]  WITH CHECK ADD FOREIGN KEY([IdVerificacion])
REFERENCES [dbo].[Verificacion] ([IdVerificacion])
GO
ALTER TABLE [dbo].[Lote]  WITH CHECK ADD FOREIGN KEY([IdPresentado])
REFERENCES [dbo].[Presentado] ([IdPresentado])
GO
ALTER TABLE [dbo].[Presentado]  WITH CHECK ADD  CONSTRAINT [FK_Presentado_Envase] FOREIGN KEY([IdEnvase])
REFERENCES [dbo].[Envase] ([IdEnvase])
GO
ALTER TABLE [dbo].[Presentado] CHECK CONSTRAINT [FK_Presentado_Envase]
GO
ALTER TABLE [dbo].[Presentado]  WITH CHECK ADD  CONSTRAINT [FK_Presentado_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[Presentado] CHECK CONSTRAINT [FK_Presentado_Producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Marca] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marca] ([IdMarca])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Marca]
GO
ALTER TABLE [dbo].[ReguladoPor]  WITH CHECK ADD FOREIGN KEY([IdPresentado])
REFERENCES [dbo].[Presentado] ([IdPresentado])
GO
ALTER TABLE [dbo].[ReguladoPor]  WITH CHECK ADD FOREIGN KEY([NroMarcoRegulatorio])
REFERENCES [dbo].[MarcoRegulatorio] ([Nro])
GO
ALTER TABLE [dbo].[FichaInventario]  WITH CHECK ADD  CONSTRAINT [CK__FichaInvent__Año__37A5467C] CHECK  (([Año]>(0) AND [Año]<(9999)))
GO
ALTER TABLE [dbo].[FichaInventario] CHECK CONSTRAINT [CK__FichaInvent__Año__37A5467C]
GO
