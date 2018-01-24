USE pubs
GO
SELECT pub_name
FROM publishers
INNER JOIN titles ON publishers.pub_id = titles.pub_id
WHERE type = 'psychology'
GROUP BY pub_name;
GO