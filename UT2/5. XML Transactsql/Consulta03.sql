USE Libreria
GO
SELECT TOP 3 Nombre, Direcci�n, Ciudad, Tel�fono
USE Libreria
GO
SELECT TOP 3 Nombre, Direcci�n, Ciudad, Tel�fono
FROM librer�as
FOR XML PATH('MisLibrerias'), ELEMENTS;
GO
