CREATE TABLE [dbo].[Ciudad]
(
[PaisId] NVARCHAR(3) NOT NULL,
[Id] NVARCHAR(3) NOT NULL,
[Nombre] NVARCHAR(100) NULL,
PRIMARY KEY ([PaisId], [Id]),
	CONSTRAINT [FK_dbo.Ciudad_dbo.Pais] FOREIGN KEY ([PaisId])
	REFERENCES [dbo].Pais ([Id])
)
