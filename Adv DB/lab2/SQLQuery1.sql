--01
alter function getMonth(@x date)
returns nvarchar(20)
begin
declare @m nvarchar(20)
select @m=format(@x,'MMMM')
return @m	
end 
select dbo.getMonth('12-26-2022')

--02 
alter function getInt(@num1 int , @num2 int)
returns @t table (rangeVals int)
as 
begin 
	while @num1 <@num2-1
	begin 
	if @num1 = @num2
	break
	else
	select @num1+= 1
	insert  @t 
	select @num1
	end
	return
end 
select * from dbo.getInt(1,10)

--03 
alter function getStuDep(@stId int)
returns table
as
return 
 (
	select St_Id,St_Fname+ ' ' +St_Lname as FullName ,Dept_Name
	from dbo.Student
	inner join Department on Student.Dept_Id= Department.Dept_Id
	where Student.St_Id = @stId
)	 
select * from dbo.getStuDep(8)

--04
ALTER function nameNull(@stid int)
returns varchar(50)
as
begin 
	declare @msg nvarchar(50)
	declare @checker1 nvarchar(50)
	declare @checker2 nvarchar(50)
	select @checker1 = St_Fname from Student where St_Id=@stid
	select @checker2 = St_Lname from Student where St_Id=@stid
	
	if (@checker1 is NULL AND @checker2 is NULL)
	select @msg = 'First name & last name are null'
	else if (@checker1 is NULL AND @checker2 is NOT NULL)
	select @msg = 'First name is null'
	else if (@checker1 is NOT NULL AND @checker2 is NULL)
	select @msg = 'last name is  null'
	else 
	select @msg= 'First name & last name are not null'
	return @msg
end
select  dbo.nameNull(1)
select  dbo.nameNull(14)
select  dbo.nameNull(16)
select  dbo.nameNull(13)


--05 
alter function mgr(@m int)
returns table 
as 
return (
	select Dept_Name, Ins_Name as 'mgrName', d.Manager_hiredate
	from Department d , Instructor i 
	where d.Dept_Manager = i.Ins_Id and d.Dept_Manager =@m 
)
select * from mgr(1)

--06
create function studName(@name varchar(50))
returns @t table(sname varchar(50) )
as
begin
    if @name='first name'
		insert @t
		select isNull(st_fname , ' ' ) from student
    else if @name='last name'
		insert @t select isNull(St_Lname , ' ' ) from student
     else if @name='full name'
		insert @t select isNull(st_fname , ' ' )+' '+isNull(St_Lname , ' ')  from student
   return 
end

	select * from  studName('fullname')
	select * from  studName('first name')
	select * from  studName('last name')


--07
select St_Id, substring(St_Fname , 1 , len(St_Fname)-1)  from Student

--08
---(24 rows affected)
delete Stud_Course
from Stud_Course c , Department d , student s 
where s.dept_id = d.Dept_Id and c.St_Id = s.st_id and d.Dept_Name = 'sd' 

--bonus 
--01



--02
declare @x int=3000
while @x<6000
begin
insert into Student(St_Id,St_Fname,St_Lname)
values(@x,'jane','smith')
set @x = @x+1 
end 
select count(*)from student










