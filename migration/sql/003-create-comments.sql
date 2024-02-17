--liquibase formatted sql
 
-- Explicitly set the schema search path
SET search_path TO public;
 
-- changeset indre:3  
-- comment: Create comments table
CREATE TABLE comments (
    id SERIAL PRIMARY KEY,
    movie_id INT NOT NULL REFERENCES movies(id),
    name VARCHAR,
    email VARCHAR,
    body VARCHAR
);

-- rollback DROP TABLE IF EXISTS comments;