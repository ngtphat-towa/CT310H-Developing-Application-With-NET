CREATE TABLE [dbo].[ProductImports] (
    [ImportId]     INT           IDENTITY (1, 1) NOT NULL,
    [ProductId]    NVARCHAR (5)  NULL,
    [BranchId]     INT           NULL,
    [ImportedDate] SMALLDATETIME DEFAULT (getdate()) NOT NULL,
    [TotalNumber]  INT           NOT NULL,
    [TotalImport]  FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ImportId] ASC),
    CHECK ([TotalImport]>(0)),
    CHECK ([TotalNumber]>(0)),
    CONSTRAINT [FK_Branch_ProductImports] FOREIGN KEY ([BranchId]) REFERENCES [dbo].[Branch] ([BranchId]),
    CONSTRAINT [FK_ProductImports_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
);









