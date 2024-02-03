CREATE TABLE [dbo].[Class] (
    [ClassId]      VARCHAR (15)  NOT NULL,
    [ClassName]    NVARCHAR (50) NOT NULL,
    [DepartmentId] NVARCHAR (15) NOT NULL,
    [YearCode]     VARCHAR (5)   NOT NULL,
    PRIMARY KEY CLUSTERED ([ClassId] ASC),
    CONSTRAINT [FK_Class_BelongTo_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([DepartmentId]),
    CONSTRAINT [UNIQUE_Department_YearCode_Class] UNIQUE NONCLUSTERED ([ClassId] ASC, [DepartmentId] ASC, [YearCode] ASC)
);

