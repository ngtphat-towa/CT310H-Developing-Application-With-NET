CREATE TABLE [dbo].[Instructors] (
    [InstructorId]   VARCHAR (10)   NOT NULL,
    [InstructorName] NVARCHAR (100) NOT NULL,
    [Password]       VARCHAR (50)   NOT NULL,
    PRIMARY KEY CLUSTERED ([InstructorId] ASC)
);

