﻿namespace Tip3.ExtractClass.Optimize.Step2
{
    internal class TelephoneNumber
    {
        private string _officeAreaCode;
        private string _officeNumber;

        public TelephoneNumber(string officeAreaCode, string officeNumber)
        {
            _officeAreaCode = officeAreaCode;
            _officeNumber = officeNumber;
        }

        public string GetTelephoneNumber()
        {
            return "(" + GetOfficeAreaCode() + ") " + _officeNumber;
        }

        internal string GetOfficeNumber()
        {
            return _officeNumber;
        }

        internal void SetOfficeNumber(string officeNumber)
        {
            _officeNumber = officeNumber;
        }

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