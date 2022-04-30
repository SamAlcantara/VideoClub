USE [VideoClub_db]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[ID] [int] NOT NULL,
	[Titulo] [varchar](500) NULL,
	[Tipo_de_articulo_ID] [int] NULL,
	[Idioma_ID] [int] NULL,
	[Renta_por_dia] [float] NULL,
	[Dias_de_renta] [varchar](40) NULL,
	[Monto_entrega_tardia] [float] NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK__Articulo__3214EC27E24E0ADE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](500) NULL,
	[Cedula] [varchar](20) NULL,
	[Num_tarjeta_CR] [int] NULL,
	[Limite_de_credito] [float] NULL,
	[Tipo_persona] [varchar](20) NULL,
	[Estado] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Elenco]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elenco](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Elenco_articulo]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elenco_articulo](
	[Articulo] [int] NOT NULL,
	[Elenco] [int] NULL,
	[Rol] [varchar](50) NULL,
 CONSTRAINT [PK_Elenco_articulo] PRIMARY KEY CLUSTERED 
(
	[Articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](500) NULL,
	[Cedula] [varchar](20) NULL,
	[Tanda_labor] [varchar](40) NULL,
	[Porciento_comision] [varchar](10) NULL,
	[Fecha_ingreso] [datetime] NULL,
	[Estado] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Renta_Devolucion]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Renta_Devolucion](
	[Num_de_renta] [int] NOT NULL,
	[Empleado] [int] NULL,
	[Articulo] [int] NULL,
	[Cliente] [int] NULL,
	[Fecha_renta] [datetime] NULL,
	[Fecha_devolucion] [datetime] NULL,
	[Renta_por_dia] [float] NULL,
	[Dias_de_renta] [varchar](40) NULL,
	[Comentario] [varchar](500) NULL,
	[Estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Num_de_renta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_de_artículo]    Script Date: 29/4/2022 8:55:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_de_artículo](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](500) NULL,
	[Estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Idiomas] FOREIGN KEY([Idioma_ID])
REFERENCES [dbo].[Idiomas] ([ID])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Idiomas]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Tipo_de_artículo] FOREIGN KEY([Tipo_de_articulo_ID])
REFERENCES [dbo].[Tipo_de_artículo] ([ID])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Tipo_de_artículo]
GO
ALTER TABLE [dbo].[Elenco_articulo]  WITH CHECK ADD  CONSTRAINT [FK_Elenco_articulo_Articulos] FOREIGN KEY([Articulo])
REFERENCES [dbo].[Articulos] ([ID])
GO
ALTER TABLE [dbo].[Elenco_articulo] CHECK CONSTRAINT [FK_Elenco_articulo_Articulos]
GO
ALTER TABLE [dbo].[Elenco_articulo]  WITH CHECK ADD  CONSTRAINT [FK_Elenco_articulo_Elenco] FOREIGN KEY([Elenco])
REFERENCES [dbo].[Elenco] ([ID])
GO
ALTER TABLE [dbo].[Elenco_articulo] CHECK CONSTRAINT [FK_Elenco_articulo_Elenco]
GO
ALTER TABLE [dbo].[Renta_Devolucion]  WITH CHECK ADD  CONSTRAINT [FK__Renta_Dev__Artic__44FF419A] FOREIGN KEY([Articulo])
REFERENCES [dbo].[Articulos] ([ID])
GO
ALTER TABLE [dbo].[Renta_Devolucion] CHECK CONSTRAINT [FK__Renta_Dev__Artic__44FF419A]
GO
ALTER TABLE [dbo].[Renta_Devolucion]  WITH CHECK ADD FOREIGN KEY([Cliente])
REFERENCES [dbo].[Clientes] ([ID])
GO
ALTER TABLE [dbo].[Renta_Devolucion]  WITH CHECK ADD FOREIGN KEY([Empleado])
REFERENCES [dbo].[Empleados] ([ID])
GO
