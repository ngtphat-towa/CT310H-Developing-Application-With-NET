CREATE TABLE [dbo].[Teachings] (
    [InstructorId] VARCHAR (10) NOT NULL,
    [CourseId]     VARCHAR (10) NOT NULL,
    [ClassId]      VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([InstructorId] ASC, [CourseId] ASC, [ClassId] ASC),
    FOREIGN KEY ([ClassId]) REFERENCES [dbo].[Classes] ([ClassId]),
    FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([CourseId]),
    FOREIGN KEY ([InstructorId]) REFERENCES [dbo].[Instructors] ([InstructorId])
);

