--liquibase formatted sql
 
-- Explicitly set the schema search path
SET search_path TO public;
 
-- changeset indre:1  
-- comment: Create movies table
CREATE TABLE movies (
    id SERIAL PRIMARY KEY,
    name VARCHAR NOT NULL,
    average_rate NUMERIC
);

CREATE INDEX idx_average_rate ON movies (average_rate);
 
-- rollback DROP TABLE IF EXISTS movies;