USE Libreria;
GO
CREATE PROCEDURE ejercicio05
@City nvarchar(50)
AS
    SET NOCOUNT ON;
    SELECT Nombre, Dirección, Teléfono
    FROM librerías
    WHERE Ciudad Like @City;
GO

