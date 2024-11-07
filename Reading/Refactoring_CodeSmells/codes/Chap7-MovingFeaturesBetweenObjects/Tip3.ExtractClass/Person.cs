namespace Tip3.ExtractClass
{
    internal class Person
    {
        private readonly string _name;
        private string _officeAreaCode;
        private string _officeNumber;

        public Person(string name, string officeAreaCode, string officeNumber)
        {
            _name = name;
            _officeAreaCode = officeAreaCode;
            _officeNumber = officeNumber;
        }

        public string GetName() => _name;

        public string GetTelephoneNumber()
            => "(" + _officeAreaCode + ") " + _officeNumber;

        private string GetOfficeAreaCode() => _officeAreaCode;

        private void SetOfficeAreaCode(string officeAreaCode) => _officeAreaCode = officeAreaCode;

        private string GetOfficeNumber() => _officeNumber;

        private void SetOfficeNumber(string officeNumber) => _officeNumber = officeNumber;
    }
}