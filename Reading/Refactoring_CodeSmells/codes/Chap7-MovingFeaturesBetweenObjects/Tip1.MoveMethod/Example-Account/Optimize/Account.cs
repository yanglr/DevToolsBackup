namespace Tip1.MoveMethod.Example_Account.Optimize
{
    internal class Account
    {
        private int _daysOverdrawn { get; set; }
        private AccountType _type { get; set; }

        public Account(AccountType type)
        {
            _type = type;
        }

        internal double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0)
            {
                result += _type.GetOverdraftCharge(_daysOverdrawn);
            }

            return result;
        }
    }
}