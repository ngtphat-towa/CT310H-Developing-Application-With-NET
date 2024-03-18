CREATE TABLE [dbo].[Students] (
    [StudentId]   VARCHAR (10)   NOT NULL,
    [StudentName] NVARCHAR (100) NULL,
    [ClassId]     VARCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC),
    FOREIGN KEY ([ClassId]) REFERENCES [dbo].[Classes] ([ClassId])
);

