CREATE PROCEDURE [dbo].[spCourse_Update]
    @CourseId     VARCHAR (10),
    @CourseName   NVARCHAR (50),
    @DepartmentId NVARCHAR (15),
    @CreditNumber INT
AS
BEGIN
   UPDATE Course SET 
    CourseName= @CourseName, 
    DepartmentId= @DepartmentId, 
    CreditNumber= @CreditNumber
   WHERE CourseId=@CourseId;
END