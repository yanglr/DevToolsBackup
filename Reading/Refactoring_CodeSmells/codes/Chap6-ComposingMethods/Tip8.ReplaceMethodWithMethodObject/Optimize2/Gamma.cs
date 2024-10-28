namespace Tip8.ReplaceMethodWithMethodObject.Optimize2
{
    internal class Gamma
    {
        private readonly Account _account;
        private readonly int _inputVal;
        private readonly int _quantity;
        private readonly int _yearToDate;
        private int _alphaValue;
        private int _betaValue;
        private int _sigmaValue;

        public Gamma(Account account, int inputVal, int quantity, int yearToDate)
        {
            _account = account;
            _inputVal = inputVal;
            _quantity = quantity;
            _yearToDate = yearToDate;
        }

        public int Compute()
        {
            _alphaValue = _inputVal * _quantity + _account.Delta();
            _betaValue = _inputVal * _yearToDate + 100;
            AdjustBetaValue();
            _sigmaValue = _betaValue * 7;
            return _sigmaValue - 2 * _alphaValue;
        }

        private void AdjustBetaValue()
        {
            if (_yearToDate - _alphaValue > 100)
            {
                _betaValue -= 20;
            }
        }
    }
}