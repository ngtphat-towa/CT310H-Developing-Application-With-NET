CREATE TABLE [dbo].[Teaches] (
    [InstructorId] NVARCHAR (4) NOT NULL,
    [SectionId]    INT          NOT NULL,
    [IsPrimary]    BIT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([InstructorId] ASC, [SectionId] ASC),
    FOREIGN KEY ([InstructorId]) REFERENCES [dbo].[Instructor] ([InstructorId]),
    FOREIGN KEY ([SectionId]) REFERENCES [dbo].[Sections] ([SectionId])
);

