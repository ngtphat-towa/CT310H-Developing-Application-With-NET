CREATE PROCEDURE [dbo].[spCourse_GetSingle]
	@CourseId     VARCHAR (10) = NULL,
    @CourseName   NVARCHAR (50)= NULL,
    @DepartmentId NVARCHAR (15)= NULL
AS
BEGIN
    SELECT c.*,dp.DepartmentName 
        FROM dbo.Course c
        JOIN Department dp
        ON dp.DepartmentId = c.DepartmentId
        WHERE c.CourseId= @CourseId 
        OR c.CourseName Like @CourseName
        OR c.DepartmentId Like @DepartmentId;
END;
