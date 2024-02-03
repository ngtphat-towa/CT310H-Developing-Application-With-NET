CREATE TABLE [dbo].[Department] (
    [DepartmentId]   NVARCHAR (15) NOT NULL,
    [DepartmentName] NVARCHAR (50) NOT NULL,
    [Building]       VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([DepartmentId] ASC),
    CONSTRAINT [UK_DepartmentName] UNIQUE NONCLUSTERED ([DepartmentName] ASC)
);

