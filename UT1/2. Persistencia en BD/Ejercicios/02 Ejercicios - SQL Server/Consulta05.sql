USE Northwind
GO
SELECT ProductID, ProductName
FROM Products
WHERE (UnitsInStock < ReorderLevel) or (SupplierID = 15 AND CategoryID = 4);
GO