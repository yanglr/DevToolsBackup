namespace Tip5.HideDelegate.Optimize
{
    internal class Person
    {
        private Department _department;

        public Person(Department department)
        {
            _department = department;
        }

        public string GetManager()
        {
            return _department.GetManager();
        }

        private Department GetDepartment()
        {
            return _department;
        }
    }
}