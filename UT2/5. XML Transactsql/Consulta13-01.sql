USE Libreria
GO
SELECT LIB.Título, AU.Nombre, AU.Apellidos
FROM libros LIB
INNER JOIN autores AU ON LIB.Autor = AU.IDAutor
WHERE AU.Nacionalidad = 'Germany'
FOR XML RAW;
GO
