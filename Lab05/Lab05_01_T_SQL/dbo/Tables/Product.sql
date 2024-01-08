CREATE TABLE [dbo].[Product] (
    [Id]          NVARCHAR (5)    NOT NULL,
    [ProductName] NVARCHAR (50)   NULL,
    [Price]       DECIMAL (10, 2) NULL,
    [PriceUnit]   CHAR (12)       NOT NULL,
    [Supplier]    CHAR (30)       NOT NULL,
    [CategoryId]  CHAR (2)        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Price]>(0)),
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[ProductCategories] ([CategoryId]) ON DELETE CASCADE ON UPDATE CASCADE
);



