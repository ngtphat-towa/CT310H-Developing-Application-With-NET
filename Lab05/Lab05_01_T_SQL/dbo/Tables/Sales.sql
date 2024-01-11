CREATE TABLE [dbo].[Sales] (
    [SalesId]     INT           IDENTITY (1, 1) NOT NULL,
    [ProductId]   NVARCHAR (5)  NULL,
    [BranchId]    INT           NULL,
    [SaleDate]    SMALLDATETIME NOT NULL,
    [TotalNumber] INT           NOT NULL,
    [TotalSale]   FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([SalesId] ASC),
    CHECK ([TotalNumber]>(0)),
    CHECK ([TotalSale]>(0)),
    CONSTRAINT [CK_SellDate] CHECK ([SaleDate]<=getdate()),
    CONSTRAINT [FK_Branch_Sales] FOREIGN KEY ([BranchId]) REFERENCES [dbo].[Branch] ([BranchId]),
    CONSTRAINT [FK_Sales_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
);









