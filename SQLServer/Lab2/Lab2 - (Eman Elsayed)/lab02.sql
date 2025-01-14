
use  Company_SD

select * from employee

select Fname , Lname , Salary , Dno from Employee

select Pname , Plocation , Dnum from Project

select fname+' '+Lname as fullname , (salary*12)*.1 as 'ANNUAL COMM'  from Employee 

select fname+' '+Lname as name , SSN  from Employee where Salary >1000

select fname+' '+Lname as name , SSN  from Employee where Salary *12 >10000

select fname+' '+Lname as name , salary from Employee where sex='F'

select Dnum , Dname from Departments where MGRSSN = 968574

select Pnumber , Pname , Plocation from Project where Dnum=10