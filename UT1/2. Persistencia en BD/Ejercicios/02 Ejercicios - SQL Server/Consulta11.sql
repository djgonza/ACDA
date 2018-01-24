USE pubs
GO
SELECT AVG(advance), SUM(ytd_sales)
FROM titles
WHERE type = 'business'
GO