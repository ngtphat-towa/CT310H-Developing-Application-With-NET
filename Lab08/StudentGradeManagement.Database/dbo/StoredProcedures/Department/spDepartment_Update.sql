CREATE PROCEDURE [dbo].[spDepartment_Update]
    @DepartmentId NVARCHAR(15),
    @DepartmentName NVARCHAR(50),
    @Building VARCHAR(20)
AS
BEGIN
    UPDATE Department SET DepartmentName = @DepartmentName, Building = @Building WHERE DepartmentId = @DepartmentId;
END;
