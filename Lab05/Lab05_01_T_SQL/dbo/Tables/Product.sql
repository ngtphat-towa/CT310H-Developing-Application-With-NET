CREATE TABLE [dbo].[Product] (
    [Id]          NVARCHAR (5)    NOT NULL,
    [ProductName] NVARCHAR (50)   NULL,
    [Price]       DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Price]>(0))
);

