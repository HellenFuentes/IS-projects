CREATE PROCEDURE [dbo].[Departamento_Edit]
	@DepartamentoId INT,
	@Nombre NVARCHAR (50),
	@Presupuesto FLOAT = 0.0
AS
BEGIN
	UPDATE Departamento
	SET Nombre = @Nombre, Presupuesto = @Presupuesto
	WHERE DepartamentoId = @DepartamentoId
END
