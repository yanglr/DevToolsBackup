namespace Tip1.MoveMethod.Example_Account.Optimize
{
    internal class AccountType
    {
        internal bool IsPremium { get; set; }

        public AccountType(bool isPremium)
        {
            IsPremium = isPremium;
        }

        internal double GetOverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                double baseCharge = 10;
                if (daysOverdrawn <= 7)
                {
                    return baseCharge;
                }

                return baseCharge + (daysOverdrawn - 7) * 0.85;
            }

            return daysOverdrawn * 1.75;
        }
    }
}