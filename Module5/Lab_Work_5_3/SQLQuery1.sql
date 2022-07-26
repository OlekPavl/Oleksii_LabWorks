CREATE TABLE Products
(
	ProductId INT,
	ProductName VARCHAR(20),
	ProductDescription VARCHAR(20),
	ProductType VARCHAR(20),
	ProductPrice VARCHAR(20),
	SupplierId INT,
	CONSTRAINT PK_Product_ProductId PRIMARY KEY(ProductId),
)

CREATE TABLE Customers
(
	CustomerId INT,
	CustomerName VARCHAR(20),
	CustomerPhone VARCHAR(20),
	CustomerEmail VARCHAR(20),
	CustomerDetails VARCHAR(20),
	CONSTRAINT PK_Customer_CustomerId PRIMARY KEY(CustomerId),
	CONSTRAINT UQ_Customer_CustomerName UNIQUE(CustomerName),
	CONSTRAINT UQ_Customer_CustomerPhone UNIQUE(CustomerPhone),
	CONSTRAINT UQ_Customer_CustomerEmail UNIQUE(CustomerEmail)
)

CREATE TABLE Orders
(
	OrderId INT,
	OrderStatus VARCHAR(20),
	OrderDetails VARCHAR(20),
	OrderDate DATE,
	CONSTRAINT PK_Order_OrderId PRIMARY KEY(OrderId)
)

CREATE TABLE OrderList
(
	OrderId INT NOT NULL,
	ProductId INT NOT NULL,
	ProductQuanitity INT,
	CONSTRAINT PK_OrderList_OrderId_ProductId PRIMARY KEY(OrderId, ProductId)
)

CREATE TABLE Suppliers
(
	SupplierId INT,
	SupplierName VARCHAR(20),
	SupplierPhone VARCHAR(20),
	SupplierEmail VARCHAR(20),
	CONSTRAINT PK_Supplier_SupplierId PRIMARY KEY(SupplierId)
)

ALTER TABLE Products
ADD CONSTRAINT FK_Products_To_Suppliers FOREIGN KEY(SupplierId) REFERENCES Suppliers(SupplierId);

ALTER TABLE OrderList
ADD CONSTRAINT FK_OrderList_To_Orders FOREIGN KEY(OrderId) REFERENCES Orders(OrderId);

ALTER TABLE OrderList
ADD CONSTRAINT FK_OrderList_To_Products FOREIGN KEY(ProductId) REFERENCES Products(ProductId);

ALTER TABLE Orders
ADD CustomerId INT;

ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_To_Customers FOREIGN KEY(CustomerId) REFERENCES Customers(CustomerId);