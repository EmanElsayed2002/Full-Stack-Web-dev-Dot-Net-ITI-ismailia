using LinqLab02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab02.Repo
{
    public class GetData
    {
        public static List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Ahmed", Salary=1000, Age = 30, DeptId = 1 },

                new Employee { Id = 2, Name = "Mohamed El-Sayed",Salary=2000, Age = 28, DeptId = 2 },
                new Employee { Id = 3, Name = "Fatma Zahra",Salary=3000, Age = 35, DeptId = 3 },
                new Employee { Id = 4, Name = "Khaled Mahmoud",Salary=4000, Age = 40, DeptId = 4 },
                new Employee { Id = 5, Name = "Salma Ali",Salary=5000, Age = 27, DeptId = 5 },
                new Employee { Id = 6, Name = "Yasmin Hassan",Salary=6000, Age = 32, DeptId = 1 },
                new Employee { Id = 7, Name = "Omar Abdelaziz",Salary=7000, Age = 29, DeptId = 3 },
                new Employee { Id = 8, Name = "Mahmoud Hassan",Salary=8000, Age = 45, DeptId = 2 },
                new Employee { Id = 9, Name = "Norhan Mohamed",Salary=9000, Age = 26, DeptId = 4 },
                new Employee { Id = 10, Name = "Ayman Abdelghani",Salary=1200, Age = 31, DeptId = 5 },
                new Employee { Id = 1, Name = "Ahmed", Salary=1000, Age = 30, DeptId = 1 }
            };

        }
        public static List<Department> Departments()
        {
            return new List<Department>
            {
                new Department { Id = 1, Name = "Information Technology" },
                new Department { Id = 2, Name = "Human Resources" },
                new Department { Id = 3, Name = "Marketing" },
                new Department { Id = 4, Name = "Accounting" },
                new Department { Id = 5, Name = "Engineering" }
            };
        }
    }
}
