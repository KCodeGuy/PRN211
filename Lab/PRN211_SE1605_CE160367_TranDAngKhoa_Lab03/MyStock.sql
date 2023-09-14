CREATE DATABASE MyStock
GO
USE MyStock
GO
CREATE TABLE Cars (
	CarID int primary key,
	CarName varchar(50),
	Manufacturer varchar(50),
	Price money,
	ReleasedYear int
)

INSERT INTO Cars VALUES (1, 'Accord', 'Honda', 24970, 2021)
INSERT INTO Cars VALUES (2, 'Accord', 'Honda', 24970, 2021)
INSERT INTO Cars VALUES (3, 'Accord', 'Honda', 24970, 2021)
INSERT INTO Cars VALUES (4, 'Accord', 'Honda', 24970, 2021)
INSERT INTO Cars VALUES (5, 'Accord', 'Honda', 24970, 2021)

SELECT * FROM Cars