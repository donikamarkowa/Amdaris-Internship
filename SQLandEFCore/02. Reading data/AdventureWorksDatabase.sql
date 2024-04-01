USE [AdventureWorks2019];

-- 1.
SELECT [FirstName],
	   [LastName],
	   [BusinessEntityID] AS [Employee_id]
FROM [Person].[Person]
ORDER BY [LastName] ASC


-- 2.
SELECT [p].[BusinessEntityID],
       [p].[FirstName],
       [p].[LastName],
       [ph].[PhoneNumber]
FROM [Person].[Person] [p]
JOIN [Person].[PersonPhone] [ph] ON [p].[BusinessEntityID] = [ph].[BusinessEntityID]
WHERE [p].[LastName] LIKE 'L%'
ORDER BY [p].[LastName], [p].[FirstName]

-- 3.
SELECT [a].[PostalCode],
	   [p].[LastName],
	   [s].[SalesYTD]
FROM [Sales].[SalesPerson] [s]
JOIN [Person].[Address] [a] ON [s].[BusinessEntityID] = [a].[AddressID]
JOIN [Person].[Person] [p] ON [s].[BusinessEntityID] = [p].[BusinessEntityID] 
WHERE [s].[SalesYTD] IS NOT NULL AND [s].[TerritoryID] IS NOT NULL
ORDER BY [s].[SalesYTD] ASC, [a].[PostalCode] DESC

-- 4.
SELECT [SalesOrderID],
	   SUM([UnitPrice] * [OrderQty]) AS [TotalCost]
FROM [Sales].[SalesOrderDetail]
GROUP BY [SalesOrderID]
HAVING 
    SUM([UnitPrice] * [OrderQty]) > 100000