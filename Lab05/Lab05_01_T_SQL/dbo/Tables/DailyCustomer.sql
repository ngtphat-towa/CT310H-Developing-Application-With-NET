CREATE TABLE [dbo].[DailyCustomer] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [CustomerName]    NVARCHAR (30) NULL,
    [CustomerAddress] NVARCHAR (50) NULL,
    [PhoneNumber]     CHAR (11)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_PhoneNumber] CHECK ([PhoneNumber] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);



