namespace Tip3.ExtractClass.Optimize.Step1
{
    internal class Person
    {
        private readonly TelephoneNumber _telephoneNumber;
        private readonly string _name;
        private string _officeNumber;

        public Person(string name, TelephoneNumber telephoneNumber, string officeNumber)
        {
            _name = name;
            _officeNumber = officeNumber;
            _telephoneNumber = telephoneNumber;
        }

        public string GetName() => _name;

        public string GetTelephoneNumber()
            => "(" + _telephoneNumber.GetOfficeAreaCode() + ") " + _officeNumber;

        private string GetOfficeNumber() => _officeNumber;

        private void SetOfficeNumber(string officeNumber) => _officeNumber = officeNumber;
    }
}