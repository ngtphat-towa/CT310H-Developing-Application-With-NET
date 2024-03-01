CREATE PROCEDURE dbo.spDepartment_GetSingle
    @DepartmentId NVARCHAR(15)
AS
BEGIN
    SELECT * FROM Department WHERE DepartmentId = @DepartmentId;
END;
