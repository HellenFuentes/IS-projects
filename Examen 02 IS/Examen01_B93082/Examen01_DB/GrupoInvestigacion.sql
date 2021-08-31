CREATE TABLE [dbo].[GrupoInvestigacion]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Nombre] VARCHAR(50) NOT NULL,
    [Descripcion] VARCHAR(150) NULL,
    [FechaCreacion] DATE NOT NULL,
    [Coordinador] INT,
    CONSTRAINT [FK_dbo.GrupoInvestigacion_db.Coordinador_CoordinadorNombre]
    FOREIGN KEY ([Coordinador]) REFERENCES Coordinador([Id])
)