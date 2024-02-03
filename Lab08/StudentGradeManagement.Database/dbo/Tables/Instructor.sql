CREATE TABLE [dbo].[Instructor] (
    [InstructorId]   NVARCHAR (4)  NOT NULL,
    [InstructorName] NVARCHAR (50) NOT NULL,
    [DepartmentId]   NVARCHAR (15) NOT NULL,
    [Password]       NVARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([InstructorId] ASC),
    CONSTRAINT [FK_Instructor_BelongTo_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([DepartmentId])
);

