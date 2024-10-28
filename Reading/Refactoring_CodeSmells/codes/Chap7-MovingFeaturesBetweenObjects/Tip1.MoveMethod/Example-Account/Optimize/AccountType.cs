namespace Tip1.MoveMethod.Example_Account.Optimize
{
    internal class AccountType
    {
        internal bool _isPremium { get; set; }

        public AccountType(bool isPremium)
        {
            _isPremium = isPremium;
        }

        internal double GetOverdraftCharge(int daysOverdrawn)
        {
            if (_isPremium)
            {
                double result = 10;
                if (daysOverdrawn > 7) result += (daysOverdrawn - 7) * 0.85;
                return result;
            }
            else
            {
                return daysOverdrawn * 1.75;
            }
        }
    }
}