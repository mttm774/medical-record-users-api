SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'medicaldb')
BEGIN
    CREATE DATABASE medicalbd;
END
GO
USE medicalbd;
GO
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'medicaldb' AND TABLE_SCHEMA = 'dbo')
BEGIN
    CREATE TABLE [dbo].[User](
        [Id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
        [UserName] [varchar](50) NOT NULL,
        [Password] [varchar](100) NOT NULL,
        [Name] [varchar](50) NOT NULL,
        [Email] [varchar](100) NOT NULL,
        [Estado] [varchar](2) NOT NULL,
        [Intentos] [numeric](18, 0) NULL,
        [Firma] [nvarchar](300) NULL
    ) ON [PRIMARY]
END
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [UK_Email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [UK_UserName] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuario](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TipoDocumento] [varchar](2) NOT NULL,
	[NumeroDocumento] [varchar](20) NOT NULL,
	[PrimerApellido] [varchar](50) NOT NULL,
	[SegundoApellido] [varchar](50) NULL,
	[PrimerNombre] [varchar](50) NOT NULL,
	[SegundoNombre] [varchar](50) NULL,
	[EstadoCivil] [varchar](20) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Sexo] [varchar](2) NULL,
	[Ocupacion] [varchar](50) NULL,
	[Pais] [varchar](50) NULL,
	[Departamento] [varchar](50) NULL,
	[Municipio] [varchar](50) NULL,
	[BarrioVereda] [varchar](50) NULL,
	[Zona] [varchar](1) NULL,
	[Direccion] [varchar](100) NULL,
	[Estrato] [varchar](20) NULL,
	[TelefonoContacto] [varchar](50) NULL,
	[TelefonoResidencia] [varchar](50) NULL,
	[NombresPadre] [varchar](50) NULL,
	[NombresMadre] [varchar](50) NULL,
	[NombresAcudiente] [varchar](50) NULL,
	[TelefonoPadres] [varchar](50) NULL,
	[TelefonoAcudiente] [varchar](50) NULL,
	[NombreEPS] [varchar](100) NULL,
	[CodigoEPS] [varchar](10) NULL,
	[Regimen] [varchar](1) NULL,
	[NombreIPS] [varchar](100) NULL,
	[CodigoIPS] [varchar](20) NULL,
	[TipoIdentificacionIPS] [varchar](2) NULL,
	[Discapacidad] [varchar](100) NULL,
	[GrupoEtnico] [varchar](50) NULL,
	[Observaciones] [varchar](max) NULL,
	[Foto] [image] NULL,
	[Email] [varchar](100) NULL,
	[Estado] [varchar](2) NOT NULL,
	[localidad] [varchar](50) NULL,
	[Area] [varchar](100) NULL,
	[Posicion] [varchar](100) NULL,
	[AceptacionConsentimiento] [varchar](1) NULL,
	[AceptacionDatosPersonales] [varchar](1) NULL,
	[ParentescoAcudiente] [varchar](50) NULL,
	[recuperacion] [varchar](2) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UK_NumDocUsuario] UNIQUE NONCLUSTERED 
(
	[NumeroDocumento] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO