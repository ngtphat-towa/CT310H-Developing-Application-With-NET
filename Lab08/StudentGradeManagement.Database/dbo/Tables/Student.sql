CREATE TABLE [dbo].[Student] (
    [StudentId]   VARCHAR (10)  NOT NULL,
    [StudentName] NVARCHAR (50) NOT NULL,
    [ClassId]     VARCHAR (15)  NOT NULL,
    [TotalCred]   INT           DEFAULT ((150)) NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC),
    CONSTRAINT [FK_Student_BelongTo_Class] FOREIGN KEY ([ClassId]) REFERENCES [dbo].[Class] ([ClassId])
);

