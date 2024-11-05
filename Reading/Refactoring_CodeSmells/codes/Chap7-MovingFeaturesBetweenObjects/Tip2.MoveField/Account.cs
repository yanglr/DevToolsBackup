namespace Tip2.MoveField
{
    internal class Account
    {
        private double _interestRate;
        private AccountType _type;

        public Account(AccountType type, double interestRate)
        {
            _type = type;
            _interestRate = interestRate;
        }

        internal double InterestForAmountWithDays(double amount, int days)
        {
            return _interestRate * amount * days / 365;
        }
    }
}