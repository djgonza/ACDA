USE Libreria
GO
SELECT Nombre, Apellidos, T�tulo
FROM autores
INNER JOIN libros  ON Autor = IDAutor
WHERE Nacionalidad = 'Germany'
FOR XML AUTO, ELEMENTS;
GO