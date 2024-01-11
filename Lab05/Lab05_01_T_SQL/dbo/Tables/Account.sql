CREATE TABLE [dbo].[Account] (
    [AccountCode] INT          NOT NULL,
    [AccountName] VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([AccountCode] ASC),
    CONSTRAINT [CK_AccountCode_Modulo11] CHECK ([dbo].[modulo11_check]([AccountCode])=(1))
);

