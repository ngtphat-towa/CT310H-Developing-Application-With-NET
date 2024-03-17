CREATE PROCEDURE [dbo].[spInstructor_Update]
  @InstructorId NVARCHAR(4),
  @InstructorName NVARCHAR(50),
  @DepartmentId NVARCHAR(15)
AS
  UPDATE dbo.Instructor
  SET InstructorName = @InstructorName,
      DepartmentId = @DepartmentId
  WHERE InstructorId = @InstructorId;
GO