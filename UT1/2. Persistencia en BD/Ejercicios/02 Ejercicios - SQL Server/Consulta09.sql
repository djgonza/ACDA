USE pubs
GO
SELECT au_fname, au_lname, zip
FROM authors
WHERE zip in (
SELECT zip
FROM authors
WHERE city = 'Oakland'
GROUP BY zip
Having COUNT(*)>1);
GO