USE [TP LUG]
GO
/****** Object:  Table [dbo].[Actividad]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividad](
	[ID_Actividad] [int] IDENTITY(1,1) NOT NULL,
	[Deporte] [nvarchar](50) NULL,
	[Precio] [int] NULL,
	[Turno] [nvarchar](50) NULL,
	[ID_Profesor] [int] NULL,
 CONSTRAINT [PK_Actividad] PRIMARY KEY CLUSTERED 
(
	[ID_Actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID_Login] [int] NOT NULL,
	[Usuario] [nvarchar](50) NULL,
	[Contraseña] [nvarchar](50) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID_Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[ID_Profesor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[FechaNac] [date] NULL,
	[Sueldo] [int] NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[ID_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socio](
	[ID_Socio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[FechaNac] [date] NULL,
	[Pago] [nvarchar](50) NULL,
 CONSTRAINT [PK_Socio] PRIMARY KEY CLUSTERED 
(
	[ID_Socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socio_Actividad]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socio_Actividad](
	[ID_Socio] [int] NULL,
	[ID_Actividad] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Actividad_Profesor] FOREIGN KEY([ID_Profesor])
REFERENCES [dbo].[Profesor] ([ID_Profesor])
GO
ALTER TABLE [dbo].[Actividad] CHECK CONSTRAINT [FK_Actividad_Profesor]
GO
ALTER TABLE [dbo].[Socio_Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Socio_Actividad_Actividad] FOREIGN KEY([ID_Actividad])
REFERENCES [dbo].[Actividad] ([ID_Actividad])
GO
ALTER TABLE [dbo].[Socio_Actividad] CHECK CONSTRAINT [FK_Socio_Actividad_Actividad]
GO
ALTER TABLE [dbo].[Socio_Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Socio_Actividad_Socio] FOREIGN KEY([ID_Socio])
REFERENCES [dbo].[Socio] ([ID_Socio])
GO
ALTER TABLE [dbo].[Socio_Actividad] CHECK CONSTRAINT [FK_Socio_Actividad_Socio]
GO
/****** Object:  StoredProcedure [dbo].[S_Actividad_Alta]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Actividad_Alta]
	-- Add the parameters for the stored procedure here
	@Deporte nvarchar(50),
	@Precio int,
	@Turno nvarchar(50),
	@CodProfesor int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Actividad(Deporte, Precio, Turno, ID_Profesor) 
	VALUES(@Deporte, @Precio, @Turno, @CodProfesor)

END
GO
/****** Object:  StoredProcedure [dbo].[S_Actividad_Asociada]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Actividad_Asociada]
	-- Add the parameters for the stored procedure here
	@CodActividad int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT (ID_Actividad) 
	FROM Socio_Actividad
	WHERE ID_Actividad = @CodActividad

END
GO
/****** Object:  StoredProcedure [dbo].[S_Actividad_Baja]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Actividad_Baja]
	-- Add the parameters for the stored procedure here
	@CodActividad int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Actividad 
	WHERE ID_Actividad = @CodActividad

END
GO
/****** Object:  StoredProcedure [dbo].[S_Actividad_Contador]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Actividad_Contador]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(ID_Actividad) FROM Actividad

END
GO
/****** Object:  StoredProcedure [dbo].[S_Actividad_ListarTodo]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Actividad_ListarTodo]


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Actividad.ID_Actividad, Actividad.Deporte, Actividad.Precio, Actividad.Turno, Profesor.ID_Profesor, Profesor.Nombre, Profesor.Apellido, Profesor.FechaNac, Profesor.Sueldo 
	FROM Actividad, Profesor
	WHERE Actividad.ID_Profesor = Profesor.ID_Profesor

END
GO
/****** Object:  StoredProcedure [dbo].[S_Actividad_Modificar]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Actividad_Modificar]
	-- Add the parameters for the stored procedure here
	@CodActividad int,
	@Deporte nvarchar(50),
	@Precio int,
	@Turno nvarchar(50),
	@CodProfesor int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Actividad SET Deporte = @Deporte, Precio = @Precio, Turno = @Turno, ID_Profesor = @CodProfesor 
	WHERE ID_Actividad = @CodActividad

END
GO
/****** Object:  StoredProcedure [dbo].[S_Login_Logear]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Login_Logear]
	-- Add the parameters for the stored procedure here
	@Usuario nvarchar(50),
	@Contraseña nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Usuario, Contraseña 
	FROM Login 
	WHERE Usuario = @Usuario and Contraseña = @Contraseña

END
GO
/****** Object:  StoredProcedure [dbo].[S_Profesor_Alta]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Profesor_Alta]
	-- Add the parameters for the stored procedure here
	@Nombre nvarchar(50),
	@Apellido nvarchar(50),
	@FechaNac date,
	@Sueldo int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Profesor(Nombre, Apellido, FechaNac, Sueldo) 
	VALUES(@Nombre, @Apellido, @FechaNac, @Sueldo)
END
GO
/****** Object:  StoredProcedure [dbo].[S_Profesor_Asociado]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Profesor_Asociado]
	-- Add the parameters for the stored procedure here
	@CodProfesor int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(ID_Profesor) 
	FROM Actividad 
	WHERE ID_Profesor = @CodProfesor
END
GO
/****** Object:  StoredProcedure [dbo].[S_Profesor_Baja]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Profesor_Baja]
	-- Add the parameters for the stored procedure here
	@CodProfesor int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Profesor WHERE ID_Profesor = @CodProfesor
END
GO
/****** Object:  StoredProcedure [dbo].[S_Profesor_Contador]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Profesor_Contador]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(ID_Profesor) FROM Profesor
END
GO
/****** Object:  StoredProcedure [dbo].[S_Profesor_ListarTodo]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[S_Profesor_ListarTodo] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID_Profesor, Nombre, Apellido, FechaNac, Sueldo FROM Profesor
END
GO
/****** Object:  StoredProcedure [dbo].[S_Profesor_Modificar]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Profesor_Modificar]
	-- Add the parameters for the stored procedure here
	@CodProfesor int,
	@Nombre nvarchar(50),
	@Apellido nvarchar(50),
	@FechaNac date,
	@Sueldo int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Profesor SET Nombre = @Nombre, Apellido = @Apellido, FechaNac = @FechaNac, Sueldo = @Sueldo
	WHERE ID_Profesor = @CodProfesor
END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_ActividadSocio]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_ActividadSocio]
	-- Add the parameters for the stored procedure here

	@ID_Socio int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT A.ID_Actividad, A.Deporte, A.Precio, A.Turno, P.ID_Profesor, P.Nombre, P.Apellido, P.FechaNac, P.Sueldo 
	FROM Actividad as A, Profesor as P, Socio_Actividad 
	WHERE A.ID_Profesor = P.ID_Profesor and A.ID_Actividad = Socio_Actividad.ID_Actividad and Socio_Actividad.ID_Socio = @ID_Socio

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_AgregarActividad]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_AgregarActividad]
	-- Add the parameters for the stored procedure here
	@CodSocio int,
	@CodActividad int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Socio_Actividad(ID_Socio, ID_Actividad) 
	VALUES(@CodSocio, @CodActividad)

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_Alta]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_Alta]
	-- Add the parameters for the stored procedure here
	@Nombre nvarchar (50),
	@Apellido nvarchar (50),
	@FechaNac date,
	@Pago nvarchar (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Socio(Nombre, Apellido, FechaNac, Pago) 
	VALUES(@Nombre, @Apellido, @FechaNac, @Pago)

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_Baja]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_Baja]
	-- Add the parameters for the stored procedure here
	@CodSocio int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Socio WHERE ID_Socio = @CodSocio

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_BuscarSocio]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_BuscarSocio]
	-- Add the parameters for the stored procedure here
	@Nombre nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID_Socio, Nombre, Apellido, FechaNac, Pago 
	FROM Socio 
	WHERE Nombre = @Nombre

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_Contador]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_Contador]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(ID_Socio) FROM Socio

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_ListarTodo]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_ListarTodo] 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID_Socio, Nombre, Apellido, FechaNac, Pago 
	FROM Socio

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_Modificar]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_Modificar]
	-- Add the parameters for the stored procedure here
	@CodSocio int,
	@Nombre nvarchar (50),
	@Apellido nvarchar (50),
	@FechaNac date,
	@Pago nvarchar (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Socio SET Nombre = @Nombre, Apellido = @Apellido , FechaNac = @FechaNac, Pago = @Pago WHERE ID_Socio = @CodSocio

END
GO
/****** Object:  StoredProcedure [dbo].[S_Socio_QuitarActividad]    Script Date: 02/11/2022 16:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[S_Socio_QuitarActividad]
	-- Add the parameters for the stored procedure here
	@CodSocio int,
	@CodActividad int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Socio_Actividad 
	WHERE ID_Socio = @CodSocio and ID_Actividad = @CodActividad

END
GO
