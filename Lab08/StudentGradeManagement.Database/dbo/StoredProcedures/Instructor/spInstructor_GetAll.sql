CREATE PROCEDURE [dbo].[spInstructor_GetAll]
AS
  SELECT I.InstructorId, I.InstructorName, I.DepartmentId, D.DepartmentName
  FROM dbo.Instructor AS I
  INNER JOIN dbo.Department AS D ON I.DepartmentId = D.DepartmentId;
GO