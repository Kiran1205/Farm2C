--drop database farm2c
go

create database farm2c

Go

use farm2c

GO
--drop table ItemCategory
create table ItemCategory
(
ItemCategoryID int not null identity,
CategoryName varchar(50) not null,
Description varchar(150),
Active bit
)

insert into ItemCategory(CategoryName,Description,Active) values('Poultry','Fresh Chicken',1);


--select * from ItemCategory
--drop table Units
CREATE TABLE Units
(
UnitID int not null,
UnitName varchar(50) not null,
Description  varchar(150),
Active bit
)

go

INSERT INTO Units(UnitID,UnitName,Description,Active) Values (1,'KG','Killo Grams',1);
INSERT INTO Units(UnitID,UnitName,Description,Active) Values (2,'Pcs','Pices',1);

Go

Create Table Quantity
(
QuantityID  int not null identity,
QuantityType varchar(50) not null,
UnitID int not null,
Description varchar(150)
)
go
insert into Quantity (QuantityType,UnitID,Description) values ('1',1,'1 KG');
insert into Quantity (QuantityType,UnitID,Description) values ('1/2',1,'1/2 KG');

insert into Quantity (QuantityType,UnitID,Description) values ('6',2,'pices');

insert into Quantity (QuantityType,UnitID,Description) values ('12',2,'pices');

GO

create table Items
(
ItemID int not null identity,
ItemCategoryID int not null,
ItemName varchar(50) not null,
Description varchar(150),
Active bit,
UnitID int not null,
ItemImage varbinary(max) not null
)

Go

create table ItemPrice
(
ItemPriceID int not null identity,
ItemID int not null,
QuantityID int not null,
Price decimal not null,
StartDate DateTime not null,
EndDate DateTime not null,
DefaultSelection bit
)
go
drop table InvoiceItemList
create table InvoiceItemList
(
InvoiceUniqId int not null identity,
InvoiceItemListID nvarchar(100)  not null,
ItemPriceID int not null,
NoOfUInits int not null,
)
Go
drop table Invoice
create  Table Invoice
(
InvocieID int not null identity,
InvoiceNumber nvarchar(50) not null,
UserID int not null,
AddressID int not null,
TotalAmount Decimal not null,
Discount Decimal  Null,
CoupounId int  null,
InvoiceItemListID  nvarchar(100)  not null
)
go
create table UserInfo
(
UserInfoID int not null identity,
UserName varchar(50),
PhoneNumber varchar(20),
UserPassword varchar(max),
)
GO
drop  table UserAddress
Create table UserAddress
(
UserAddressID int not null identity,
UserInfoID int not null,
Name varchar(50) not null,
PhoneNumber varchar(20) not null,
AlternatePhoneNumber varchar(20)  null,
PinCode int not null,
Address nvarchar(max),
Address1 nvarchar(max),
State varchar(50),
LandMark varchar(50),
DefaultAddress BIT,
IsActive BIT
)
CREATE Table UserBasket
(
UserBasketID int not null identity,
UserInfoID int not null,
ItemPriceID int not null
)
