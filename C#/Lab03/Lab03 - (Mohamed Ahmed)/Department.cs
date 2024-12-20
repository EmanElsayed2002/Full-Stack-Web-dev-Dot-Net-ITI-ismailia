namespace Lab3
{
    internal class Department
    {
        private int deptId;
        private string deptName;

        public void SetDeptId(int _deptId) { deptId = _deptId; }
        public int GetDeptId() { return deptId; }
        public void SetDeptName(string _deptName) { deptName = _deptName; }
        public string GetDeptName() { return deptName; }

        public Department()
        {
            
        }
        public Department(int departmentId, string departmentName)
        {
            deptId = departmentId;
            deptName = departmentName;
        }

        public string Print()
        {
            return $"{deptId} : {deptName}";
        }
    }
}