CREATE TABLE [dbo].[Enrollments] (
    [StudentId] VARCHAR (10)   NOT NULL,
    [SectionId] INT            NOT NULL,
    [Grade]     DECIMAL (5, 2) NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC, [SectionId] ASC),
    FOREIGN KEY ([SectionId]) REFERENCES [dbo].[Sections] ([SectionId]),
    FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId])
);

