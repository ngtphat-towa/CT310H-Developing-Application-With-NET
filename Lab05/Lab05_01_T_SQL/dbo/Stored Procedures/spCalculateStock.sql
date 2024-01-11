CREATE PROCEDURE [dbo].[spCalculateStock] 
	@BranchId int, @ProductId Nvarchar(3),
	@TotalSale int Output, @TotalImport int output,
	@TotalStock int output
AS
BEGIN
	SET NOCOUNT ON;

	-- Check if there any product imported
	SELECT @TotalImport = SUM(PIP.TotalNumber)
	FROM DBO.ProductImports PIP
	WHERE PIP.BranchId =@BranchId
		AND PIP.ProductId = @ProductId;
	
	-- If not then return;
	IF @TotalImport IS NULL RETURN;
	
	-- Calculate total sales by product and Branch id
	SELECT @TotalSale = SUM(SL.TotalNumber)
	FROM DBO.Sales Sl
	WHERE SL.BranchId =@BranchId
		AND SL.ProductId = @ProductId;
	
	-- Check if the @TotalSale is null
	IF @TotalSale IS NULL 
		SET @TotalSale = 0;

	SET @TotalStock = @TotalStock - @TotalSale;

END