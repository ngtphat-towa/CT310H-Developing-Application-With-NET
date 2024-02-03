CREATE TABLE [dbo].[Sections] (
    [SectionId]          INT          IDENTITY (1, 1) NOT NULL,
    [CourseId]           VARCHAR (10) NOT NULL,
    [AcademicYearTermId] INT          NOT NULL,
    [ClassNumber]        VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([SectionId] ASC),
    FOREIGN KEY ([AcademicYearTermId]) REFERENCES [dbo].[AcademicYears] ([AcademicYearTermId]),
    FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId]),
    CONSTRAINT [UK_Course_AcademicYear_Unique] UNIQUE NONCLUSTERED ([CourseId] ASC, [AcademicYearTermId] ASC, [ClassNumber] ASC)
);

