using LinqLab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab1.Repo
{
    public class GetData
    {
        public static List<Student> Students()
        {
            return new List<Student>()
            {
            new Student() { ID = 1, FirstName = "Eman", LastName = "Elsayed", Age = 22, Salary = 1234, TrackId = 1 },
            new Student() { ID = 2, FirstName = "Hala", LastName = "Haitham", Age = 23, Salary = 1434, TrackId = 1 },
            new Student() { ID = 3, FirstName = "Mona", LastName = "Ahmed", Age = 24, Salary = 1734, TrackId = 1 },
            new Student() { ID = 4, FirstName = "Alaa", LastName = "Reda", Age = 26, Salary = 1834, TrackId = 1 },
            new Student() { ID = 5, FirstName = "shrouk", LastName = "Ali", Age = 28, Salary = 1034, TrackId = 1 },
            new Student() { ID = 6, FirstName = "Hagar", LastName = "Elsayed", Age = 32, Salary = 12134, TrackId = 1 },
            new Student() { ID = 7, FirstName = "Ahmed", LastName = "Mohamed", Age = 42, Salary = 1334, TrackId = 1 },
            new Student() { ID = 7, FirstName = "Ahmed", LastName = "Mohamed", Age = 42, Salary = 6000, TrackId = 1 }

            };
        }
    }
}
