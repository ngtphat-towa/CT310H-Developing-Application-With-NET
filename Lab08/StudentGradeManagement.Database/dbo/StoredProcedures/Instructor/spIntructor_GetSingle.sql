CREATE PROCEDURE [dbo].[spIntructor_GetSingle]
	@instructorId NVARCHAR (4)
AS
  SELECT I.InstructorId, I.InstructorName, I.DepartmentId, D.DepartmentName
  FROM dbo.Instructor AS I
  INNER JOIN dbo.Department AS D ON I.DepartmentId = D.DepartmentId
  WHERE I.InstructorId = @InstructorId;
GO