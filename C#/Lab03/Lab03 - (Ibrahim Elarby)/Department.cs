using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day4lab
{
    class Department
    {
        private int departmenId;
        
        private string name;

        public Department()
        {
            departmenId = 0;
            name = string.Empty;
        }
        public Department(int departmenId, string name)
        {
                this.name = name;
                this.departmenId = departmenId;
        }

        //setter
        public void setDepartmentId(int departmenId)
        {
            this.departmenId = departmenId;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        //getters
        public int getDepartmentId()
        {
            return this.departmenId;
        }

        public string getName()
        {
            return this.name;
        }
        
    }
}
