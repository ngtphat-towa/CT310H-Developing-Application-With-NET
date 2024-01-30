CREATE TABLE [dbo].[Guests] (
    [InvoiceID]     INT             NOT NULL,
    [GuestName]     VARCHAR (50)    NOT NULL,
    [IDNumber]      VARCHAR (20)    NOT NULL,
    [PaymentAmount] DECIMAL (10, 2) NOT NULL,
    [PaymentDate]   DATE            NOT NULL,
    [RoomID]        INT             NULL,
    PRIMARY KEY CLUSTERED ([InvoiceID] ASC),
    FOREIGN KEY ([RoomID]) REFERENCES [dbo].[Rooms] ([RoomID])
);

