namespace Tip1.MoveMethod.Example_Account.Optimize
{
    internal class Account
    {
        private AccountType Type { get; set; }
        private int DaysOverdrawn { get; set; }

        public Account(AccountType type)
        {
            Type = type;
        }

        internal double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
            {
                result += Type.GetOverdraftCharge(DaysOverdrawn);
            }

            return result;
        }
    }
}