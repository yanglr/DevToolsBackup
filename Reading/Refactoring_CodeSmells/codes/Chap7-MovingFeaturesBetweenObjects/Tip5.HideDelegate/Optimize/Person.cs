namespace Tip5.HideDelegate.Optimize
{
    internal class Person
    {
        private readonly Department _department;

        public Person(Department department) // pass parameter using ctor
        {
            _department = department;
        }

        public string GetManager()
        {
            return _department.GetManager();
        }
    }
}

