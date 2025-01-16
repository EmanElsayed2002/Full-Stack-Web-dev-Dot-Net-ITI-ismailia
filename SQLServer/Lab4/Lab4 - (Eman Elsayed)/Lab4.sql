use Company_SD

select * from Employee
select * from Dependent
select * from Departments
--1
select D.Dependent_name , D.Sex
from Dependent D join Employee E
on D.ESSN = E.SSN and D.Sex = E.Sex and D.Sex = 'F'
union all
select D.Dependent_name , D.Sex
from Dependent D join Employee E
on D.ESSN = E.SSN and D.Sex = E.Sex and D.Sex = 'M'


--2
select Pname , sum(Works_for.Hours) as HoursPerWeek
from Project join Works_for
on Project.Pnumber = Works_for.Pno
group by Pname

--3
select D.* , E.SSN
from Departments D join Employee E
on D.Dnum = E.Dno
where E.SSN = (select min(SSN) from Employee)

--4
select D.Dname , Max(Salary) as MaxSalary, Min(Salary) as MinSalary ,Avg(Salary) as AvgSalary 
from Departments D join Employee E
on D.Dnum = E.Dno
group by D.Dname 

--5
--select * from Dependent
--select * from Departments
--select * from Employee
--select * from Departments
select Lname as name , SSN 
FROM Employee E inner join Departments D
on E.SSN = D.MGRSSN  and SSN not in (select ESSN from Dependent)

--6
select Dnum,Dname, count(E.SSN) as NoOfEmployee 
from Departments D  join Employee E
on D.Dnum = E.Dno
group by Dname,Dnum
having avg(Salary) < (select avg(salary) from Employee)

--7
select Fname +' '+Lname as fullname , Pname , d.Dnum 
from Employee E  join Works_for W
on E.SSN = W.ESSN  
join Project P 
on W.Pno = P.Pnumber  
join Departments D
on D.Dnum = P.Dnum
order by D.Dnum , Lname,Fname

--8
--select * from Employee
select max(salary) from Employee
union
select max(Salary) from Employee
where Salary not in (select max(Salary) from Employee )

--9
select * from Dependent
select * from Employee
select distinct Fname +' '+Lname as Fullname 
from Employee emp join Dependent D 
on emp.SSN = D.ESSN  
where d.Dependent_name like '%'+Fname +' '+Lname+'%'

--10
select  SSN ,Fname +' '+Lname as name , SSN 
FROM Employee a 
where  exists (select * from Dependent where a.SSN = Dependent.ESSN)


--11
insert into Departments values('DEPT IT',100,112233,'1-11-2006')


--12
update Departments
set MGRSSN = 968574,[MGRStart Date]=GETDATE()
where Dnum =100

update Departments 
set MGRSSN = 102672,[MGRStart Date]=GETDATE()
where Dnum =20

update Employee
set Dno = 20
where SSN=102672

update Employee
set Superssn = 102672
where SSN=102660

--13
delete from Dependent 
where ESSN=223344

update Departments
set MGRSSN = 102672
where MGRSSN =223344

update Employee
set Superssn = 102672
where Superssn =223344

update Works_for
set ESSn = 102672
where ESSn =223344

delete from Employee 
where SSN=223344

--14
update Employee 
set Salary += Salary*.3
from Employee e inner join Works_for w 
on e.SSN= w.ESSn inner join Project p 
on p.Pnumber = w.Pno and p.Pname='Al Rabwah'






