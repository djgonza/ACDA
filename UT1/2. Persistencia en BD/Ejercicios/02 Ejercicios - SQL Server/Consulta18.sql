USE pubs
GO
SELECT publishers.pub_id, SUM(ytd_sales) as total
FROM publishers
INNER JOIN titles ON publishers.pub_id = titles.pub_id
WHERE ytd_sales > 4000
GROUP BY publishers.pub_id;
GO
