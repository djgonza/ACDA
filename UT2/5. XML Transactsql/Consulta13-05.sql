USE Libreria
GO
SELECT T�tulo, Nombre, Apellidos
FROM libros
INNER JOIN autores  ON Autor = IDAutor
WHERE Nacionalidad = 'Germany'
FOR XML AUTO, ELEMENTS;
GO