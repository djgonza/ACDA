USE pubs;
GO
CREATE PROCEDURE ejercicio01
@id varchar(6)
AS
    SET NOCOUNT ON;
    SELECT title, qty
    FROM titles
    INNER JOIN sales ON titles.title_id = sales.title_id
    WHERE titles.title_id Like @id;
GO