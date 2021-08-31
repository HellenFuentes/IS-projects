CREATE PROCEDURE [dbo].[ProcObtenerPromedioCurso]
@cursoId INT,
@resultado FLOAT OUTPUT
AS BEGIN
SELECT @resultado = AVG(Nota)
FROM Matricula
WHERE CursoID = @cursoId
END

