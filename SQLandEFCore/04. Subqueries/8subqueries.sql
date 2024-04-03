USE [AdventureWorks2019]

-- 1. Salespersons who have at least one order in 2012
SELECT [FirstName]
FROM [Person].[Person] 
WHERE [BusinessEntityID] IN (
	SELECT [SalesPersonID]
	FROM [Sales].[SalesOrderHeader]
	WHERE YEAR([OrderDate]) = 2012)

--2. High value customers with total due > 500000 
SELECT [FirstName],
	   [LastName],
	   [TotalDue]
FROM (
    SELECT [p].[FirstName], 
		   [p].[LastName], 
        (SELECT SUM([soh].[TotalDue]) 
         FROM [Sales].[SalesOrderHeader] [soh]
         WHERE [soh].[CustomerID] = [c].[CustomerID]
         GROUP BY [soh].[CustomerID]) AS [TotalDue]
    FROM 
        [Person].[Person] [p]
    JOIN 
        [Sales].[Customer] [c] ON [p].[BusinessEntityID] = [c].[PersonID]
) AS [Subquery]
WHERE 
    [TotalDue] > 500000


--3. Salespersons with orders in more than 1 country
SELECT CONCAT([FirstName], ' ', [LastName]) AS [FullName]
FROM [Person].[Person]
WHERE [BusinessEntityID] IN (
    SELECT [SalesPersonID]
    FROM [Sales].[SalesOrderHeader]
    JOIN [Sales].[SalesTerritory] ON [SalesOrderHeader].[TerritoryID] = [SalesTerritory].[TerritoryID]
    GROUP BY [SalesPersonID]
    HAVING COUNT(DISTINCT [CountryRegionCode]) > 1
)

--4. Products with a unit price higher than the average unit price
SELECT [Name] AS [ProductName], 
	   [ListPrice] AS [UnitPrice]
FROM [Production].[Product]
WHERE [ListPrice] > (
    SELECT AVG([ListPrice])
    FROM [Production].[Product]
)

--5. Order with the largest total due
SELECT [SalesOrderID]
FROM [Sales].[SalesOrderHeader]
WHERE [TotalDue] = (
    SELECT MAX([TotalDue])
    FROM [Sales].[SalesOrderHeader]
)

--6. Products with the highest unit price
SELECT [Name] AS [ProductName],
    (
	  SELECT MAX([ListPrice]) FROM [Production].[Product]) AS [MaxListPrice]
      FROM [Production].[Product]
      WHERE [ListPrice] = (SELECT MAX([ListPrice]) FROM [Production].[Product]
)

--7. 
 SELECT [ProductNumber],
	   [Name],
	   [ProductClass] = CASE [Class]
			WHEN 'H' THEN 'High'
			WHEN 'M' THEN 'Medium'
			WHEN 'L' THEN 'Low'
			ELSE 'No class'
		END
FROM [Production].[Product]
ORDER BY [ProductNumber]

--8. Products with price higher than the average price
SELECT [ProductNumber], 
	   [Name],
	   [ListPrice]
FROM [Production].[Product]
WHERE [ListPrice] > (
    SELECT AVG([ListPrice])
    FROM [Production].[Product]
)
ORDER BY [ProductNumber]