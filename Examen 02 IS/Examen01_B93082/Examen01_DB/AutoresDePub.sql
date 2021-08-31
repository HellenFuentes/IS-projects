CREATE TABLE [dbo].[AutoresDePub]
(
	[Orden] INT NOT NULL,
    [IdAutor] INT NOT NULL,
    [DoiPub] INT NOT NULL,
    PRIMARY KEY (IdAutor,[DoiPub]),
    CONSTRAINT [FK_dbo.[AutoresDePub_db.Autor_AutorId]
    FOREIGN KEY ([IdAutor]) REFERENCES Autores([Id]),
    CONSTRAINT [FK_dbo.[AutorPublicacion_db.Publicacion_PublicacionId]
    FOREIGN KEY ([DoiPub]) REFERENCES Publicaciones([Doi])
)
