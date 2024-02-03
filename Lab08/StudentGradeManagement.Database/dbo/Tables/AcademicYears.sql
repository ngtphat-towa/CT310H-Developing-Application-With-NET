CREATE TABLE [dbo].[AcademicYears] (
    [AcademicYearTermId] INT            IDENTITY (1, 1) NOT NULL,
    [Year]               INT            NOT NULL,
    [Semester]           VARCHAR (10)   NOT NULL,
    [StartDate]          DATE           NOT NULL,
    [EndDate]            DATE           NULL,
    [IsActive]           BIT            DEFAULT ((0)) NULL,
    [Description]        NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([AcademicYearTermId] ASC),
    CONSTRAINT [CHK_StartDate_Before_EndDate] CHECK ([StartDate]<[EndDate]),
    CONSTRAINT [UC_Year_Semester] UNIQUE NONCLUSTERED ([Year] ASC, [Semester] ASC)
);

