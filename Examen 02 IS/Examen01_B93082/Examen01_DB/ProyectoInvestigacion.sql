CREATE TABLE [dbo].[ProyectoInvestigacion]
(
	[Nombre] varchar(50) NOT NULL,
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [InvestigadorPrincipal] INT NOT NULL,
    [Colaboradores] INT NULL,
    [FechaInicio] DATE NOT NULL,
    [FechaFinal] DATE NULL,
    CONSTRAINT [FK_dbo.ProyectoInvestigacion_db.Investigador_InvestigadorId]
    FOREIGN KEY ([InvestigadorPrincipal]) REFERENCES Investigador([Id])
)
