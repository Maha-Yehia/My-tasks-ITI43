
--01
USE Company_Sd
declare cur cursor 
	for select [SSN], [Fname], salary from dbo.Employee
	for update 

declare @id int, @name nvarchar(50), @sal int
open cur
fetch cur INTO @id, @name, @sal --LIKE i=0 
begin 
	while @@FETCH_STATUS = 0
	begin 
		if @sal < 3000
			BEGIN  
			update Employee set Salary = @sal* 1.1 where current of cur
			fetch cur INTO @id,@name,@sal --LIKE i++
			END 
		if @Sal >= 3000
			BEGIN 
			Update Employee Set Salary = @sal * 1.2 WHERE CURRENT OF cur
			fetch cur INTO @id,@name,@sal -- LIKE i++
			END
	end
end 
close cur 
deallocate cur

--02
use ITI 
declare cur2 cursor for 
	select [Dept_Name] ,   [Ins_Name]
	from Department INNER JOIN Instructor 
	ON Department.Dept_Manager = Instructor.Ins_Id 
	for read only

declare @deptName nvarchar(50), @mgrName nvarchar(50) 
open cur2
fetch cur2 into @deptName , @mgrName 
BEGIN 
	while @@FETCH_STATUS =0
	BEGIN 
		select @deptName , @mgrName 
		fetch cur2 into @deptName , @mgrName 
	END
END
close cur2 
deallocate cur2

--03
declare cur3 cursor for 
	select St_Fname from Student where St_Fname IS NOT NULL
	for read only
	declare @fname nvarchar(50) =' '
	declare @fullname nvarchar(200) = ' '  
	open cur3
	fetch cur3 into @fname
BEGIN 
		while @@FETCH_STATUS=0
		begin
		
		-- select @fname =st_fname from Student
		set @fullname = @fullname +  @fname + ' , '

		fetch cur3 into @fname
		end
		select @fullname
end 
close cur3 
deallocate cur3

--04
---SD--tasks--backup--full or defferential or transacional

--05
---Done 

--06
---tasks--generate scripts 

--07
 create table test1(id int)
 Create SEQUENCE MySequence
START WITH 1
INCREMENT BY 1
MinValue 1
MaxValue 10
no CYCLE; 
insert into test values(Next value for mysequence)



