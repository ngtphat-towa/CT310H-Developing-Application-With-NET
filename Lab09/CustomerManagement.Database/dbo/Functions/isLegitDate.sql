create function dbo.isLegitDate (@date nvarchar(50))
returns bit
as
begin
    RETURN CASE 
        WHEN ISDATE(@date) = 1 THEN 1
        ELSE 0
    END
end;
