CREATE TABLE [dbo].[DVDLibrary] (
    [DVDCodeNo] INT            NOT NULL,
    [DVDTitle]  NVARCHAR (100) NOT NULL,
    [Language]  NVARCHAR (20)  NOT NULL,
    [SubTitle]  BIT            NOT NULL,
    [Price]     MONEY          NOT NULL,
    PRIMARY KEY CLUSTERED ([DVDCodeNo] ASC)
);

