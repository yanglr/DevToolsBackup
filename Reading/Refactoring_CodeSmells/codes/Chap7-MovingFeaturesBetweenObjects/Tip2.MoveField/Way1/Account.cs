namespace Tip2.MoveField.Way1
{
    internal class Account
    {
        private AccountType _type;

        public Account(AccountType type)
        {
            _type = type;
        }

        internal double InterestForAmountWithDays(double amount, int days)
        {
            return _type.GetInterestRate() * amount * days / 365;
        }
    }
}