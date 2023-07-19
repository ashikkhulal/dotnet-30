-- Day 20 Assignment:

USE MyLocalDb;

-- Creating two tables with primary keys:
CREATE TABLE Orders (
	OrderID [bigint] NOT NULL,
	CustomerID [int] NOT NULL,
	ShipperID [int] NOT NULL,
	OrderDate [datetime],
	CONSTRAINT PK_Order PRIMARY KEY CLUSTERED (OrderID)
);

CREATE TABLE Shippers (
	ShipperID [int] NOT NULL,
	OrderID [bigint] NOT NULL,
	CustomerID [int] NOT NULL,
	EmployeeID [int] NOT NULL,
	OrderDate [datetime],
	DestinationCity [nvarchar](20),
	CONSTRAINT PK_Shippers PRIMARY KEY CLUSTERED (ShipperID)
);

CREATE TABLE Customers (
	CustomerID [int] NOT NULL,
	CustomerName [nvarchar](50),
	ContactName [nvarchar](50),
	Country [nvarchar](20),
	CONSTRAINT PK_Customer PRIMARY KEY CLUSTERED (CustomerID)
);

-- Adding some entries:
INSERT INTO Orders(OrderID, CustomerID, ShipperID, OrderDate)
VALUES 
(10308, 2, 3, 1996-09-18),
(10309, 37,	1, 1996-09-19),
(10310,	77,	2, 1996-09-20);

INSERT INTO Shippers(ShipperID, OrderID, CustomerID, EmployeeID, OrderDate, DestinationCity)
VALUES
(3,	2, 7, 1996-09-18, 10308, 'Germany'),
(1,	37,	3, 1996-09-19, 10309, 'Mexico'),
(2,	77,	8,1996-09-20, 10310, 'Mexico');

INSERT INTO Customers(CustomerID, CustomerName, ContactName, Country)
VALUES
(1,	'Alfreds Futterkiste', 'Maria Anders',	'Germany'),
(2,	'Ana Trujillo Emparedados y helados',	'Ana Trujillo',	'Mexico'),
(3,	'Antonio Moreno Taquería',	'Antonio Moreno',	'Mexico');

-- Inner join:
SELECT * FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

SELECT Orders.OrderID, Customers.CustomerName, Shippers.ShipperID FROM ((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipperID = Shippers.ShipperID);

-- Left join:
SELECT * FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID;

SELECT Customers.CustomerName, Orders.OrderID FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID;

SELECT Customers.CustomerName, Orders.OrderID FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY Customers.CustomerName;

-- Right join:
SELECT * FROM Orders
RIGHT JOIN Customers ON Orders.CustomerID = Orders.CustomerID;

SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM Orders
RIGHT JOIN Customers ON Orders.CustomerID = Orders.CustomerID;

SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM Orders
RIGHT JOIN Customers ON Orders.CustomerID = Orders.CustomerID
ORDER BY Orders.OrderID;

-- Full join:
SELECT * FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID;

SELECT Customers.CustomerName, Orders.OrderID FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;

SELECT Customers.CustomerName, Orders.OrderID FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY Customers.CustomerName;

-- Self join:
SELECT * FROM Orders
WHERE Orders.ShipperID > 1;

SELECT * FROM Shippers
WHERE Shippers.DestinationCity = 'Mexico';

-- Clean up:
ALTER TABLE Orders
DROP CONSTRAINT PK_Order;

ALTER TABLE Shippers
DROP CONSTRAINT PK_Shippers;

ALTER TABLE Customers
DROP CONSTRAINT PK_Customer;

DROP TABLE Orders;
DROP TABLE Shippers;
DROP TABLE Customers;