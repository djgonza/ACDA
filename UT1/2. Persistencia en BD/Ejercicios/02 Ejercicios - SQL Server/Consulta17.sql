USE pubs
GO
SELECT city
FROM authors
WHERE city not in (
	SELECT publishers.city
	FROM publishers
	INNER JOIN authors ON publishers.city = authors.city
)
GROUP BY city;
GO
