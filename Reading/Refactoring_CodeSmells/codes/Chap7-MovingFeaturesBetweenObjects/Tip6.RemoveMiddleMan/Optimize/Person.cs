namespace Tip6.RemoveMiddleMan.Optimize
{
    internal class Person
    {
        private Department _department;

        public Person(Department department)
        {
            _department = department;
        }

        public Department GetDepartment()
        {
            return _department;
        }

        public void SetDepartment(Department department)
        {
            _department = department;
        }
    }
}