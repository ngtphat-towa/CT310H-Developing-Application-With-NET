CREATE PROCEDURE [dbo].[spInstructor_Insert]
(
  @InstructorId NVARCHAR(4) NOT NULL,
  @InstructorName NVARCHAR(50) NOT NULL,
  @DepartmentId NVARCHAR(15) NOT NULL,
  @Password NVARCHAR(15) NOT NULL
)
AS
BEGIN
  INSERT INTO Instructor (InstructorId, InstructorName, DepartmentId, Password)
  VALUES (@InstructorId, @InstructorName, @DepartmentId, @Password);
END