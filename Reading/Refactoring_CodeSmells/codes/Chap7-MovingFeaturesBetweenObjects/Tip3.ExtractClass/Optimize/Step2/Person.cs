namespace Tip3.ExtractClass.Optimize.Step2
{
    internal class Person
    {
        private readonly TelephoneNumber _telephoneNumber;
        private readonly string _name;

        public Person(string name, TelephoneNumber telephoneNumber)
        {
            _name = name;
            _telephoneNumber = telephoneNumber;
        }

        public string GetName() => _name;
    }
}