CREATE PROCEDURE [spGetStockByBranchId]
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