USE pubs;
GO
CREATE PROCEDURE ejercicio02
@tipo char(12)
AS
    SET NOCOUNT ON;
    SELECT title, au_fname
    FROM titles
    INNER JOIN titleauthor ON titles.title_id = titleauthor.title_id
    INNER JOIN authors on titleauthor.au_id = authors.AU_ID
    WHERE type Like @tipo;
GO