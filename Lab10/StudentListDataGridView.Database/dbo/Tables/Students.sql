CREATE TABLE [dbo].[Students] (
    [StudentId]   NVARCHAR (100) NOT NULL,
    [StudentName] NVARCHAR (100) NULL,
    [Gender]      INT            NULL,
    [ClassName]   NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);

