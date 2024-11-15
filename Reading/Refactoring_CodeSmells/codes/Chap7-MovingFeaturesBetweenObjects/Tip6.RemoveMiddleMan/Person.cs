namespace Tip6.RemoveMiddleMan
{
    internal class Person
    {
        private readonly Department _department;

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