USE Libreria;
GO
CREATE PROCEDURE librosDatos
AS
    SET NOCOUNT ON;
    SELECT ISBN, T�tulo, PRECIO, Autor
    FROM libros
    WHERE Autor Like 5;
GO