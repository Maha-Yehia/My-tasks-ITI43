create schema newSCH 
ALTER SCHEMA newSCH transfer student
ALTER SCHEMA newSCH transfer Course

select *from newSCH.Student 
--(1 row affected)
insert into newSCH.Student 
values(15,'maha' , 'yehia' , 'cairo' , 25 , 10 , 1) 

--The UPDATE permission was denied on the object 'Student', database 'ITI', schema 'newSCH'.
update newSCH.Student 
set st_fname = 'hoda' 
where st_fname = 'maha' 