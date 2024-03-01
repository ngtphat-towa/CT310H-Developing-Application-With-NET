CREATE PROCEDURE [dbo].[spIntructor_GetSingle]
	@instructorId NVARCHAR (4)
AS
BEGIN
	SELECT * FROM Instructor WHERE InstructorId = @instructorId;
END;
