USE [AdventureWorks2019]


--1. Update email address 
BEGIN TRY 
	BEGIN TRANSACTION
	UPDATE [Person].[EmailAddress] 
	SET [EmailAddress] = 'roberto.tamburello@adventure-works.com',
		[ModifiedDate] = GETDATE()
	WHERE [BusinessEntityID] = 3

	COMMIT TRANSACTION
	PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION
        PRINT 'Transaction rolled back'
    END
		PRINT 'Error occurred'
END CATCH



--2. Insert and delete email address
BEGIN TRY 
	BEGIN TRANSACTION
	INSERT INTO [Person].[EmailAddress] ([BusinessEntityID], [EmailAddress], [rowguid], [ModifiedDate])
	VALUES(10, 'michael.raheem@adventure-works.com', 'CA2C740E-75B2-420C-9D4B-E3CBC6609604', GETDATE())

	DELETE FROM [Person].[EmailAddress]
	WHERE [BusinessEntityID] = 10

	COMMIT TRANSACTION
	PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION
        PRINT 'Transaction rolled back'
    END
		PRINT 'Error occurred' 
END CATCH

--3.  Add new department and group name and change group name
BEGIN TRY 
	BEGIN TRANSACTION
	INSERT INTO [HumanResources].[Department] ([Name], [GroupName], [ModifiedDate])
	VALUES ('Customer Service', 'Customer Care', GETDATE())

	UPDATE [HumanResources].[Department]
	SET [GroupName] = 'Customer Support'
	WHERE [GroupName] = 'Customer Care'

	COMMIT TRANSACTION
	PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION
        PRINT 'Transaction rolled back'
    END
		PRINT 'Error occurred'
END CATCH

--4. Update comment of top 5 orders and delete the oldest order
BEGIN TRY 
	BEGIN TRANSACTION
	UPDATE [Sales].[SalesOrderHeader]
    SET [Comment] = 'New comment about order'
    WHERE [SalesOrderID] IN (SELECT TOP (5) [SalesOrderID] FROM [Sales].[SalesOrderHeader])

	DELETE FROM [Sales].[SalesOrderHeader]
    WHERE [SalesOrderID] = (SELECT MIN([SalesOrderID]) FROM [Sales].[SalesOrderHeader])

	COMMIT TRANSACTION
	PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION
        PRINT 'Transaction rolled back'
    END
		PRINT 'Error occurred'
END CATCH

--5. Delete all orders for the customer with id = 16517 and update the price of all products
BEGIN TRY 
	BEGIN TRANSACTION
	DELETE FROM [Sales].[SalesOrderHeader]
	WHERE [CustomerID] = 16517

    UPDATE [Production].[Product]
	SET [ListPrice] += 178.99
    
	COMMIT TRANSACTION
	PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION
        PRINT 'Transaction rolled back'
    END
		PRINT 'Error occurred'
END CATCH

--6. Add new special offer and update discount percentage
BEGIN TRY 
	BEGIN TRANSACTION
	INSERT INTO [Sales].[SpecialOffer] ([Description], [DiscountPct], [Type], [Category], [StartDate], [EndDate], [MinQty], [MaxQty], [rowguid], [ModifiedDate])
	VALUES ('New special offer', 0.60, 'Volume discount', 'Reseller', GETDATE(), DATEADD(MONTH, 1, GETDATE()), 1, 100, NEWID(), GETDATE())

    UPDATE [Sales].[SpecialOffer]
    SET [DiscountPct] = [DiscountPct] * 1.1 
    WHERE [StartDate] < GETDATE()
    
	COMMIT TRANSACTION
	PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION
        PRINT 'Transaction rolled back'
    END
		PRINT 'Error occurred'
END CATCH

--7. Delete expired special offers and update category for special offers (transaction with error)
BEGIN TRY 
    BEGIN TRANSACTION

    DELETE FROM [Sales].[SpecialOffer]
    WHERE [EndDate] < GETDATE()

    UPDATE [Sales].[SpecialOffer]
    SET [Category] = 'New volume discount'
    WHERE [Type] = 'Volume discount'

    COMMIT TRANSACTION
    PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Transaction rolled back'
    END
    PRINT 'Error occurred' + ERROR_MESSAGE()
END CATCH

--8. Update name of phone number type with id 1 and delete phone number type with id 3 (transaction with error)
BEGIN TRY 
    BEGIN TRANSACTION

    UPDATE [Person].[PhoneNumberType]
	SET [Name] = 'Phone'
    WHERE [PhoneNumberTypeID] = 1

    DELETE FROM [Person].[PhoneNumberType]
    WHERE [PhoneNumberTypeID] = 3

    COMMIT TRANSACTION
    PRINT 'Transaction committed'
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION
        PRINT 'Transaction rolled back'
    END
    PRINT 'Error occurred' + ERROR_MESSAGE()
END CATCH



