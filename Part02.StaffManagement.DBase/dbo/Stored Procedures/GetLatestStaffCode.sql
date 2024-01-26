CREATE PROCEDURE dbo.GetLatestStaffCode
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @staffCount INT;

    SELECT @staffCount = COUNT(*)
    FROM dbo.Staff;

    IF @staffCount > 0
    BEGIN
        SELECT TOP 1 StaffCode
        FROM dbo.Staff
        ORDER BY StaffCode DESC;
    END
    ELSE
    BEGIN
        -- Handle the case of an empty table (e.g., return NULL, raise an error, etc.)
        -- For example, to return NULL:
        SELECT 0 AS StaffCode;
    END
END
