CREATE PROCEDURE [dbo].[spCourse_GetAll]
AS
BEGIN
    SELECT c.* , dp.DepartmentName
        FROM dbo.Course c
        JOIN dbo.Department dp 
            ON dp.DepartmentId =c.DepartmentId;
END