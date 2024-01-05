CREATE TABLE [dbo].[DailyCustomer] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [CustomerName]    NVARCHAR (30) NULL,
    [CustomerAddress] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

