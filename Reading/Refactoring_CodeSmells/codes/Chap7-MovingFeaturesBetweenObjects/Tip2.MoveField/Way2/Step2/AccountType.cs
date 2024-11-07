namespace Tip2.MoveField.Way2.Step2
{
    internal class AccountType
    {
        private string _name;
        private double _interestRate;

        public AccountType(string name)
        {
            _name = name;
        }

        internal void SetInterestRate(double interestRate)
            => _interestRate = interestRate;

        internal double GetInterestRate() => _interestRate;
    }
}


