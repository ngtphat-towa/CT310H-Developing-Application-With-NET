CREATE PROCEDURE dbo.spClass_Insert
    @ClassId VARCHAR(15),
    @ClassName NVARCHAR(50),
    @DepartmentId NVARCHAR(15),
    @YearCode VARCHAR(5)
AS
BEGIN
    INSERT INTO Class (ClassId, ClassName, DepartmentId, YearCode) VALUES (@ClassId, @ClassName, @DepartmentId, @YearCode);
END;