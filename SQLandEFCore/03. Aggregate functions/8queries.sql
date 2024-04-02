USE [AdventureWorks2019]

--1. Top 10 customers by total purchases
SELECT TOP 10	
	[c].[CustomerID],
	CONCAT([p].[FirstName], ' ' ,[p].[LastName]) AS [FullName],
	SUM([o].[TotalDue]) AS [TotalPurchases]
FROM [Sales].[Customer] AS [c]
JOIN [Sales].[SalesOrderHeader] AS [o] ON [c].[CustomerID] = [o].[CustomerID]
JOIN [Person].[Person] AS [p] ON [p].[BusinessEntityID] = [c].[PersonID]
GROUP BY [c].[CustomerId], [p].[FirstName], [p].[LastName]
ORDER BY [TotalPurchases] DESC

--2. Top 10 products based on quantity sold
SELECT TOP 10 
	   [p].[Name] AS [ProductName],
	   SUM([od].[OrderQty]) AS [TotalSoldQuantity]
FROM [Production].[Product] [p]
JOIN [Sales].[SalesOrderDetail] AS [od] ON [od].[ProductID] = [p].[ProductID]
GROUP BY [p].[ProductID], [p].[Name]
ORDER BY [TotalSoldQuantity] DESC

--3. AVG vacation hours taken by employee ordered by ascending
SELECT [hre].[JobTitle],
	   [p].[FirstName],
       AVG([hre].[VacationHours]) AS [AverageVacationHours]
FROM [HumanResources].[Employee] [hre]
JOIN [Person].[Person] AS [p] ON [p].[BusinessEntityID] = [hre].[BusinessEntityID]
GROUP BY [hre].[JobTitle], [p].[FirstName]
ORDER BY [AverageVacationHours] ASC

--4. Total order quantity of each product 
SELECT 
	[p].[ProductId],
	[p].[Name] AS [ProductName],
	SUM([o].[OrderQty]) AS [TotalOrderQuantity]
FROM [Production].[Product] AS [p]
JOIN [Sales].[SalesOrderDetail] AS [o] ON [p].[ProductID] = [o].[ProductID]
GROUP BY [p].[ProductID], [p].[Name]

--5. Products with special offer = 'no discount'
SELECT [p].[Name]
FROM [Sales].[SpecialOffer] [o]
JOIN [Sales].[SpecialOfferProduct] AS [op] ON [o].[SpecialOfferID] = [op].[SpecialOfferID]
JOIN [Production].[Product] AS [p] ON [p].[ProductID] = [op].[ProductID]
WHERE [o].[Description] = 'No Discount'

--6. Highest and lowest unit price
SELECT MAX([p].[ListPrice]) AS [HighestUnitPrice],
       MIN([p].[ListPrice]) AS [LowestUnitPrice]
FROM [Production].[Product] [p]

--7. Highest and lowest number of orders
SELECT 
    [p].[Name] AS [ProductName],
    MAX([sod].[OrderQty]) AS [HighestNumberOfOrders],
    MIN([sod].[OrderQty]) AS [LowestNumberOfOrders]
FROM [Production].[Product] [p]
JOIN [Sales].[SalesOrderDetail] [sod] ON [p].[ProductID] = [sod].[ProductID]
GROUP BY [p].[Name]

--8. Average unit price and sum  unit price of each product
SELECT [p].[Name] AS [ProductName],
	   AVG([od].[UnitPrice]) AS [AverageUnitPrice],
	   SUM([od].[UnitPrice]) AS [SumUnitPrice]
FROM [Production].[Product] [p]
JOIN [Sales].[SalesOrderDetail] [od] ON [p].[ProductID] = [od].[ProductID]
GROUP BY [p].[Name]