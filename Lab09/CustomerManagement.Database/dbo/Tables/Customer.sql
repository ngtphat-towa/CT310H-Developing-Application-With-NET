CREATE TABLE [dbo].[Customer] (
    [Username]     NVARCHAR (20)  NOT NULL,
    [HashPassword] VARCHAR (50)   NOT NULL,
    [FullName]     NVARCHAR (100) NOT NULL,
    [DateOfBirth]  NVARCHAR (100) NULL,
    [Gender]       VARCHAR (5)    NULL,
    [Email]        NVARCHAR (50)  NULL,
    [Income]       MONEY          NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC),
    CONSTRAINT [CHK_Email] CHECK ([dbo].[checkEmail]([Email])=(1)),
    CONSTRAINT [CHK_Income] CHECK ([Income]>(1000000) AND [Income]<(50000000))
);

