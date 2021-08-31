/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DELETE FROM Coordinador; 
DELETE FROM Investigador; 
DELETE FROM GrupoInvestigacion;
DELETE FROM Coordinador; 
DELETE FROM Autores;
DELETE FROM AutoresDePub;
DELETE FROM ProyectoInvestigacion
DBCC CHECKIDENT ('Coordinador', RESEED, 0); 
DBCC CHECKIDENT ('Investigador', RESEED, 0); 
DBCC CHECKIDENT ('ProyectoInvestigacion', RESEED, 0);

MERGE INTO Coordinador AS TARGET
USING (VALUES
('Hellen',1,'20150219', '20190219'),
('Jean',2,'20090519', '20200219'),
('Maria',3,'20100719', '20180727')
)
AS Source (Nombre,[id], FechaInicioNombramiento,FechaFinalNombramiento)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN
INSERT (Nombre,FechaInicioNombramiento,FechaFinalNombramiento)
VALUES (Nombre,FechaInicioNombramiento,FechaFinalNombramiento);

MERGE INTO Investigador AS TARGET
USING (VALUES
('Alejandro',1,'Licenciatura'),
('Andres',2,'Maestria'),
('Erick',3,'Doctorado')
)
AS Source (Nombre,[id], MaximoGrado)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN
INSERT (Nombre,MaximoGrado)
VALUES (Nombre,MaximoGrado);


MERGE INTO GrupoInvestigacion AS TARGET
USING (VALUES
(1,'Grupo01', 'Estudian Arañas', '20160707', 1),
(2,'Grupo02', 'Estudian Gusanos', '20140808', 2),
(3,'Grupo03', 'Estudian Monos', '20170101',3)
)
AS Source (Id,Nombre,Descripcion,FechaCreacion,Coordinador)
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN
INSERT (Nombre,Descripcion,FechaCreacion,Coordinador)
VALUES (Nombre,Descripcion,FechaCreacion,Coordinador);