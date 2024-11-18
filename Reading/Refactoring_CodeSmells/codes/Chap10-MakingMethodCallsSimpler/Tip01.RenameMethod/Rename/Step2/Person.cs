namespace Tip01.RenameMethod.Rename.Step2
{
    internal class Person
    {
        private string _officeAreaCode;
        private string _officeNumber;

        public Person(string officeAreaCode, string officeNumber)
        {
            _officeAreaCode = officeAreaCode;
            _officeNumber = officeNumber;
        }

        public string GetTelephoneNumber()
        {
            return GetTelephoneNumber();
        }

        public string GetOfficeTelephoneNumber()
        {
            return "(" + _officeAreaCode + ") " + _officeNumber;
        }
    }
}