CREATE TABLE [dbo].[Branch] (
    [BranchId]      INT           IDENTITY (1, 1) NOT NULL,
    [BranchName]    NVARCHAR (30) NULL,
    [BranchAddress] NVARCHAR (50) NULL,
    [PhoneNumber]   CHAR (11)     NOT NULL,
    PRIMARY KEY CLUSTERED ([BranchId] ASC),
    CONSTRAINT [CK_PhoneNumber] CHECK ([PhoneNumber] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);

