namespace Tip3.ExtractClass.Optimize.Step1
{
    internal class TelephoneNumber
    {
        private string _officeAreaCode;

        internal string GetOfficeAreaCode()
        {
            return _officeAreaCode;
        }

        internal void SetOfficeAreaCode(string officeAreaCode)
        {
            _officeAreaCode = officeAreaCode;
        }
    }
}