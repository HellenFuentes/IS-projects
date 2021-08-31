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
DELETE FROM Curso; 
DBCC CHECKIDENT ('Curso', RESEED, 0); 

DELETE FROM Estudiante; 
DBCC CHECKIDENT ('Estudiante', RESEED, 0); 

DELETE FROM Matricula; 
DBCC CHECKIDENT ('Matricula', RESEED, 0);

MERGE INTO Curso AS Target 
USING (VALUES 
(1, 'Ingenieria de Software', 5), 
(2, 'Bases de Datos', 5), 
(3, 'Proyecto', 3) 
) 
AS Source ([CursoID], Titulo, Creditos) 
ON Target.CursoID = Source.CursoID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Titulo, Creditos) 
VALUES (Titulo, Creditos); 

MERGE INTO Pais AS Target 
USING (VALUES 
('CRC', 'Costa Rica'), 
('EUA', 'Estados Unidos de America'), 
('MEX', 'Mexico'),
('BRA', 'Brazil') 
) 
AS Source (Id, Nombre) 
ON Target.Id = Source.Id 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Id, Nombre) 
VALUES (Id, Nombre); 

MERGE INTO Ciudad AS Target 
USING (VALUES 
('CRC', 'SJO', 'San Jose'), 
('CRC', 'CGO', 'Cartaguito'), 
('CRC', 'GUA', 'Guanacaste'), 
('EUA', 'FLR', 'Floridad'), 
('EUA', 'CAL', 'California'), 
('EUA', 'NYC', 'New York'), 
('MEX', 'MEX', 'Mexico'), 
('MEX', 'GUA', 'Guadalajara'), 
('BRA', 'RIO', 'Rio de Janeiro'), 
('BRA', 'SPB', 'San Pablo') 
) 
AS Source (PaisId, Id, Nombre) 
ON Target.PaisId = Source.PaisId and Target.Id = Source.Id 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (PaisId, Id, Nombre) 
VALUES (PaisId, Id, Nombre);

MERGE INTO Estudiante AS Target 
USING (VALUES 
(1, 'Salas', 'Andrea', '2015-09-01', 'Andrea.Salas@ecci.ucr.ac.cr', 'CRC', 'GUA'), 
(2, 'Guzman', 'Luis', '2016-01-13', 'Luis.Guzman@ecci.ucr.ac.cr', 'EUA', 'NYC'), 
(3, 'Ramirez', 'Erick', '2017-09-03', 'Erick.Ramirez@ecci.ucr.ac.cr', 'BRA', 'RIO') 
) 
AS Source (EstudianteID, Apellido, Nombre, FechaMatricula, CorreoElectronico, PaisId, CiudadId) 
ON Target.EstudianteID = Source.EstudianteID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Apellido, Nombre, FechaMatricula, CorreoElectronico, PaisId, CiudadId) 
VALUES (Apellido, Nombre, FechaMatricula, CorreoElectronico, PaisId, CiudadId);

MERGE INTO Matricula AS Target 
USING (VALUES 
(1, 2.00, 1, 1), 
(2, 3.50, 1, 2), 
(3, 4.00, 2, 3),
(4, 1.80, 2, 1), 
(5, 3.20, 3, 1), 
(6, 4.00, 3, 2) 
)
AS Source (MatriculaID, Nota, CursoID, EstudianteID) 
ON Target.MatriculaID = Source.MatriculaID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Nota, CursoID, EstudianteID) 
VALUES (Nota, CursoID, EstudianteID);