CREATE PROCEDURE [dbo].[spClass_GetSingle]
    @ClassId VARCHAR(15)
AS
BEGIN
    SELECT cl.*,dp.DepartmentName 
        FROM dbo.Class cl
        JOIN Department dp
        ON dp.DepartmentId = ClassId
        WHERE ClassId = @ClassId;
END;