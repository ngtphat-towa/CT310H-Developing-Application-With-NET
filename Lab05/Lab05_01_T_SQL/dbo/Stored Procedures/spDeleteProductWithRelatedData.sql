CREATE PROCEDURE [spDeleteProductWithRelatedData]
    @ProductId NVARCHAR(5)
AS
BEGIN
    SET NOCOUNT ON;
        -- Delete related data from Sales and Imports tables first due to ON DELETE NO ACTION
        DELETE FROM Sales WHERE ProductId = @ProductId;
        DELETE FROM ProductImports WHERE ProductId = @ProductId;

        -- Delete the product from the Product table
        DELETE FROM dbo.Product  WHERE ProductId = @ProductId;

END;