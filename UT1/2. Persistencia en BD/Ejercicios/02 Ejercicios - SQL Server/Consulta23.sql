USE Northwind
GO
SELECT OrderID, ProductID
FROM [Order Details]
WHERE Quantity > (
	SELECT MAX(Quantity)
	FROM [Order Details]
	INNER JOIN Products ON [Order Details].ProductID = Products.ProductID
	WHERE CategoryID = 2
	);
GO