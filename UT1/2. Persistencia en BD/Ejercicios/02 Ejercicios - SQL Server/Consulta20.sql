USE pubs
GO
SELECT title
FROM titles
WHERE price > (
	SELECT MIN(price)
	FROM titles)
ORDER BY title;
GO
