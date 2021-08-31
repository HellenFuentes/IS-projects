CREATE PROCEDURE [dbo].[Departamento_Delete]
	@DepartamentoId INT
AS
BEGIN
	DELETE FROM Departamento
	WHERE DepartamentoId = @DepartamentoId
END
