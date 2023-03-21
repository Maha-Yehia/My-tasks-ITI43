--01
create proc showStud 
as 
select count(St_Id) from dbo.Student 
group by Dept_id 

--02---
USE Company_SD
create proc checkEmp
as
if(( select count(ESSN) as CountEmp from Works_for where Pno=1 >=3)
select 'The number of employees in the project p1 is 3 or more'
else 
begin
select 'The following employees work for the project p1'
select Fname , Lname from Works_for INNER JOIN Employee 
ON Employee.SSN = Works_for.ESSn INNER JOIN Project
ON Project.Pnumber=Works_for.Pno where Project.Pnumber=1
end

---03

create proc proced2 @oldemp int ,@newemp int ,@pno int
as
update Works_for
set ESSn=@newemp 
where essn=@oldemp AND Pno=@pno

--04
use sd
create table audittable(
projectno nvarchar(10) ,
username varchar(50),
ModifiedDate  date,
Budget_Old int,
Budget_New int
)


create trigger t2
on company.project
after update
as
if update(budget)
begin
declare @old int
declare @new int
declare @pn nvarchar(10)
select @old= budget from deleted
select @pn= ProjectNo from inserted
select @new= budget from inserted
insert into audittable 
values (@pn,Suser_name(),GETDATE(),@old,@new)
end

update company.Project 
set budget*= 1.1

select * from audittable

--05
create trigger t5
on Department
instead of insert 
as
select ' you cant insert a new record in that table'

--06
create trigger t6
on Employee
after insert 
as 
if (format(getdate(),'MMMM')='March')
rollback

--07--
use ITI
create table audit(server_name varchar(50),Date date,note varchar(50))
create trigger t7
on Student
after insert
as 
declare @a varchar(100)
set @a =(select SUSER_NAME()+'Insert Student with key= ' +CONVERT(varchar(10),(select st_id from inserted)) + 'in table student')
insert into audit
values (SUSER_NAME(),GETDATE(),@a)

insert into Student
values (7500,'maha','ekram','cairo',25,10,1)
select * from audit 

--08
create  trigger t8
on Student
after delete
as 
declare @a int
select @a=St_Id from deleted

insert into
audit values (SUSER_NAME(),GETDATE(),@@SERVERNAME+' Insert Student with key'+@a)

--09
--a
select * from human_resource.employee 
for xml raw ('EmpData') , elements 

--b
select * from human_resource.employee 
for xml raw ('EmpData') 

--10
--a
select Dept_Name  , Ins_Name
from Department d , Instructor i 
where i.Dept_Id = d.Dept_Id 
for xml auto ,elements 
--b 
select Dept_Name  , Ins_Name
from Department d , Instructor i 
where i.Dept_Id = d.Dept_Id 
for xml path ,elements 

--11--

declare @docs xml ='<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'


declare @hdocs int


Exec sp_xml_preparedocument @hdocs output, @docs



select * 
FROM OPENXML (@hdocs, '//customer')  
WITH (FirstName varchar(50) '@FirstName',
Zipcode int '@Zipcode', 
customer_oreder varchar(50)'order' , 
	  orderId int 'order/@ID'
	  )

Exec sp_xml_removedocument @hdocs


