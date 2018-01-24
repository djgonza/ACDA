USE Libreria;
GO
CREATE PROCEDURE pedidosClientesEmpiezanPorA 
    @Name nvarchar(50) = 'A%'
AS 
    SET NOCOUNT ON;
    SELECT Nombre, Apellidos, IDPedido
    FROM clientes
    INNER JOIN pedidos ON clientes.IDCliente = pedidos.IdCliente
    WHERE Nombre Like @Name;
GO