CREATE DATABASE store;

USE store;

CREATE TABLE products(id INT PRIMARY KEY AUTO_INCREMENT, name VARCHAR(40), price DOUBLE);

INSERT INTO products VALUES(default, 'iPhone 17', 120000.00);
INSERT INTO products VALUES(default, 'iPad 10', 46000.00);
INSERT INTO products VALUES(default, 'Mac Book Pro', 190000.00);
INSERT INTO products VALUES(default, 'Lenovo LOQ', 104000.00);

