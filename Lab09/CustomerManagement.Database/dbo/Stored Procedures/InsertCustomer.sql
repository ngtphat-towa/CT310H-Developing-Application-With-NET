CREATE PROCEDURE dbo.InsertCustomer
    @Username NVARCHAR(20),
    @HashPassword VARCHAR(50),
    @FullName NVARCHAR(100),
    @DataOfBirth NVARCHAR(100),
    @Gender VARCHAR(5),
    @Email NVARCHAR(50),
    @Income MONEY
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the email is valid before inserting
    IF dbo.checkEmail(@Email) = 0
    BEGIN
        PRINT 'Invalid email address';
        RETURN; 
    END

    IF dbo.isLegitDate(@DataOfBirth) = 0
    BEGIN
        PRINT 'Invalid birthday';
        RETURN; 
    END
    INSERT INTO Customer (Username, HashPassword, FullName, DateOfBirth, Gender, Email, Income)
    VALUES (@Username, @HashPassword, @FullName, @DataOfBirth, @Gender, @Email, @Income);
    
    PRINT 'Customer inserted successfully';
END