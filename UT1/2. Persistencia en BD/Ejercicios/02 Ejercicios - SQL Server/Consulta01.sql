USE Northwind
GO
SELECT CategoryID, ProductID, ProductName
FROM Products
WHERE CategoryID BETWEEN 2 AND 4
ORDER BY CategoryID, ProductID;
GO