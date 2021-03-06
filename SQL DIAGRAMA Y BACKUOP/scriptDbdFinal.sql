USE [registroEyRprueba]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 31/5/2022 22:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[iddepartamento] [int] IDENTITY(1,1) NOT NULL,
	[estadodep] [bit] NOT NULL,
	[nombredep] [nvarchar](30) NOT NULL,
	[descripciondep] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 31/5/2022 22:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idrempleado] [int] IDENTITY(1,1) NOT NULL,
	[estadoempleado] [bit] NOT NULL,
	[nombreempleado] [nvarchar](30) NOT NULL,
	[apellidoempleado] [nvarchar](30) NOT NULL,
	[direccion] [nvarchar](100) NULL,
	[telefono] [int] NOT NULL,
	[emailpersonal] [nvarchar](100) NULL,
	[emaillaboral] [nvarchar](100) NOT NULL,
	[idhorario] [int] NOT NULL,
	[idpuesto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleadologin]    Script Date: 31/5/2022 22:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleadologin](
	[idloginempleado] [int] IDENTITY(1,1) NOT NULL,
	[idlogin] [int] NOT NULL,
	[idrempleado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 31/5/2022 22:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario](
	[idhorario] [int] IDENTITY(1,1) NOT NULL,
	[descripcionhorario] [nvarchar](100) NOT NULL,
	[horadeentrada] [time](7) NOT NULL,
	[horadesalida] [time](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogIn]    Script Date: 31/5/2022 22:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogIn](
	[idlogin] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](60) NOT NULL,
	[contraseña] [nvarchar](60) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 31/5/2022 22:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[idpuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[descripcion] [nvarchar](100) NULL,
	[estado] [bit] NOT NULL,
	[iddepartamento] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegistrodeEyR]    Script Date: 31/5/2022 22:40:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistrodeEyR](
	[idregistro] [int] IDENTITY(1,1) NOT NULL,
	[tipodemarca] [datetime] NULL,
	[horademarca] [nvarchar](30) NOT NULL,
	[idrempleado] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departamento] ON 

INSERT [dbo].[Departamento] ([iddepartamento], [estadodep], [nombredep], [descripciondep]) VALUES (724, 1, N'Talento Humano', N'Equipo economico, contadorres, finanzas etc')
INSERT [dbo].[Departamento] ([iddepartamento], [estadodep], [nombredep], [descripciondep]) VALUES (725, 1, N'consultores', N'medicos generales(no cirujanos')
INSERT [dbo].[Departamento] ([iddepartamento], [estadodep], [nombredep], [descripciondep]) VALUES (727, 1, N'Sistemas', N'Ingenieria y encargados de informatica')
INSERT [dbo].[Departamento] ([iddepartamento], [estadodep], [nombredep], [descripciondep]) VALUES (728, 1, N'negocios', N'cualquier cosa')
INSERT [dbo].[Departamento] ([iddepartamento], [estadodep], [nombredep], [descripciondep]) VALUES (700, 1, N'Prueba', N'')
INSERT [dbo].[Departamento] ([iddepartamento], [estadodep], [nombredep], [descripciondep]) VALUES (733, 1, N'Mantenimiento', N'Gente encargada del aseo del locality')
SET IDENTITY_INSERT [dbo].[Departamento] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([idrempleado], [estadoempleado], [nombreempleado], [apellidoempleado], [direccion], [telefono], [emailpersonal], [emaillaboral], [idhorario], [idpuesto]) VALUES (251202, 1, N'Jason de Jesus', N'Esquivel River', N'Hermita de dolores', 75024102, N'kwzz1@hotmail.com', N'jason.esquivel@est.uca.edu.ni', 1, 1030)
INSERT [dbo].[Empleado] ([idrempleado], [estadoempleado], [nombreempleado], [apellidoempleado], [direccion], [telefono], [emailpersonal], [emaillaboral], [idhorario], [idpuesto]) VALUES (12345, 1, N'Leoncio Jose', N'pavon Larios', N'Managua', 123, N'leoncio@gmail.com', N'leoncio@gmail.com', 3, 1026)
INSERT [dbo].[Empleado] ([idrempleado], [estadoempleado], [nombreempleado], [apellidoempleado], [direccion], [telefono], [emailpersonal], [emaillaboral], [idhorario], [idpuesto]) VALUES (80981, 1, N'Elgya', N'Rivera', N'Enrique Lorente', 85653831, N'elgyben@hotmail,com', N'elgyben@hotmail,com', 5, 1025)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Horario] ON 

INSERT [dbo].[Horario] ([idhorario], [descripcionhorario], [horadeentrada], [horadesalida]) VALUES (1, N'horario matutino', CAST(N'07:00:00' AS Time), CAST(N'14:00:00' AS Time))
INSERT [dbo].[Horario] ([idhorario], [descripcionhorario], [horadeentrada], [horadesalida]) VALUES (2, N'horario vespertino', CAST(N'15:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Horario] ([idhorario], [descripcionhorario], [horadeentrada], [horadesalida]) VALUES (3, N'Horario Nocturnal', CAST(N'23:00:00' AS Time), CAST(N'07:00:00' AS Time))
INSERT [dbo].[Horario] ([idhorario], [descripcionhorario], [horadeentrada], [horadesalida]) VALUES (4, N'Turno.', CAST(N'03:00:00' AS Time), CAST(N'10:00:00' AS Time))
INSERT [dbo].[Horario] ([idhorario], [descripcionhorario], [horadeentrada], [horadesalida]) VALUES (5, N'turno2', CAST(N'00:00:00' AS Time), CAST(N'07:00:00' AS Time))
INSERT [dbo].[Horario] ([idhorario], [descripcionhorario], [horadeentrada], [horadesalida]) VALUES (7, N'prueba horario', CAST(N'00:00:00' AS Time), CAST(N'00:10:00' AS Time))
SET IDENTITY_INSERT [dbo].[Horario] OFF
GO
SET IDENTITY_INSERT [dbo].[LogIn] ON 

INSERT [dbo].[LogIn] ([idlogin], [usuario], [contraseña]) VALUES (1, N'admin', N'123')
SET IDENTITY_INSERT [dbo].[LogIn] OFF
GO
SET IDENTITY_INSERT [dbo].[Puesto] ON 

INSERT [dbo].[Puesto] ([idpuesto], [nombre], [descripcion], [estado], [iddepartamento]) VALUES (100, N'recursos humanos', N'encargado de personal', 1, 724)
INSERT [dbo].[Puesto] ([idpuesto], [nombre], [descripcion], [estado], [iddepartamento]) VALUES (1025, N'cargo de relaciones humanas', N'relacionado con el despido y contratacion de personal', 1, 724)
INSERT [dbo].[Puesto] ([idpuesto], [nombre], [descripcion], [estado], [iddepartamento]) VALUES (1027, N'Pruebita', N'Probando', 1, 700)
INSERT [dbo].[Puesto] ([idpuesto], [nombre], [descripcion], [estado], [iddepartamento]) VALUES (1030, N'Administrador de IT', N'prueba con la base de datos Y VERIFICA LA FUNIONALIDAD DE IT', 1, 727)
INSERT [dbo].[Puesto] ([idpuesto], [nombre], [descripcion], [estado], [iddepartamento]) VALUES (1026, N'Administrador de Servidores', N'Encargado del servidor local de la empresa', 1, 727)
SET IDENTITY_INSERT [dbo].[Puesto] OFF
GO
SET IDENTITY_INSERT [dbo].[RegistrodeEyR] ON 

INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (119, CAST(N'2022-05-24T20:43:18.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (95, CAST(N'2022-05-24T18:47:28.000' AS DateTime), N'24/5/22 20:38:31', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (120, CAST(N'2022-05-24T20:43:23.000' AS DateTime), N'24/5/22 20:43:44', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (121, CAST(N'2022-05-24T20:45:31.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (154, CAST(N'2022-05-27T21:31:33.000' AS DateTime), N'inicializandoempleado', 12345)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (113, CAST(N'2022-05-24T20:28:27.000' AS DateTime), N'24/5/22 20:37:30', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (122, CAST(N'2022-05-24T20:47:48.000' AS DateTime), N'24/5/22 20:55:18', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (128, CAST(N'2022-05-25T18:59:47.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (129, CAST(N'2022-05-25T18:59:50.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (130, CAST(N'2022-05-25T18:59:53.000' AS DateTime), N'25/5/22 19:00:05', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (131, CAST(N'2022-05-25T18:59:55.000' AS DateTime), N'no marcado', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (132, CAST(N'2022-05-25T18:59:59.000' AS DateTime), N'25/5/22 19:00:03', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (117, CAST(N'2022-05-24T20:42:29.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (118, CAST(N'2022-05-24T20:42:34.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (136, CAST(N'2022-05-26T06:32:40.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (137, CAST(N'2022-05-26T06:32:44.000' AS DateTime), N'26/5/22 06:32:51', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (138, CAST(N'2022-05-26T06:32:47.000' AS DateTime), N'26/5/22 06:32:49', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (126, CAST(N'2022-05-24T20:48:29.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (127, CAST(N'2022-05-24T20:48:33.000' AS DateTime), N'24/5/22 20:55:15', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (139, CAST(N'2022-05-26T06:33:37.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (140, CAST(N'2022-05-26T06:33:39.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (141, CAST(N'2022-05-26T06:33:42.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (142, CAST(N'2022-05-26T06:33:44.000' AS DateTime), N'26/5/22 06:34:17', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (143, CAST(N'2022-05-26T06:33:47.000' AS DateTime), N'no marcado', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (144, CAST(N'2022-05-26T06:33:49.000' AS DateTime), N'26/5/22 06:33:51', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (114, CAST(N'2022-05-24T20:40:50.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (115, CAST(N'2022-05-24T20:40:54.000' AS DateTime), N'no marcado', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (116, CAST(N'2022-05-24T20:40:57.000' AS DateTime), N'24/5/22 20:41:23', 251202)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (133, CAST(N'2022-05-25T19:06:09.000' AS DateTime), N'no marcado', 80981)
INSERT [dbo].[RegistrodeEyR] ([idregistro], [tipodemarca], [horademarca], [idrempleado]) VALUES (134, CAST(N'2022-05-25T19:06:12.000' AS DateTime), N'25/5/22 19:06:32', 80981)
SET IDENTITY_INSERT [dbo].[RegistrodeEyR] OFF
GO
/****** Object:  Index [PK3]    Script Date: 31/5/2022 22:40:24 ******/
ALTER TABLE [dbo].[Departamento] ADD  CONSTRAINT [PK3] PRIMARY KEY NONCLUSTERED 
(
	[iddepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK2]    Script Date: 31/5/2022 22:40:24 ******/
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [PK2] PRIMARY KEY NONCLUSTERED 
(
	[idrempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK8]    Script Date: 31/5/2022 22:40:24 ******/
ALTER TABLE [dbo].[Empleadologin] ADD  CONSTRAINT [PK8] PRIMARY KEY NONCLUSTERED 
(
	[idloginempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK4]    Script Date: 31/5/2022 22:40:24 ******/
ALTER TABLE [dbo].[Horario] ADD  CONSTRAINT [PK4] PRIMARY KEY NONCLUSTERED 
(
	[idhorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK6]    Script Date: 31/5/2022 22:40:24 ******/
ALTER TABLE [dbo].[LogIn] ADD  CONSTRAINT [PK6] PRIMARY KEY NONCLUSTERED 
(
	[idlogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK1]    Script Date: 31/5/2022 22:40:24 ******/
ALTER TABLE [dbo].[Puesto] ADD  CONSTRAINT [PK1] PRIMARY KEY NONCLUSTERED 
(
	[idpuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK5]    Script Date: 31/5/2022 22:40:24 ******/
ALTER TABLE [dbo].[RegistrodeEyR] ADD  CONSTRAINT [PK5] PRIMARY KEY NONCLUSTERED 
(
	[idregistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Departamento] ADD  DEFAULT ((1)) FOR [estadodep]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ((1)) FOR [estadoempleado]
GO
ALTER TABLE [dbo].[Puesto] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [RefHorario5] FOREIGN KEY([idhorario])
REFERENCES [dbo].[Horario] ([idhorario])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [RefHorario5]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [RefPuesto12] FOREIGN KEY([idpuesto])
REFERENCES [dbo].[Puesto] ([idpuesto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [RefPuesto12]
GO
ALTER TABLE [dbo].[Empleadologin]  WITH CHECK ADD  CONSTRAINT [RefEmpleado16] FOREIGN KEY([idrempleado])
REFERENCES [dbo].[Empleado] ([idrempleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleadologin] CHECK CONSTRAINT [RefEmpleado16]
GO
ALTER TABLE [dbo].[Empleadologin]  WITH CHECK ADD  CONSTRAINT [RefLogIn15] FOREIGN KEY([idlogin])
REFERENCES [dbo].[LogIn] ([idlogin])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleadologin] CHECK CONSTRAINT [RefLogIn15]
GO
ALTER TABLE [dbo].[Puesto]  WITH CHECK ADD  CONSTRAINT [RefDepartamento11] FOREIGN KEY([iddepartamento])
REFERENCES [dbo].[Departamento] ([iddepartamento])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Puesto] CHECK CONSTRAINT [RefDepartamento11]
GO
ALTER TABLE [dbo].[RegistrodeEyR]  WITH CHECK ADD  CONSTRAINT [RefEmpleado4] FOREIGN KEY([idrempleado])
REFERENCES [dbo].[Empleado] ([idrempleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RegistrodeEyR] CHECK CONSTRAINT [RefEmpleado4]
GO
