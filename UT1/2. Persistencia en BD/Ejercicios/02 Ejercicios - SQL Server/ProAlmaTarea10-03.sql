USE pubs;
GO
CREATE PROCEDURE ejercicio03
@tipo char(12),
@media money OUTPUT,
@suma int OUTPUT
AS
    SET NOCOUNT ON;
    SELECT @media = AVG(advance), @suma = SUM(ytd_sales)
    FROM titles    
    WHERE type Like @tipo;
RETURN
GO


  
  