USE Libreria;
GO
CREATE PROCEDURE ejercicio05
@City nvarchar(50)
AS
    SET NOCOUNT ON;
    SELECT Nombre, Direcci�n, Tel�fono
    FROM librer�as
    WHERE Ciudad Like @City;
GO

