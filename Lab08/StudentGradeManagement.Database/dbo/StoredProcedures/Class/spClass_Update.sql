CREATE PROCEDURE spClass_Update
    @ClassId VARCHAR(15),
    @ClassName NVARCHAR(50),
    @DepartmentId NVARCHAR(15),
    @YearCode VARCHAR(5)
AS
BEGIN
    UPDATE Class SET ClassName = @ClassName, DepartmentId = @DepartmentId, YearCode = @YearCode WHERE ClassId = @ClassId;
END;