namespace Tip3.ExtractClass.Optimize.Step1
{
    internal class TelephoneNumber
    {
        private string _officeAreaCode;

        public TelephoneNumber(string officeAreaCode)
        {
            _officeAreaCode = officeAreaCode;
        }

        private string GetOfficeAreaCode()
        {
            return _officeAreaCode;
        }

        private void SetOfficeAreaCode(string officeAreaCode)
        {
            _officeAreaCode = officeAreaCode;
        }
    }
}