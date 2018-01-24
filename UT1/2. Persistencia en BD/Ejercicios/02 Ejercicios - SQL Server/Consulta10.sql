USE pubs
GO
SELECT au_lname, au_fname, titles.title
FROM authors
INNER JOIN titleauthor ON authors.au_id = titleauthor.au_id
INNER JOIN titles ON titleauthor.title_id = titles.title_id
WHERE type = 'trad_cook'
ORDER BY titles.title;
GO
