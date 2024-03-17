CREATE PROCEDURE [dbo].[spInstructor_Delete]
(
  @InstructorId NVARCHAR(4) NOT NULL
)
AS
BEGIN
  DELETE FROM Instructor
  WHERE InstructorId = @InstructorId;
END
