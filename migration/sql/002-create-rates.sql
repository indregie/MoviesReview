--liquibase formatted sql
 
-- Explicitly set the schema search path
SET search_path TO public;
 
-- changeset indre:2  
-- comment: Create rates table
CREATE TABLE rates (
    id SERIAL PRIMARY KEY,
    movie_id INT NOT NULL REFERENCES movies(id),
    rate NUMERIC NOT NULL
);

-- rollback DROP TABLE IF EXISTS rates;