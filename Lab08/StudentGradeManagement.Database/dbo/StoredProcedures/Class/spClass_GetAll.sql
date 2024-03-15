CREATE PROCEDURE [dbo].[spClass_GetAll]
AS
BEGIN
    SELECT cl.*,dp.DepartmentName 
        FROM dbo.Class cl
        JOIN Department dp
        ON dp.DepartmentId = ClassId;
END;
