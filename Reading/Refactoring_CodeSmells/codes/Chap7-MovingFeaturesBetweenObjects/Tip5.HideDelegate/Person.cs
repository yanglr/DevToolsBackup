namespace Tip5.HideDelegate
{
    internal class Person
    {
        private Department _department;

        public string GetManager(Department department)
        {
            return department.GetManager();
        }

        public void SetDepartment(Department department)
        {
            _department = department;
        }

        public Department GetDepartment()
        {
            return _department;
        }
    }
}

