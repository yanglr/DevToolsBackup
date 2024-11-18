namespace Tip01.RenameMethod.MigrationMechanics.Step3
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

        public string GetOfficeTelephoneNumber()
        {
            return "(" + _officeAreaCode + ") " + _officeNumber;
        }
    }
}