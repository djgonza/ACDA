USE Northwind
GO
SELECT CompanyName, City, Region, Country
FROM Customers
WHERE Region IS NOT NULL;
GO