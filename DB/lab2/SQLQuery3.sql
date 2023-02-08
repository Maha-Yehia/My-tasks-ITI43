use Company_SD

---01
select *  
from Employee

---02
select Fname, lname, Salary , Dno
from Employee

---03
select pname , plocation , dnum 
from Project

---04 
select	(Fname+' '+Lname) as full_Name  , Salary*12*0.1 as annual_commission
from Employee

---05
select ssn,(Fname+' '+Lname) as full_Name
from Employee
where salary>1000 

---06
select ssn,(Fname+' '+Lname) as full_Name
from Employee
where salary*12>10000

---07
select (Fname+' '+Lname) as full_Name , Salary
from Employee
where Sex = 'f'

---08
select Dnum , Dname 
from Departments 
where MGRSSN = 968574

---09
select Pnumber , Pname , plocation 
from Project
where Dnum = 10 

