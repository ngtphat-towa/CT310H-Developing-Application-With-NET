-- TASK 01 --

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CalculateStock] 
	@DailyId int, @ProductId Nvarchar(3),
	@TotalSale int Output, @TotalImport int output,
	@TotalStock int output
AS
BEGIN
	SET NOCOUNT ON;

	-- Check if there any product imported
	SELECT @TotalImport = SUM(PIP.TotalNumber)
	FROM DBO.ProductImports PIP
	WHERE PIP.DailyId =@DailyId
		AND PIP.ProductId = @ProductId;
	
	-- If not then return;
	IF @TotalImport IS NULL RETURN;
	
	-- Calculate total sales by product and daily id
	SELECT @TotalSale = SUM(SL.TotalNumber)
	FROM DBO.Sales Sl
	WHERE SL.DailyId =@DailyId
		AND SL.ProductId = @ProductId;
	
	-- Check if the @TotalSale is null
	IF @TotalSale IS NULL 
		SET @TotalSale = 0;

	SET @TotalStock = @TotalStock - @TotalSale;

END
GO

DECLARE @SALE INT, @IMPORT INT, @STOCK INT;
EXECUTE DBO.CalculateStock 2, '002', @IMPORT OUTPUT, 
						   @SALE OUTPUT, @STOCK OUTPUT;

PRINT 'Total import: '+ CAST(@IMPORT AS NVARCHAR(20))+
	  'Total sales:  ' + CAST(@SALE AS NVARCHAR(20)) +
	  'Stock:	     '+ CAST(@STOCK AS NVARCHAR(20));

-- TASK 02 --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE dbo.SellingProduct 
	@DailyId INT, @ProductId NVARCHAR(3), 
	@SaleNumber INT, @UnitPrice INT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @TotalImport INT, @TotalSale INT;

	SELECT @TotalImport=SUM(PIP.TotalNumber)
	FROM ProductImports PIP
	WHERE PIP.DailyId=@DailyId 
	  AND PIP.ProductId = @ProductId
	
	IF @TotalImport IS NULL	
	BEGIN
		PRINT 'Product: ' +@ProductId+ ' doesnt exist in store';
		RETURN;
	END

	SELECT @TotalSale =SUM(SL.TotalNumber)
	FROM Sales SL
	WHERE SL.DailyId = @DailyId 
	 AND SL.ProductId =@ProductId;

	IF @TotalSale IS NULL
		SET @TotalSale = 0;
	
	IF @TotalImport >= @TotalImport + @TotalSale
		INSERT INTO DBO.Sales VALUES(@ProductId, @DailyId, GETDATE(),@TotalSale, @UnitPrice)
	ELSE
		PRINT 'Not enough stock in store';

END
GO

Execute SellingProduct 2, '002', 160, 12;

-- TASK 03 --


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetStockByBranchId
    @BranchId INT
AS
BEGIN
	SELECT b.BranchId, p.ProductId, p.ProductName,
		   SUM(pi.TotalNumber) - SUM(s.TotalNumber) AS Stock
	FROM Branch b
	INNER JOIN ProductImports pi ON b.BranchId = pi.BranchId
	INNER JOIN Product p ON pi.ProductId = p.ProductId
	LEFT JOIN Sales s ON pi.ProductId = s.ProductId AND pi.BranchId = s.BranchId
	WHERE b.BranchId = @BranchId
	GROUP BY b.BranchId, p.ProductId, p.ProductName
	ORDER BY b.BranchId, p.ProductId;

END;

GO

-- TASK 04 --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE dbo.spCalculateInventory
AS
BEGIN
SELECT b.BranchId,b.BranchName, p.ProductId, p.ProductName,
           SUM(pi.TotalNumber) - COALESCE(SUM(s.TotalNumber), 0) AS Stock
    FROM Branch b
    INNER JOIN ProductImports pi ON b.BranchId = pi.BranchId
    INNER JOIN Product p ON pi.ProductId = p.ProductId
    LEFT JOIN Sales s ON pi.ProductId = s.ProductId AND pi.BranchId = s.BranchId
    GROUP BY b.BranchId,b.BranchName, p.ProductId, p.ProductName
    ORDER BY b.BranchId, p.ProductId;
END
GO

-- TASK 05 --
CREATE PROCEDURE DeleteProductWithRelatedData
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
