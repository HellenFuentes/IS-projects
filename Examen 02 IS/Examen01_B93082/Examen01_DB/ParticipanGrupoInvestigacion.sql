CREATE TABLE [dbo].[ParticipanGrupoInvestigacion]
(
	[InvestigadorId] INT NOT NULL ,
    [GrupoInvestigacionId] INT NOT NULL, 
    CONSTRAINT [PK_GrupoInvestigacion] PRIMARY KEY ([InvestigadorId],[GrupoInvestigacionId]),
    FOREIGN KEY ([InvestigadorId]) REFERENCES [dbo].[Investigador]([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([GrupoInvestigacionId]) REFERENCES [dbo].[GrupoInvestigacion]([Id]) ON DELETE CASCADE ON UPDATE CASCADE
)
