USE Libreria
GO
SELECT PED.IDPedido, PED.IdCliente, LIB.IDLibrer�a, LIB.Nombre, LIB.Direcci�n, LIB.Tel�fono
FROM librer�as LIB
INNER JOIN pedidos PED ON LIB.IDLibrer�a = PED.IDLibrer�a
WHERE LIB.Ciudad = 'Denver'
FOR XML PATH;
GO
