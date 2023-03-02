--01 a 
select d.Dependent_name 
from Dependent d , Employee e 
where d.sex = 'f' and e.sex = 'f' and d.ESSN=e.SSN 

--01 b 
select d.Dependent_name 
from Dependent d , Employee e 
where d.sex = 'm' and e.sex = 'm' and d.ESSN=e.SSN 

--01 
select d.Dependent_name 
from Dependent d , Employee e 
where d.sex = 'f' and e.sex = 'f' and d.ESSN=e.SSN 
union all 
select d.Dependent_name 
from Dependent d , Employee e 
where d.sex = 'm' and e.sex = 'm' and d.ESSN=e.SSN 


--02 
select p.pname , sum (w.hours )
from Project p , Works_for w
where p.Pnumber = w.Pno
group by p.Pname

--03

select d.*
from Employee e , Departments d 
where e.Dno = d.Dnum and e.SSN = (select min(ssn) from Employee)


--04
select d.dname , max(e.salary)as Max_Salary , min(e.salary) as Min_Salary, avg(e.salary) as Avg_Salary
from Departments d join Employee e
on d.Dnum = e.Dno
group by d.Dname

--05
select (e.Fname+' '+e.Lname) as Manager_Name  
from Departments d , Employee e 
where d.MGRSSN=e.SSN 
and e.SSn not in 
(select e.ssn  
from  Employee e , Dependent p
where  p.essn = e.ssn)

--06
select avg(e.salary) , d.Dnum , d.Dname , count(e.SSN) as numberOfEmployees
from Employee e inner join Departments d 
on e.Dno = d.Dnum 
group by d.Dnum , d.Dname 
having avg(e.salary)  < (select AVG(salary) from Employee) 


--07 
select (e.Fname+' '+e.Lname) as Employee_Name , p.Pname , p.Dnum 
from Employee e , Project p , Works_for w 
where w.ESSn = e.SSN and p.Pnumber = w.Pno 
order by p.Dnum , e.Fname , e.Lname

--08

--max salary
select max(salary) 
from Employee
union all 
--second max salary
select max(salary) 
from Employee
where Salary not in (select max(salary) from Employee)

--09
select (e.Fname+' '+e.Lname) as Employee_Name 
from Employee e , Dependent d 
where (e.Fname+' '+e.Lname) = d.Dependent_name  

--10
/*select e.ssn , (e.Fname+' '+e.Lname) as Employee_Name 
from Employee e 
where exists (select d.essn 
from Employee e , Dependent d 
where e.ssn = d.essn )*/


select e.ssn , (e.Fname+' '+e.Lname) as Employee_Name 
from Employee e 
where exists (select Dependent_name
from  Dependent d 
where ssn = essn )

--11
insert into Departments 
values ('DEPT IT' , 100,112233,'01-11-2006')

select * 
from Departments 

--12
update Departments
set mgrssn = 102672  
where dnum = 20 

update Departments
set mgrssn = 968574
where Dnum = 100 

update Employee
set Dno = 20 
where ssn = 102672 

update Employee
set Dno = 100
where ssn = 968574

update employee 
set Superssn = 102672 
where ssn = 102660 

--13

delete Dependent
from Dependent
where essn = 223344

update Departments
set MGRSSN = 102672
where MGRSSN = 223344

update Employee
set Superssn = 102672
where Superssn = 223344

update Works_for
set essn = 102672
where essn = 223344


delete employee
from Employee 
where ssn =223344

--14
update Employee	
set salary = Salary*1.3
from Employee e , Project p , Works_for w 
where p.Pname = 'Al Rabwah' and w.Pno = p.Pnumber and e.SSN=w.ESSn 

