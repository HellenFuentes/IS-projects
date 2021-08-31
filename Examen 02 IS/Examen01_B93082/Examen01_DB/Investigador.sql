CREATE TABLE [dbo].[Investigador]
(
	[Nombre] varchar(50) NOT NULL,
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [MaximoGrado] varchar(20) NULL
)
