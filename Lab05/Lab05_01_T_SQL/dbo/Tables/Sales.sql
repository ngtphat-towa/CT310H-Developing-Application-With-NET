CREATE TABLE [dbo].[Sales] (
    [SalesId]     INT           IDENTITY (1, 1) NOT NULL,
    [ProductId]   NVARCHAR (5)  NULL,
    [CustomerID]  INT           NULL,
    [SaleDate]    SMALLDATETIME NOT NULL,
    [TotalNumber] INT           NOT NULL,
    [TotalSale]   FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([SalesId] ASC),
    CHECK ([TotalNumber]>(0)),
    CHECK ([TotalSale]>(0)),
    CONSTRAINT [CK_SellDate] CHECK ([SaleDate]<=getdate()),
    CONSTRAINT [FK_Sales_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[DailyCustomer] ([Id]),
    CONSTRAINT [FK_Sales_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

