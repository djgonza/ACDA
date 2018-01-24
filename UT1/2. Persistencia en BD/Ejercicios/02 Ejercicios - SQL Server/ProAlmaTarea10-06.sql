USE Libreria;
GO
CREATE PROCEDURE ejercicio06
@Pais nvarchar(50) = 'Germany'
AS
    SET NOCOUNT ON;
    SELECT Nombre
    FROM autores
    WHERE Nacionalidad Like @Pais;
GO