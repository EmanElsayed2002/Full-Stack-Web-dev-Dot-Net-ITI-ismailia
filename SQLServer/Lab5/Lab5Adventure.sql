use AdventureWorks2012


--1
select SalesOrderID,ShipDate from sales.SalesOrderHeader where OrderDate between '7/28/2002' and '7/29/2014'

--2
select ProductID,Name from Production.Product where StandardCost <110

--3
select ProductID,Name from Production.Product where Weight is null

--4.
select * from Production.Product where Color in ('Silver' , 'Black' , 'Red Color')

--5.
select * from Production.Product where Name like 'B%'

--6
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'						
WHERE ProductDescriptionID = 3

select * from Production.ProductDescription where Description like '%[_]%'

--7
select sum(TotalDue) as sumTotalDue, orderdate  from Sales.SalesOrderHeader where OrderDate between '7/1/2001' and '7/31/2014'	  group by OrderDate

--8
select distinct(HireDate)  from HumanResources.Employee 

--9
select avg(distinct(ListPrice)) as avgListPrice from Production.Product 

--10
select 'The '+name+' is only ! '+convert(nvarchar(20),ListPrice) as ProductList from Production.Product where ListPrice in (100,120)

--11
select rowguid ,Name, SalesPersonID, Demographics into store_Archive 
from Sales.Store

select rowguid ,Name, SalesPersonID, Demographics from store_Archive	 


drop table store_Archive

select rowguid ,Name, SalesPersonID, Demographics into store_Archive 
from Sales.Store where 1!=1

--12
select format(getdate(),'MM/dd/yy')as today
union 
select format(getdate(),'dddd')
union 
select format(getdate(),'MM')
union 
select format(getdate(),'yy')
union 
select format(getdate(),'dddd-MM-yyyy') 