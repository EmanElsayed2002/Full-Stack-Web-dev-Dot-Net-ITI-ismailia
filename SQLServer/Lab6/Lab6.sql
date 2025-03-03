use iti 

--1
create function GetMonthName(@date date)
returns varchar(20)
begin
	declare @month varchar(20)
	select @month = DATENAME(Month ,@date)
	return @month
	end

select dbo.GetMonthName('02-15-2025')


--2
create function GetBetweenThem(@st int , @end int)
returns @t table(valuesBetweenVariable int)
as
	begin
		set @st += 1
		while @st < @end
			begin
			
			insert into @t 
			select @st
			set @st += 1
			end
			return
	end

select valuesBetweenVariable from GetBetweenThem(1 , 10)

--3
create function GetStudentDetails(@stId int)
returns table 
return(
  select St_Fname + ' ' + St_Lname as FullName , Dept_Id   from Student
  where St_Id = @stId
)


select * from GetStudentDetails(7)

--4
create function GetMessage(@st_id int)
returns varchar(50)
as 
	begin
	declare @firstName varchar(50) , @secondName varchar(50) , @message varchar(50)
	select @firstName= St_Fname , @secondName=St_Lname  from Student
	where St_Id = @st_id
	if  @firstName = Null and @secondName = Null
	select @message='First name & last name are null'	
	else if  @firstName = Null 
	select @message='first name is null'
	else if  @secondName = Null 
	select @message='second name is null'
	else 
	select @message='First name & last name are not null'
	return @message
	end

select dbo.GetMessage(7)

select * from Department
--5
create function ManagerDetails(@mgrId int)
returns table 
return(
    select Dept_Name , Instructor.Ins_Name ,Manager_hiredate  from Department
	join Instructor on Department.Dept_Id = Instructor.Dept_Id and Department.Dept_Id = @mgrId
)

select * from ManagerDetails(40)

--6
create function (@format varchar(50))
returns @t table(Studentname varchar(20))
as 
	begin 
		if @format = 'first name' 
		insert into @t
		select St_Fname from Student
		else if @format = 'last name' 
		insert into @tGetNamesOfStudent
		select St_Lname from Student
		else 
		insert into @t
		select St_Fname + ' '+ St_Lname from Student
		return 
	end 

select * from GetNamesOfStudent('first name')
select * from GetNamesOfStudent('last name')
select * from GetNamesOfStudent('full name')

--7
select St_Id , SUBSTRING(St_Fname , 1 , len(st_fname) - 1) from Student 

--8
delete from Department where Dept_Name = 'SD'

--9

merge into LastTransactions as L
using DAilyTransaction as  D
on L.transactionID = D.transactionID
when matched then 
update 
set L.amount = D.amount
when not matched then 
insert 
values(D.TransactionID , D.amount); 

--10

