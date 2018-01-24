USE pubs
GO
SELECT title
FROM titles
WHERE price > (
	SELECT MIN(price)
	FROM titles
	WHERE type = 'psychology')
ORDER BY title;
GO