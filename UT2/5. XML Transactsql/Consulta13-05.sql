USE Libreria
GO
SELECT Título, Nombre, Apellidos
FROM libros
INNER JOIN autores  ON Autor = IDAutor
WHERE Nacionalidad = 'Germany'
FOR XML AUTO, ELEMENTS;
GO