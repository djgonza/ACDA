USE pubs
GO
SELECT publishers.pub_id, SUM(ytd_sales) as total
FROM publishers
INNER JOIN titles ON publishers.pub_id = titles.pub_id
GROUP BY publishers.pub_id
HAVING COUNT(title) >= 6;
GO
