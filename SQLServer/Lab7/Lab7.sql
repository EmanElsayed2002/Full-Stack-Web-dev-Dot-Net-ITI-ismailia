use iti

select * from Stud_Course
select * from Course
select * from Department
select * from Instructor
select * from Topic
--1
create view displayStudentGradeMoreThan50
as 
select St_Fname + ' ' + St_Lname as FullName , Course.Crs_Name  from Student join Stud_Course
on Student.St_Id = Stud_Course.St_Id join Course on Course.Crs_Id = Stud_Course.Crs_Id 
and Stud_Course.Grade > 50

--2
create view DisplayManagerDetails
with encryption
as
select Ins.Ins_Name as ManagerName , Top_Name as Topic from Department as Dept 
		inner join  Instructor as Ins on Dept.Dept_Manager = ins.Ins_Id 
		inner join Ins_Course on ins.Ins_Id=Ins_Course.Ins_Id
		inner join Course on Ins_Course.Crs_Id = Course.Crs_Id
		inner join Topic on Topic.Top_Id = Course.Top_Id
WITH CHECK OPTION;

--3
Create view View_InsDeptDetails
as
select Ins_Name as InstuctorName , Dept_Name as DepartmentName from Instructor 
		inner join Department on Department.Dept_Id=Instructor.Dept_Id and Dept_Name in ('SD','Java')


--4
select * from Student
create view V1 as
select * from Student
where St_Address in ('cairo' , 'alex')
with check option


--5
Use Company_SD
select * from  Employee
select * from Project

Create View View_ProjectDetails
as
select Pname as ProjectName , count(ESSn) as NumOFEmps from Project 
		inner join Works_for on Project.Pnumber = Works_for.Pno 
		inner join Employee on Employee.SSN = Works_for.ESSn
			group by Pname 


--6

Create schema [Human Resource]
Alter schema [Human Resource] transfer Employee

--7
Create nonclustered index  mgr_hiredate on Department(Manager_hiredate)

--8
Create unique index UniqueAge on Student(st_age) 

--9
select * from [Human Resource].Employee
declare c1 cursor
for select Employee.Salary from [Human Resource].Employee
for update

declare @sal int 
open c1
fetch c1 into @sal
while @@FETCH_STATUS = 0
	begin
	if @sal < 3000
	update [Human Resource].Employee
	set Salary += .1 * @sal
	where current of c1
	else if @sal >= 3000
	update [Human Resource].Employee
	set Salary += .2 * @sal
	where current of  c1
	fetch c1 into @sal
	end
close c1
deallocate c1



use iti
declare c2 cursor 
for select D.Dept_Name , I.Ins_Name from Department D join Instructor I on I.Dept_Id = D.Dept_Id
for read only 

declare @dept_name varchar(20) , @ins_name varchar(20)
open c2
fetch c2 into @dept_name , @ins_name
while @@FETCH_STATUS = 0
	begin
	select @dept_name , @ins_name
	fetch c2 into @dept_name , @ins_name
	end


declare c8 cursor 
for select I.Ins_Name from Department D join Instructor I on I.Dept_Id = D.Dept_Id
for read only 

declare  @ins_name2 nvarchar(100) , @temp varchar(10)
open c8
fetch c8 into  @temp
while @@FETCH_STATUS = 0
	begin
	set @ins_name2=concat(@ins_name2,' , ',@temp)
	
	fetch c8 into  @temp
	end
close c8
deallocate c8
select @ins_name2










