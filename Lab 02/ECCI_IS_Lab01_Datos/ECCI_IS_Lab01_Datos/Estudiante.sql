CREATE TABLE [dbo].[Estudiante]
(
    [EstudianteID] INT IDENTITY (1,1) NOT NULL,
    [Apellido] NVARCHAR(50) NULL,
    [Nombre] NVARCHAR(50) NULL,
    [FechaMatricula] DATETIME NULL,
    [CorreoElectronico] NVARCHAR (120) NULL,
    [PaisId] NVARCHAR(3) NULL,
    [CiudadId] NVARCHAR(3) NULL,
PRIMARY KEY CLUSTERED ([EstudianteID] ASC),
    CONSTRAINT [FK_dbo.Estudiante_dbo.Pais] FOREIGN KEY ([PaisId])
    REFERENCES [dbo].Pais ([Id]),
    CONSTRAINT [FK_dbo.Estudiante_dbo.Ciudad] FOREIGN KEY ([PaisId], [CiudadId])
    REFERENCES [dbo].Ciudad ([PaisId], [Id])
)