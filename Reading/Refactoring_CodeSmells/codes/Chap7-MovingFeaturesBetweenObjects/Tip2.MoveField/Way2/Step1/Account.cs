namespace Tip2.MoveField.Way2.Step1
{
    internal class Account
    {
        private double _interestRate;
        private AccountType _type;

        public Account(AccountType type)
        {
            _type = type;
        }

        internal double InterestForAmountWithDays(double amount, int days)
        {
            return _interestRate * amount * days / 365;
        }

        internal void SetInterestRate(double interestRate)
            => _interestRate = interestRate;

        internal double GetInterestRate() => _interestRate;
    }
}