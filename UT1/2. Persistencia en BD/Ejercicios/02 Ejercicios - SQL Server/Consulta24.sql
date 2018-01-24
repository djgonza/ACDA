USE pubs
GO
SELECT type
FROM (
		SELECT type, publishers.pub_id
		FROM titles
		INNER JOIN publishers ON titles.pub_id = publishers.pub_id
		GROUP BY type, publishers.pub_id
	) as TablaNueva
GROUP BY type
HAVING COUNT(type) > 1;
GO
