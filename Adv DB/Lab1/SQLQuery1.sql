create rule r1 as @value in ('NY','DS','KW') 
create default def1 as 'NY'

sp_addtype loc , 'nchar(2)'  
sp_bindrule r1,loc
sp_bindefault def1,loc 


create table Department
(
DeptNo nchar(2) Primary Key,
DeptName nvarchar(25) , 
Location loc 
)

insert into Department 
values ('d1','Research','ny') , 
('d2','Accounting','ds') ,
('d3','Markiting','KW') ; 


--incorrect values 
insert into Department 
values ('d1','Research','My') 

create table Employee
(
EmpNo  int Primary Key,
EmpFname nvarchar(20) not null, 
EmpLname nvarchar(20) not null, 
DeptNo nchar(2) , 
Salary int 
)
create rule r2 as @x <6000 

sp_bindrule r2, 'employee.Salary' 

alter table Employee add constraint c1 unique(Salary) 
alter table Employee add constraint c2 foreign key(DeptNo) references Department(DeptNo)

insert into Employee
values (25348,'Mathew','Smith','d3',2500),
(10102,'Ann','Jones','d3',3000),
(18316,'John','Barrimore','d1',2400),
(29346,'James','James','d2',2800),
(9031,'Lisa','Bertoni','d2',4000)

---Testing Referential Integrity

--1 
---ProjectNo should not equal null and we didn't have its value so the statment will not run 
insert into works_on (EmpNo)
values(11111)

--2 
----The UPDATE statement conflicted with the FOREIGN KEY not run 
update works_on 
set EmpNo = 11111 
where empNo = 10102  

--3
---The UPDATE statement conflicted with the REFERENCE constraint "FK_Works_on_Employee" not run 
update employee
set EmpNo =  22222 
where empNo = 10102  

--4
----(2 rows affected)\ must delete from works on first 
delete 
from works_on
where EmpNo = 10102 

----(1 rows affected)
delete 
from Employee
where EmpNo = 10102 

--Table modification
--1 
alter table employee add TelephoneNumber   int 

--2 
alter table employee drop column TelephoneNumber

------------------------------------------------

--2
create schema Company
create schema Human_Resource 
alter schema Company transfer Department 
alter schema Human_Resource  transfer employee 

--3
sp_helpconstraint 'Human_Resource.Employee'

--4 
 create synonym emp for Human_Resource.Employee
	Select * from Employee --- not run as we not mentioned the schema name 
	Select * from [Human_Resource].Employee -- run 
	Select * from Emp --run 
	Select * from [Human_Resource].Emp-- not run as we not mentioned the wrong schema name 

--5 
--- we have deleted this employee 
update Company.project  
set budget = 1.1*budget 
from works_on w , Company.project p
where w.projectNo = p.projectNo and empNo = 10102 and e.job='Manager'

--6 
update Company.department
set deptName= 'sales'
from  Company.department d , Human_Resource.Employee e
where  d.deptNo = e.deptno and e.empfname = 'James'

--7 
update works_on 
set enter_date = '2007-12-12'
from works_on w ,  Human_Resource.Employee e , Company.department d 
where w.empNo = e.empNo and w.projectno = 'p1' and d.deptno = e.deptno and d.deptname = 'sales'

--8 
delete from works_on 
from Human_Resource.Employee e , Company.department d 
where e.deptno = d.deptno and d.location = 'kw' 


