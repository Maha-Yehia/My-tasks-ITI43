--01
select count(st_id)
from student
where St_Age is not null 

--02
select distinct ins_name 
from Instructor

--03
select ISNULL(s.st_id, ' ' ) as [Student ID] ,
ISNULL(s.St_Fname+' '+s.St_Lname , ' ' )  as [Student Full Name] , 
ISNULL(d.dept_name , ' ' )  as [Department name]
from Student s , department d 
where s.Dept_Id = d.Dept_Id 

--04
select i.Ins_Name , d.Dept_Name 
from Department d right outer join Instructor i 
on d.Dept_Id = i.Dept_Id

--05
select  (s.St_Fname+' '+s.St_Lname) as [Student Full Name] ,c.Crs_Name 
from Student s , Course c , Stud_Course st
where st.Crs_Id=c.Crs_Id and st.St_Id=s.St_Id and st.Grade is not null 

--06
select count(crs_id) , t.Top_Name
from Course c , Topic t 
where c.Top_Id = t.Top_Id 
group by t.Top_Name

--07
--- all salaries are null values
select max(salary) as MaxSalary , min(salary)as MinSalary
from Instructor 

--08
--- all salaries are null values
select * 
from Instructor 
where Salary < (select avg(Salary) from Instructor )
--09
select	d.Dept_Name 
from Department d , Instructor i 
where i.Dept_Id = d.Dept_Id /*and i.Salary =(select min(Salary) from Instructor )*/
group by d.Dept_Name

--10
select top(2) *
from Instructor 
order by salary desc  

--11
select Ins_Name , salary = coalesce (NULL , 'instructor bonus' )
from Instructor 

--12
select avg(salary)
from Instructor

--13
select s.St_Fname , sp.*
from Student s , Student sp
where s.St_super = sp.St_Id 

--14
Select *
from (Select * , row_number()  over(partition  by dept_id order by salary desc)as RN
from instructor) AS newTable
where RN<=2 

--15
Select *
from (Select * , row_number()  over(partition  by dept_id order by newid() )as RN
from Student) AS newTable
where RN=1




