USE Libreria
GO
SELECT Título
FROM libros 
INNER JOIN autores ON Autor = IDAutor
WHERE Nacionalidad = 'Germany'
FOR XML RAW('libros'), ROOT('Libros_Alemanes');
GO
