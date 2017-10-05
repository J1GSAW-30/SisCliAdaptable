USE [master]
GO
/****** Object:  Database [SISCLIAD_Med]    Script Date: 01/10/2017 07:51:00 p. m. ******/
IF EXISTS(SELECT name FROM sys.databases
	WHERE name = 'SISCLIAD_Med')
	DROP DATABASE SISCLIAD_Med
GO
CREATE DATABASE [SISCLIAD_Med]
GO
USE [SISCLIAD_Med]
GO
ALTER DATABASE [SISCLIAD_Med] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET ARITHABORT OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SISCLIAD_Med] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SISCLIAD_Med] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SISCLIAD_Med] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SISCLIAD_Med] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SISCLIAD_Med] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET RECOVERY FULL 
GO
ALTER DATABASE [SISCLIAD_Med] SET  MULTI_USER 
GO
ALTER DATABASE [SISCLIAD_Med] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SISCLIAD_Med] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SISCLIAD_Med] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SISCLIAD_Med] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SISCLIAD_Med', N'ON'
GO
USE [SISCLIAD_Med]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cita](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[fechaCrea] [date] NOT NULL,
	[horaCrea] [time](7) NOT NULL,
	[motivo] [varchar](150) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[idPaciente] [varchar](7) NOT NULL,
	[username] [varchar](10) NOT NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConsultaGral]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConsultaGral](
	[idConsulta] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [varchar](7) NOT NULL,
	[username] [varchar](10) NOT NULL,
	[motivoConsulta] [varchar](250) NOT NULL,
	[sintomas] [varchar](250) NULL,
	[diagnostico] [varchar](250) NULL,
	[observaciones] [varchar](250) NULL,
	[tratamiento] [varchar](250) NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[presionMax] [decimal](3, 2) NULL,
	[presionMin] [decimal](3, 2) NULL,
	[temp] [decimal](3, 2) NULL,
	[peso] [decimal](3, 2) NULL,
	[pulso] [int] NULL,
	[respiracion] [int] NULL,
	[observacionSignos] [varchar](250) NULL,
 CONSTRAINT [PK_ConsultaGral] PRIMARY KEY CLUSTERED 
(
	[idConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InfoClinica]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InfoClinica](
	[idClinica] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ambito] [varchar](50) NULL,
	[telefono] [varchar](8) NULL,
	[direccion] [varchar](150) NULL,
	[logo] [image] NOT NULL,
 CONSTRAINT [PK_InfoClinica] PRIMARY KEY CLUSTERED 
(
	[idClinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NumEmergencia]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NumEmergencia](
	[correlativo] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [varchar](7) NULL,
	[nomEmergencia] [varchar](75) NULL,
	[telEmergencia] [varchar](8) NULL,
 CONSTRAINT [PK_NumEmergencia] PRIMARY KEY CLUSTERED 
(
	[correlativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[idPaciente] [varchar](7) NOT NULL,
	[priNombre] [varchar](25) NOT NULL,
	[segNombre] [varchar](25) NULL,
	[priApellido] [varchar](25) NOT NULL,
	[segApellido] [varchar](25) NULL,
	[dui] [varchar](9) NULL,
	[estadoCivil] [varchar](25) NULL,
	[genero] [varchar](10) NOT NULL,
	[fechaNac] [date] NOT NULL,
	[direccion] [varchar](150) NULL,
	[telFijo] [varchar](8) NULL,
	[telMovil] [varchar](8) NULL,
	[fotografia] [image] NULL,
	[antecedentes] [varchar](200) NULL,
	[fechaReg] [date] NOT NULL,
	[horaReg] [time](7) NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Receta]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receta](
	[idReceta] [int] IDENTITY(1,1) NOT NULL,
	[idConsulta] [int] NOT NULL,
	[medicamento] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Receta] PRIMARY KEY CLUSTERED 
(
	[idReceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 01/10/2017 07:51:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[username] [varchar](10) NOT NULL,
	[passwd] [varchar](16) NULL,
	[nombre] [varchar](100) NULL,
	[idRol] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Paciente]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Usuario] FOREIGN KEY([username])
REFERENCES [dbo].[Usuario] ([username])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Usuario]
GO
ALTER TABLE [dbo].[ConsultaGral]  WITH CHECK ADD  CONSTRAINT [FK_ConsultaGral_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[ConsultaGral] CHECK CONSTRAINT [FK_ConsultaGral_Paciente]
GO
ALTER TABLE [dbo].[ConsultaGral]  WITH CHECK ADD  CONSTRAINT [FK_ConsultaGral_Usuario] FOREIGN KEY([username])
REFERENCES [dbo].[Usuario] ([username])
GO
ALTER TABLE [dbo].[ConsultaGral] CHECK CONSTRAINT [FK_ConsultaGral_Usuario]
GO
ALTER TABLE [dbo].[NumEmergencia]  WITH CHECK ADD  CONSTRAINT [FK_NumEmergencia_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[NumEmergencia] CHECK CONSTRAINT [FK_NumEmergencia_Paciente]
GO
ALTER TABLE [dbo].[Receta]  WITH CHECK ADD  CONSTRAINT [FK_Receta_ConsultaGral] FOREIGN KEY([idConsulta])
REFERENCES [dbo].[ConsultaGral] ([idConsulta])
GO
ALTER TABLE [dbo].[Receta] CHECK CONSTRAINT [FK_Receta_ConsultaGral]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
USE [master]
GO
ALTER DATABASE [SISCLIAD_Med] SET  READ_WRITE 
GO
