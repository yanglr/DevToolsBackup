namespace Tip8.ReplaceMethodWithMethodObject
{
    internal class Account
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            int alphaValue = (inputVal * quantity) + Delta();
            int betaValue = (inputVal * yearToDate) + 100;
            if ((yearToDate - alphaValue) > 100)
            {
                betaValue -= 100;
            }

            int sigmaValue = betaValue * 7;
            return sigmaValue - 2 * alphaValue;
        }

        private int Delta()
        {
            return 42;
        }
    }
}