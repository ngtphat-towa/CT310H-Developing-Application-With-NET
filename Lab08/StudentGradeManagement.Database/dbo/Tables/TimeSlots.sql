CREATE TABLE [dbo].[TimeSlots] (
    [TimeSlotId] INT         IDENTITY (1, 1) NOT NULL,
    [StartTime]  TIME (7)    NOT NULL,
    [EndTime]    TIME (7)    NOT NULL,
    [DaysOfWeek] VARCHAR (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([TimeSlotId] ASC)
);

