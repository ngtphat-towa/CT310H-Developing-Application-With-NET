CREATE PROCEDURE [dbo].[spCourse_Delete]
	    @CourseId     VARCHAR (10)
AS
BEGIN
	DELETE FROM dbo.Course where CourseId =@CourseId;
END
