/*
В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Представьте схему такой БД и напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

--drop table dbo.Product
create table dbo.Product (
 product_id int not null identity(1,1),
 product_name varchar(100),
 CONSTRAINT PK_Product PRIMARY KEY CLUSTERED(product_id ASC)
)
go

--drop table dbo.Category
create table dbo.Category (
 category_id int not null identity(1,1),
 category_name varchar(50) not null,
 CONSTRAINT PK_Category PRIMARY KEY CLUSTERED(category_id ASC)
)
go

--drop table dbo.ProductCategory
create table dbo.ProductCategory (
 product_id int not null,
 category_id int not null,
 CONSTRAINT PK_ProductCategory PRIMARY KEY CLUSTERED(product_id ASC, category_id ASC),
 CONSTRAINT FK_ProductCategory_product_id FOREIGN KEY(product_id) REFERENCES dbo.Product(product_id),
 CONSTRAINT FK_ProductCategory_category_id FOREIGN KEY(category_id) REFERENCES dbo.Category(category_id)
)
go

insert into Product values
('qqq'),
('zzz'),
('xxx')

insert into Category values
('A'),
('B')

insert into ProductCategory values
(1, 1),
(1, 2),
(2, 1)


select p.product_name, c.category_name
from Product p
left join ProductCategory pc
on pc.product_id = p.product_id
left join Category c
on c.category_id = pc.category_id
