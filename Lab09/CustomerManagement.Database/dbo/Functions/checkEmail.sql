create function dbo.checkEmail (@Email nvarchar(50))
returns bit
as
begin
    RETURN CASE 
        WHEN @Email LIKE '%_@__%.%' AND CHARINDEX(' ', @Email) = 0 THEN 1
        ELSE 0
    END
end;