CREATE PROCEDURE [dbo].[spSellingProduct] 
	@BranchId INT, @ProductId NVARCHAR(3), 
	@SaleNumber INT, @UnitPrice INT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @TotalImport INT, @TotalSale INT;

	SELECT @TotalImport=SUM(PIP.TotalNumber)
	FROM ProductImports PIP
	WHERE PIP.BranchId=@BranchId 
	  AND PIP.ProductId = @ProductId
	
	IF @TotalImport IS NULL	
	BEGIN
		PRINT 'Product: ' +@ProductId+ ' doesnt exist in store';
		RETURN;
	END

	SELECT @TotalSale =SUM(SL.TotalNumber)
	FROM Sales SL
	WHERE SL.BranchId = @BranchId 
	 AND SL.ProductId =@ProductId;

	IF @TotalSale IS NULL
		SET @TotalSale = 0;
	
	IF @TotalImport >= @TotalImport + @TotalSale
		INSERT INTO DBO.Sales VALUES(@ProductId, @BranchId, GETDATE(),@TotalSale, @UnitPrice)
	ELSE
		PRINT 'Not enough stock in store';

END