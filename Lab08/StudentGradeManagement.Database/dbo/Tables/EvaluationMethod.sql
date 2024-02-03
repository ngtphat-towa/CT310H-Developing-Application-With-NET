CREATE TABLE [dbo].[EvaluationMethod] (
    [EvaluationMethodId]   INT            IDENTITY (1, 1) NOT NULL,
    [EvaluationMethodName] VARCHAR (50)   NOT NULL,
    [Weight]               DECIMAL (5, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([EvaluationMethodId] ASC),
    CHECK ([Weight]>=(0) AND [Weight]<=(100))
);

