CREATE FUNCTION dbo.modulo11_check(@AccountCode INT)
RETURNS BIT
AS
BEGIN
    DECLARE @Sum INT = 0, @Digit INT, @Multiplier INT = 9;

    WHILE @AccountCode > 0
    BEGIN
        SET @Digit = @AccountCode % 10;
        SET @Sum = @Sum + @Digit * @Multiplier;
        SET @AccountCode = @AccountCode / 10;
        SET @Multiplier = @Multiplier - 1;
    END

    IF (@Sum % 11 = 0)
        RETURN 1;
  
    RETURN 0; 
END;
GO;

CREATE TABLE Account (
    AccountCode INT PRIMARY KEY,
    AccountName VARCHAR(30)
);

ALTER TABLE Account
ADD CONSTRAINT CK_AccountCode_Modulo11
CHECK (dbo.modulo11_check(AccountCode) = 1);