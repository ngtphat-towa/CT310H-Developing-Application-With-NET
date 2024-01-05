CREATE TABLE [dbo].[ProductImports] (
    [ImportId]     INT           IDENTITY (1, 1) NOT NULL,
    [ProductId]    NVARCHAR (5)  NULL,
    [CustomerID]   INT           NULL,
    [ImportedDate] SMALLDATETIME DEFAULT (getdate()) NOT NULL,
    [TotalNumber]  INT           NOT NULL,
    [TotalImport]  FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ImportId] ASC),
    CHECK ([TotalImport]>(0)),
    CHECK ([TotalNumber]>(0)),
    CONSTRAINT [FK_ProductImports_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[DailyCustomer] ([Id]),
    CONSTRAINT [FK_ProductImports_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

