USE pubs
GO
SELECT type, AVG(price)
FROM titles
WHERE advance > 5000
GROUP BY type;
GO
