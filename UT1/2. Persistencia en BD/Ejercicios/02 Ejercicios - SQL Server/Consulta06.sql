USE pubs
GO
SELECT au_fname, au_lname, pub_name
FROM authors
INNER JOIN publishers ON authors.city = publishers.city
WHERE (authors.city = publishers.city)
ORDER by au_fname;
GO