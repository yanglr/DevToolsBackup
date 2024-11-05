namespace Tip3.ExtractClass.Optimize.Step1
{
    internal class Person
    {
        private readonly string _name;
        private string _officeNumber;

        public Person(string name, string officeNumber)
        {
            _name = name;
            _officeNumber = officeNumber;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetTelephoneNumber()
        {
            return "(" + _officeAreaCode + ") " + _officeNumber;
        }

        private string GetOfficeNumber()
        {
            return _officeNumber;
        }

        private void SetOfficeNumber(string officeNumber)
        {
            _officeNumber = officeNumber;
        }
    }
}