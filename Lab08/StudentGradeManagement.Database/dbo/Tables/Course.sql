CREATE TABLE [dbo].[Course] (
    [CourseId]     VARCHAR (10)  NOT NULL,
    [CourseName]   NVARCHAR (50) NOT NULL,
    [DepartmentId] NVARCHAR (15) NOT NULL,
    [CreditNumber] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CourseId] ASC),
    CONSTRAINT [FK_Course_BelongTo_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([DepartmentId])
);

