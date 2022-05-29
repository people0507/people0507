Create database QuanliSanPhamSieuThi
go

--Product
--Stall
--ListOfProducts
--Account
--Bill
--BillInfo
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'admin',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 
)
GO
select * from Products,ListOfProduct where Products.id = ListOfProduct.id 
select Product.id ,Product.name,ListOfProduct.

CREATE TABLE ListOfProduct
(
	id INT PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

DELETE FROM Products WHERE idPr
CREATE TABLE Products
(
	idPr INT PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	id INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	amout INT NOT NULL,
	
	FOREIGN KEY (idPr) REFERENCES dbo.ListOfProduct(id)
)
GO


CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	status INT NOT NULL DEFAULT 0 
	
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idProduct INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idProduct) REFERENCES dbo.Product(id)
)
GO

insert into Account 
	( UserName,
	DisplayName,
	PassWord,
	Type
	)
values ( N'admin' , -- UserName - nvarchar(100)
          N'admin62TH4' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
insert into Account 
	( UserName,
	DisplayName,
	PassWord,
	Type
	)
values  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )



