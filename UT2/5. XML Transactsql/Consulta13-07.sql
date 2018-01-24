USE Libreria
GO
SELECT libros.T�tulo
FROM libros 
INNER JOIN detallespedidos ON libros.ISBN = detallespedidos.ISBN
INNER JOIN pedidos ON detallespedidos.IDPedido = pedidos.IDPedido
GROUP BY libros.T�tulo
FOR XML RAW('libros');
GO
