Create database QuanliSanPhamSieuThi
go
Create table Account
	(
	UserName Nvarchar(100) not null,
	Name Nvarchar(100) not null,
	PassWord Nvarchar(1000) not null,
	Role nvarchar(50),
	Born nvarchar(50),
	Sex nvarchar(50),
	Birth Date,
	Contact nvarchar(50),
	)
go

INSERT INTO Account
                         (UserName, Name, PassWord, Role, Born, Sex, Birth, Contact)
VALUES        (N'admin', N'Nguyễn Đăng Nhân', N'1', N'admin', N'Hà Nội', N'Nam', CONVERT(DATETIME, '2002-07-05 00:00:00', 102), N'0999999999')




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
	amount INT NOT NULL,
	
	FOREIGN KEY (idPr) REFERENCES dbo.ListOfProduct(id)
)
GO
Create table Bill4
(
	nameKH nvarchar(100) not null,
	namePr nvarchar(100) not null,
	price float not null,
	amount float not null,
	ngaymua date
)
go


Create table Bills(
	nameKH nvarchar(100) not null primary key,
	namePr nvarchar(100) not null,
	price float not null default 0,
	amount int not null

)
go




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



INSERT INTO Bill4 (nameKH, namePr, price, amount, ngaymua) VALUES (N'Nhân', N'Chim', 10000, 2, CONVERT(DATETIME, '2022-06-03 00:00:00', 102))