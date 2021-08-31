CREATE TABLE [dbo].[Publicaciones]
(
	[Doi] INT NOT NULL PRIMARY KEY,
    [Ref] INT NULL,
    [Resumen] varchar(200) NULL,
    [Tipo] varchar(50) NOT NULL,
    [Nombre] varchar(50) NOT NULL,
    CONSTRAINT [FK_dbo.Publicaciones_db.Publicaciones_PublicacionId]
    FOREIGN KEY ([Ref]) REFERENCES Publicaciones([Doi])
)
