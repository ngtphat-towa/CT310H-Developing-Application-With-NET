CREATE TABLE [dbo].[Grades] (
    [GradeId]            INT            IDENTITY (1, 1) NOT NULL,
    [StudentId]          VARCHAR (10)   NULL,
    [SectionId]          INT            NULL,
    [EvaluationMethodId] INT            NULL,
    [Grade]              DECIMAL (5, 2) NULL,
    PRIMARY KEY CLUSTERED ([GradeId] ASC),
    CONSTRAINT [CHK_Grade] CHECK ([Grade]>=(0) AND [Grade]<=(10)),
    FOREIGN KEY ([EvaluationMethodId]) REFERENCES [dbo].[EvaluationMethod] ([EvaluationMethodId]),
    FOREIGN KEY ([SectionId]) REFERENCES [dbo].[Sections] ([SectionId]),
    FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]),
    CONSTRAINT [FK_Grade_Enrollment] UNIQUE NONCLUSTERED ([StudentId] ASC, [SectionId] ASC, [EvaluationMethodId] ASC)
);

