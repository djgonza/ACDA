USE pubs
GO
SELECT title
FROM titles
WHERE advance > (
	SELECT MIN(advance)
	FROM titles
	INNER JOIN publishers ON titles.pub_id = publishers.pub_id
	WHERE pub_name = 'New Moon Books')
ORDER BY title;
GO