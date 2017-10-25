USE Northwind
GO
SELECT CategoryID, ProductID, ProductName
FROM Products
WHERE CategoryID IN (1,4,5,7)
ORDER BY CategoryID, ProductID;
GO