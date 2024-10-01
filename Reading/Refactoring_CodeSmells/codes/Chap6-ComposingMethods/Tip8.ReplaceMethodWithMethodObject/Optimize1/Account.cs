﻿namespace Tip8.ReplaceMethodWithMethodObject.Optimize1
{
    internal class Account
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            Gamma gamma = new Gamma(this, inputVal, quantity, yearToDate);
            return gamma.Compute();
        }

        internal int Delta()
        {
            return 42;
        }
    }
}