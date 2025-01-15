use Company_SD

select * from Departments
select * from Employee
--1
select Dnum , Dname , SSN , Fname +' '+Lname as name
from Departments join Employee 
on Employee.SSN = Departments.MGRSSN
--2
select Pname, Dname 
from Project P join Departments  D
on D.Dnum = P.Dnum
--3
select  Fname +' '+Lname as fullname, D.* 
from Dependent D right join Employee E
on E.SSN = D.ESSN
--4
select Pnumber , Pname , Plocation 
from Project 
where city in ('Cairo','Alex')
--5
select * 
from Project 
where Pname like 'a%'
--6
select * 
from Employee 
where Dno = 30 and Salary between 1000 and 2000
--
select * from Works_for

--7
select Fname +' '+Lname as fullname 
from Employee inner join Works_for 
on Employee.SSN = Works_for.ESSn and Hours >=10 
inner join Project 
on Project.Pnumber = Works_for.Pno and Project.Pname ='AL Rabwah'
--8
SELECT a.Fname +' '+a.Lname as name FROM Employee a , Employee b
where a.Superssn = b.SSN
AND b.Fname +' '+b.Lname ='Kamel Mohamed'
--9
select Fname +' '+Lname as fullname , Pname 
from Employee  join Works_for 
on Employee.SSN = Works_for.ESSn 
join Project on
Project.Pnumber = Works_for.Pno 
order by Pname
--10
select Pnumber, Dname , Lname, Address,Bdate 
from Project join Departments 
on Project.Dnum = Departments.Dnum and city = 'Cairo' 
join Employee on Employee.SSN = Departments.MGRSSN
--11
SELECT  a.* FROM Employee a , Departments b
where a.SSN = b.MGRSSN
--12
select Employee.* ,Dependent.* 
from Dependent right join Employee 
on Employee.SSN = Dependent.ESSN
--13
insert into Employee  
(Fname,Lname,SSN,Bdate,Address,Sex,Salary,Superssn,Dno)
VALUES('Eman','Elsayed',102672,'09/21/2002','Ismailia','F',3000,112233,30)
--14
insert into Employee  
(Fname,Lname,SSN,Bdate,Address,Sex,Dno)
VALUES('Eman','Sameh',102660,'03/05/1997','Ain Shams','F',30)
--15
update Employee
set salary += salary * .2
where SSN =102672



