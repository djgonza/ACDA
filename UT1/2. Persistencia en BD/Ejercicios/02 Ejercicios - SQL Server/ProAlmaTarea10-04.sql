USE Libreria;
GO
CREATE PROCEDURE ejercicio04
AS
    SET NOCOUNT ON;
    SELECT Nombre, Dirección, Ciudad, Teléfono
    FROM librerías;
GO
