namespace Tip1.MoveMethod.Example_Account
{
    internal class Account
    {
        internal AccountType Type { get; set; }
        internal int DaysOverdrawn { get; set; }

        internal double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
            {
                result += OverdraftCharge();
            }

            return result;
        }

        internal double OverdraftCharge()
        {
            if (Type.IsPremium)
            {
                double baseCharge = 10;
                if (DaysOverdrawn <= 7)
                {
                    return baseCharge;
                }

                return baseCharge + (DaysOverdrawn - 7) * 0.85;
            }

            return DaysOverdrawn * 1.75;
        }
    }
}