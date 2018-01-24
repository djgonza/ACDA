USE Libreria;
GO
CREATE PROCEDURE librosDatos
AS
    SET NOCOUNT ON;
    SELECT ISBN, Título, PRECIO, Autor
    FROM libros
    WHERE Autor Like 5;
GO