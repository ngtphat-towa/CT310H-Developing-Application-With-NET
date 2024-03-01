CREATE PROCEDURE [dbo].[spClass_Delete]
    @ClassId VARCHAR(15)
AS
BEGIN
    DELETE FROM Class WHERE ClassId = @ClassId;
END;