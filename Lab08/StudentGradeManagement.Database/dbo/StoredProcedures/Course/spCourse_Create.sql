CREATE PROCEDURE [dbo].[spCourse_Create]
    @CourseId     VARCHAR (10),
    @CourseName   NVARCHAR (50),
    @DepartmentId NVARCHAR (15),
    @CreditNumber INT
AS
BEGIN
  INSERT INTO Course(CourseId, CourseName, DepartmentId, CreditNumber)
  VALUES (@CourseId, @CourseName, @DepartmentId, @CreditNumber);
END