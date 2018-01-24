USE Libreria
GO
SELECT PED.IDPedido, PED.IdCliente, LIB.IDLibrería, LIB.Nombre, LIB.Dirección, LIB.Teléfono
FROM librerías LIB
INNER JOIN pedidos PED ON LIB.IDLibrería = PED.IDLibrería
WHERE LIB.Ciudad = 'Denver'
FOR XML PATH;
GO
