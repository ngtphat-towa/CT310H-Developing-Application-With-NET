CREATE PROCEDURE [dbo].[spClass_GetSingle]
    @ClassId VARCHAR(15)  = null,
    @ClassName NVARCHAR(50)= nul
AS
BEGIN
    SELECT cl.*,dp.DepartmentName 
        FROM dbo.Class cl
        JOIN Department dp
        ON dp.DepartmentId = cl.DepartmentId
        WHERE ClassId = @ClassId 
        OR ClassName Like @ClassName;
END;