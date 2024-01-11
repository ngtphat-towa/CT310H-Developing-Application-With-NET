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