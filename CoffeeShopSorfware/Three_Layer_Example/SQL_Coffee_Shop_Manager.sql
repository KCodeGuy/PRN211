CREATE DATABASE COFFEE_SHOPE_MANAGMENT;

CREATE TABLE Account (
	userName NVARCHAR(100) PRIMARY KEY NOT NULL,
	password NVARCHAR(30) NOT NULL,
	account_Type INT NOT NULL DEFAULT 0 -- 1: STAFF, 0: ADMIN
)

CREATE TABLE Table_Food (
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	status NVARCHAR(20)
)

CREATE TABLE Food_Catelory (
    id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)
)

CREATE TABLE Food ( 
   id INT IDENTITY PRIMARY KEY,
   name NVARCHAR(100) NOT NULL,
   pirce FLOAT NOT NULL DEFAULT 0,
   sale_percent INT DEFAULT 0,
   catelory_id INT NOT NULL,
   FOREIGN KEY(catelory_id)	REFERENCES Food_Catelory(id)
)


CREATE TABLE Orders (
	id INT IDENTITY PRIMARY KEY,
	date_check_in DATE NOT NULL DEFAULT GETDATE(),
	date_check_out DATE NOT NULL,
	table_id INT NOT NULL,
	order_status INT NOT NULL DEFAULT 0,
	FOREIGN KEY(table_id) REFERENCES Table_Food(id)
)

CREATE TABLE Order_Detail (
	id INT IDENTITY PRIMARY KEY,
	order_id INT NOT NULL,
	food_id INT NOT NULL,
	quantity INT NOT NULL DEFAULT 0,
	FOREIGN KEY(order_id) REFERENCES Orders(id),
	FOREIGN KEY(food_id) REFERENCES Food(id)
)

------------------------ Insert values ------------
select * from Account;
select * from Food_Catelory;
INSERT INTO Account VALUES('Khoatd', 'dangkhoa123', 0);
INSERT INTO Account VALUES('nghiahh', 'dangkhoa123', 1);

INSERT INTO Food_Catelory VALUES('Food');
INSERT INTO Food_Catelory VALUES('SUB-FOOD');
INSERT INTO Food_Catelory VALUES('CAKE');
INSERT INTO Food_Catelory VALUES('DRINK');
INSERT INTO Food_Catelory VALUES('COMBO');

INSERT INTO Table_Food VALUES('Table 1', 'SOLD');
INSERT INTO Table_Food VALUES('Table 2', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 3', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 4', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 5', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 6', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 7', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 8', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 9', 'AVAILABLE');
INSERT INTO Table_Food VALUES('Table 10', 'AVAILABLE');

-------------------------------------------------------
select * from Account where userName = 'Khoatd' and password = 'dangkhoa123';
select * from Food_Catelory;
select * from Table_Food;


