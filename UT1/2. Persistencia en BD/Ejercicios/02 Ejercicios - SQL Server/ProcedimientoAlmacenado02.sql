USE Libreria;
GO
CREATE PROCEDURE AutoresYObraDeUSA
    @Nation varchar(50) = "USA"
AS 
    SET NOCOUNT ON;
    SELECT Nombre, Apellidos, T�tulo
    FROM autores
    INNER JOIN libros ON autores.IDAutor = libros.Autor
    WHERE Nacionalidad = @Nation;
GO