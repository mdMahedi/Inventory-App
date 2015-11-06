create database InvertoryDB
go
use InvertoryDB
go
create table Product
(
ID int identity primary key,
Name nvarchar (100),
UnitPrice decimal (8,2),
Quantity int
)
go
Update Product set Name='',UnitPrice=0,Quantity=0
go
Select * From Product