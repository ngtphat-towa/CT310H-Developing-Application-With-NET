

-- Add PhoneNumber column to DAILY table:
ALTER TABLE DAILY
ADD PhoneNumber CHAR(11) NOT NULL
CONSTRAINT CK_PhoneNumber CHECK (PhoneNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]');

-- Add PriceUnit and Supplier columns to Product table:
ALTER TABLE Product
ADD PriceUnit CHAR(12) NOT NULL,
    Supplier CHAR(30) NOT NULL;

-- Create ProductCategories table:
CREATE TABLE ProductCategories (
    CategoryId CHAR(2) PRIMARY KEY,
    CategoryName CHAR(50) NOT NULL
);

-- Add CategoryId column to Product table:
ALTER TABLE Product
ADD CategoryId CHAR(2);

-- Create foreign key with cascade update and delete:
ALTER TABLE Product
ADD CONSTRAINT FK_Product_Category FOREIGN KEY (CategoryId)
REFERENCES ProductCategories(CategoryId)
ON UPDATE CASCADE
ON DELETE CASCADE;
