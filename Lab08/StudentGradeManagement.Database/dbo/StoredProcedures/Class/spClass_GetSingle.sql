CREATE PROCEDURE [dbo].[spClass_GetSingle]
    @ClassId VARCHAR(15)
AS
BEGIN
    SELECT * FROM Class WHERE ClassId = @ClassId;
END;