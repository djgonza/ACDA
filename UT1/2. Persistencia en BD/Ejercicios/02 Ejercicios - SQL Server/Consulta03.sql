USE Northwind
GO
SELECT CategoryID, ProductID, ProductName
FROM Products
WHERE ProductName LIKE 'CH%' 
ORDER BY CategoryID, ProductID;
GO