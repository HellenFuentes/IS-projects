CREATE TABLE [dbo].[Coordinador]
(
	[Nombre] varchar(50) NOT NULL,
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [FechaInicioNombramiento] DATE NOT NULL,
    [FechaFinalNombramiento] DATE NULL
)
