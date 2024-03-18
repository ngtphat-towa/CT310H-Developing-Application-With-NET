CREATE TABLE [dbo].[Grades] (
    [StudentId] VARCHAR (10) NOT NULL,
    [CourseId]  VARCHAR (10) NOT NULL,
    [Score]     FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC, [CourseId] ASC, [Score] ASC),
    FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([CourseId]),
    FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([StudentId])
);

