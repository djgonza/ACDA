USE Libreria
GO
SELECT libros.Título
FROM libros 
INNER JOIN detallespedidos ON libros.ISBN = detallespedidos.ISBN
INNER JOIN pedidos ON detallespedidos.IDPedido = pedidos.IDPedido
GROUP BY libros.Título
FOR XML RAW('libros');
GO
