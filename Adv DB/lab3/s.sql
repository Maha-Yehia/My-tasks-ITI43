--part 1 
--01 

create view v4
as 
select (St_fname+' '+St_Lname) as fullName, Crs_Name
from Student  s , Stud_Course sc , Course c 
where s.St_Id=sc.St_Id and sc.Crs_Id =c.crs_id and grade>50 

select * from v4

--02 
alter view V2 
with encryption 
as
select Ins_Name, Top_name	
from Instructor i INNER JOIN  Department d
on d.Dept_Manager= i.Ins_Id INNER JOIN Ins_Course ic
ON i.Ins_Id = Ic.Ins_Id INNER JOIN  Course c 
ON Ic.Crs_Id= C.Crs_Id INNER JOIN Topic t
ON c.Top_Id = T.Top_Id 

select * from v2

--03 
CREATE VIEW V3 
as
select Ins_Name , Dept_Name 
from Instructor inner join Department
ON Instructor.Dept_Id = Department.Dept_Id
where Dept_Name = 'SD' OR Dept_Name= 'Java'

select * from v3

--04
alter view V1 
as
select  * from Student
where St_Address = 'Cairo' OR St_Address = 'Alex'
with check option 

--check 
update v1
set St_Address='tanta'
where St_Address = 'alex'

--05
create view v5
as
select ProjectName ,count(EmpNo) as NumberOfEmployee
from company.Project P inner join works_on W
on P.ProjectNo=W.ProjectNo
group by ProjectName

select * from v5

--06
--the query won't run because there are a clustered index on PK
create clustered index  I1
on Department(Manager_hiredate)

--07
--won't run because of the duplicated old values 
create unique nonclustered index I2 on student(St_Age) 

--08 
create table daily_trans(id int , amount int )
create table last_trans(id int , amount int )
insert into daily_trans values (1, 1000) , (2,2000), (3,1000)
insert into last_trans values (1, 4000) , (4,2000), (2,10000)

merge into last_trans as t using daily_trans as d
ON t.id = d.id
	when matched THEN
	update set t.amount= d.amount

	when not matched  THEN 
	insert values (d.id,d.amount); 

-- part 2 
--01 
create view v_clerk 
as
select EmpNo,ProjectNo,Enter_Date
from Works_on
where job = 'clerk'

select * from v_clerk

--02
alter view v_without_budget 
as 
SELECT * 
from Company.Project 
where Budget is null

select * from v_without_budget

--03
create view v_count
as
select ProjectName,COUNT(job) as NumberOfJobs
from Company.Project P  , works_on W
where P.ProjectNo=W.ProjectNo
group by ProjectName

select * from v_count

--04
alter view v_project_p2
as
select count(EmpNo) as NumberOfProjects
from v_clerk
where ProjectNo='P2'

select * from v_project_p2

--05
alter view v_without_budget
as
select *
from Company.Project
where ProjectNo in ('P1','P2')

select * from v_without_budget

--06
drop view v_clerk
drop view v_count
--07
create view V6 
as 
select EmpNo,EmpLname,deptNo  
from Human_Resource.Employee
where deptNo = 'd2'

select * from v6 

--08
select emplname 
from v6 
where EmpLname like '%j%'

--09
create view v_dept 
as 
select deptNo , deptName
from Company.Department

select * from v_dept

--10 
--inserted into table department  
insert into v_dept 
values ('d4' , 'Development')

--11
create view v_2006_check 
as 
select empNo,projectNo,enter_Date
from Works_on
where Enter_Date>'2006-1-1' and Enter_Date<'2006-12-31'

select * from v_2006_check