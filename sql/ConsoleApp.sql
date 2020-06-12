CREATE DATABASE [Sales]

USE Sales

CREATE TABLE [Orders]
(
    ID INT PRIMARY KEY,
    CustomerID INT
)
GO
CREATE TABLE [OrderItems]
(
    Id INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    ProductName NVARCHAR(255)
)

GO

ALTER TABLE [OrderItems] 
    ADD CONSTRAINT FK_ORDER_ORDER_ITEMS FOREIGN KEY (OrderID)
    REFERENCES [Orders] (ID);
GO

INSERT INTO [Orders](ID, CustomerID) VALUES(1, 1)

DECLARE @Index INT
 SET @Index = 1

WHILE (@Index <= 1000)
BEGIN
    INSERT INTO OrderItems(Id, OrderID, ProductID, ProductName)
    SELECT @Index, 1, @Index, 'Produto ' + CONVERT(NVARCHAR, @Index)

    SET @Index = @Index + 1
END

SELECT * FROM [Orders]
SELECT * FROM [OrderItems]

--  DROP TABLE [Order]
--  DROP TABLE [OrderItems]