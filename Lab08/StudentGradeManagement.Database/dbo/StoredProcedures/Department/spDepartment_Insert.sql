CREATE PROCEDURE [dbo].[spDepartment_Insert]
    @DepartmentId   NVARCHAR (15) ,
    @DepartmentName NVARCHAR (50) ,
    @Building       VARCHAR (20)  
AS
BEGIN
  INSERT INTO Department (DepartmentId, DepartmentName, Building)
  VALUES (@DepartmentId, @DepartmentName, @Building);
END