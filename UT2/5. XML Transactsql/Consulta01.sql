USE Libreria
GO
SELECT TOP 3 Nombre, Dirección, Ciudad, Teléfono
FROM librerías
FOR XML AUTO;
GO