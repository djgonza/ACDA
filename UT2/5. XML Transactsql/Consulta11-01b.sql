USE Libreria
GO
SELECT LIB.Título, LIB.PRECIO, AU.Nombre, AU.Apellidos
FROM libros LIB
INNER JOIN autores AU ON LIB.Autor = AU.IDAutor
WHERE AU.Nacionalidad = 'UK'
FOR XML RAW;
GO