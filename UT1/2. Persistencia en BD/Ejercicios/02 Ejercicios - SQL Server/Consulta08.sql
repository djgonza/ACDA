USE pubs
GO
SELECT pub_id, pub_name, publishers.state, authors.*
FROM publishers
INNER JOIN authors ON publishers.state = authors.state
WHERE publishers.state = authors.state and publishers.city = authors.city;
GO