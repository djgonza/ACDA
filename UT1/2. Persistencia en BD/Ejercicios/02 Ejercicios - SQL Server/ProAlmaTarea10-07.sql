USE Libreria;
GO
CREATE PROCEDURE ejercicio07
@Pedido int
AS
    SET NOCOUNT ON;
    SELECT IDPedido, Count(Cantidad) as Total
    FROM detallespedidos
    WHERE IDPedido Like @Pedido
    GROUP BY IDPedido;
GO