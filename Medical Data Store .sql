create database medicalStoreDatabase

use medicalStoreDatabase

create table Account
(
	userName	varchar(100) not null primary key,
	[password]	varchar(100) not null,
	gender		varchar(8) not null,
	age			int,
	userType	varchar(100) not null,
)


delete from Account
select * from account
select * from Account where userName='Sujan' and password='123'


insert into Account values('Sujan','123','Male',22,'Customer')
insert into Account values('Nasir','321','Male',22,'Admin')

create table Product(
	productID		varchar(100) not null primary key,
	ProductName		varchar(100) not null,
	Price			float,
	ProductType		varchar(10) not null,
	ProductCompanyName varchar(100) not null,
)

select * from Product where ProductName like 'z%'
drop table Product
insert into Product values
('p0001','Zimax','Tablet',30,'ACI'),
('p0001','ZithRin','Tablet',30,'ACI')

insert into Product values
('p0003','Napa','Tablet',3,'SKF+'),
('p0004','Acetaminophen.','Tablet',30,'ABCompany'),
('p0005','guaifenesin','Syrup',30,'Incepta'),
('p0006','Vicks Formula 44 for Dry Coughs','Syrup',30,'Drug International'),
('p0007','Actifed Dry','Syrup',30,'ABCompany')


create proc sp_SelectAccountData
as
begin
	select * from Account
end

create proc sp_SelectProductData
as
begin
	select * from Product
end