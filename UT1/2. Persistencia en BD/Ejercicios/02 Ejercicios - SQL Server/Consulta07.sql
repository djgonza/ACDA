USE pubs
GO
SELECT titles.title_id, title, sum(qty)
FROM titles
INNER JOIN sales ON titles.title_id = sales.title_id
WHERE titles.title_id = sales.title_id
GROUP BY titles.title_id, title;
GO