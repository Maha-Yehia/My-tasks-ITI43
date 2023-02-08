--01 
select s.SalesOrderID , s.ShipDate 
from sales.SalesOrderHeader  s 
where s.ShipDate between '07-28-2002' and '07-29-2014'

--02
select p.ProductID , p.Name 
from Production.Product p 
where p.StandardCost<110 

--03
select p.ProductID , p.Name 
from Production.Product p 
where p.Weight is null 

--04
select p.ProductID
from Production.Product p 
where p.Color in ('Silver', 'Black',  'Red') 

--05
select p.Name
from Production.Product p 
where p.name like 'b%'

--06
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select p.Description
from Production.ProductDescription p 
where p.Description like '%[_]%'

--07
select sum(s.totaldue) as [total due] , s.OrderDate
from Sales.SalesOrderHeader s 
where s.OrderDate between '7/1/2001'  and'7/31/2014'
group by s.OrderDate 

--08
	select distinct e.HireDate
	from HumanResources.Employee e 

--09
select avg(distinct p.ListPrice)
from Production.Product p 

--10
select p.Name as [the product name is only !] , p.ListPrice as [List price]
from Production.Product p 
where p.ListPrice between 100 and 120 
order by p.ListPrice asc 

--11 (a)
select s.rowguid , s.Name , s.SalesPersonID ,s.Demographics into [store_Archive] 
from Sales.Store s 
--701 rows 

--11(b)
select s.rowguid , s.Name , s.SalesPersonID ,s.Demographics into [store_Archive 2] 
from Sales.Store s 
where 1=2 


--12
select GETDATE ()
union all 
select cast (GETDATE () as datetime)
union all 
select convert ( smalldatetime  , GETDATE ())


