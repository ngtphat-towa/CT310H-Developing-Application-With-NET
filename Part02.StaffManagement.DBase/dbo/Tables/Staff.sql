CREATE TABLE [dbo].[Staff] (
    [StaffCode]    INT           NOT NULL,
    [StaffName]    NVARCHAR (50) NOT NULL,
    [PositionCode] INT           NULL,
    [LectureHours] INT           NOT NULL,
    [UnitPrice]    MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([StaffCode] ASC),
    FOREIGN KEY ([PositionCode]) REFERENCES [dbo].[Position] ([PositionCode])
);

