CREATE PROCEDURE [dbo].[spDepartment_Delete]
    @DepartmentId nvarchar(15)
AS
BEGIN
  DELETE FROM Department
  WHERE DepartmentId = @DepartmentId;
END