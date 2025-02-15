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