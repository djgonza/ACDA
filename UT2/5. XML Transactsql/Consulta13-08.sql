USE Libreria
GO
SELECT T�tulo
FROM libros 
INNER JOIN autores ON Autor = IDAutor
WHERE Nacionalidad = 'Germany'
FOR XML RAW('libros'), ROOT('Libros_Alemanes');
GO
