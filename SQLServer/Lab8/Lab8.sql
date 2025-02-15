use iti
select * from Student
select * from Department
--1
create proc numberOfStudentPerdepartment
as 
select  S.Dept_Id,count(*) as 'No of student' from student S join Department D on S.Dept_Id = D.Dept_Id
group by S.Dept_Id 

numberOfStudentPerdepartment

--2
Use Company_SD
Create procedure Emp_Numbers   @pname varchar(20),@num int=null 
	as
		select  @num = count(ESSn)  from Project 
		inner join Works_for on Project.Pnumber = Works_for.Pno  and pname =@pname
		inner join Employee on Employee.SSN = Works_for.ESSn
			if @num > 3
				select 'The number of employees in the project '+@pname+' is 3 or more'
			else  
				 select 'The following employees work for the project '+@pname
				 union all 
				 select concat(fname ,' ', lname)  from Project 
					inner join Works_for on Project.Pnumber = Works_for.Pno  and pname =@pname
					inner join Employee on Employee.SSN = Works_for.ESSn

Emp_Numbers 'Al Rowad'

--3
Create procedure update_WorksFor  @old int , @new int , @pnum int
	as
	begin try
		update Works_for 
		set ESSn = @new
			where ESSn = @old and Pno = @pnum
	end try
	begin catch
		select @@error
	end catch

update_WorksFor	 1078672 , 66557 ,200

--4
Create Table Audit
(
	ProjectNo int not null ,
	UserName nvarchar(50) not null  ,
	ModifiedDate date  ,
	Budget_Old money not null,
	Budget_New money not null
)

--5
Create Trigger Update_Audit
on Project
after update
	as 
		if update(budget)
		begin
		declare @old int,@new int , @pnum int
			select @old=budget from deleted
			select @new=budget from inserted
			select @pnum=Pnumber from inserted
		insert into Audit
			values(@pnum,suser_name(),getdate(),@old,@new)
		end


--6
Use ITI
Create Trigger Prevent_insert
on Department
instead of insert
	as
		select 'Insert Not allowed'

--7
Use Company_SD
Create Trigger Prevent_InsertEmp
on Employee
after insert
	as
		if format(getdate(),'MM')='March'
			rollback

Create Table Student_Audit
(
	UserName nvarchar(50) not null  ,
	ModifiedDate date  ,
	Note nvarchar(100) ,
)

Create Trigger Update_Audit
on Student
after insert
	as 
		insert into Student_Audit
			values(suser_name(),getdate(),suser_name()+'Insert New Row with Key = ['+convert(nvarchar(20),(select St_Id from inserted))+'] in table Student')


Create Trigger Student_Delete
on Student 
instead of Delete
	as
		insert into Student_Audit
			values(suser_name(),getdate(),suser_name()+'Try to delete Row with Key = ['+convert(nvarchar(20),(select St_Id from deleted))+'] in table Student')
		

