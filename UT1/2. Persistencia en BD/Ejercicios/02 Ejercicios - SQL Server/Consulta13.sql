USE pubs
GO
SELECT au_lname, au_fname
FROM authors
INNER JOIN publishers ON authors.city = publishers.city
WHERE authors.city = publishers.city;
GO