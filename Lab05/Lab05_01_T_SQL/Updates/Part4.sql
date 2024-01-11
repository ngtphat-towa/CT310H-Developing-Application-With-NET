--1. Create the table:
CREATE TABLE product (
    prod_nr int NOT NULL PRIMARY KEY,
    name varchar(30) NOT NULL,
    price money NOT NULL,
    type varchar(30) NOT NULL
);

--2. Insert data into the table:
INSERT INTO product VALUES (4, 'ColorTv', 700, 'electronic');
INSERT INTO product VALUES (5, 'Fan', 350, 'electronic');
INSERT INTO product VALUES (6, 'Heater', 200, 'electronic');
INSERT INTO product VALUES (7, 'Webcam', 60, 'Computer');

--3. Query the product table:
SELECT * FROM product;

--4. Calculate the average value and store it in a variable:
DECLARE @average_price money;

SELECT @average_price = AVG(price) FROM product;

SELECT @average_price AS AveragePrice;

--5. Calculate the average value and check if it's >= 500:
DECLARE @average_price money;

WHILE (1 = 1)
BEGIN
    SELECT @average_price = AVG(price) FROM product;

    IF @average_price >= 500
    BEGIN
        SELECT * FROM product;
        BREAK;
    END
    ELSE
    BEGIN
        UPDATE product SET price = price * 1.05;
    END
END

SELECT @average_price AS AveragePrice;
SELECT * FROM product;
