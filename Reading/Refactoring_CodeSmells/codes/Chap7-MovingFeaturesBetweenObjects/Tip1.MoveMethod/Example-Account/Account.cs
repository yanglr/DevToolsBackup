namespace Tip1.MoveMethod.Example_Account
{
    internal class Account
    {
        internal int _daysOverdrawn { get; set; }
        internal AccountType _type { get; set; }

        internal double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0)
            {
                result += OverdraftCharge();
            }

            return result;
        }

        internal double OverdraftCharge()
        {
            if (_type.IsPremium)
            {
                double baseCharge = 10;
                if (_daysOverdrawn <= 7)
                {
                    return baseCharge;
                }
                else
                {
                    return baseCharge + (_daysOverdrawn - 7) * 0.85;
                }
            }
            else
            {
                return _daysOverdrawn * 1.75;
            }
        }
    }
}