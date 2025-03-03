using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqLab02.Models
{
    public class EmployeeComp :IEqualityComparer<Employee>
    {

        public bool Equals(Employee? x, Employee? y)
        {
            if (x == null || y == null) return false;

            return x.Age == y.Age && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {

            if (obj == null) return 0;
            return HashCode.Combine(obj.Name, obj.Age);
        }



    }
}
