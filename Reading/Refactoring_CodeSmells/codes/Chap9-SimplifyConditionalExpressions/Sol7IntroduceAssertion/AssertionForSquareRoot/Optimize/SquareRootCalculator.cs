using System.Diagnostics;

namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForSquareRoot.Optimize
{
    internal class SquareRootCalculator
    {
        public double GetSquareRoot(int num)
        {
            Trace.Assert(num >= 0);
            return Math.Sqrt(num);
        }
    }
}
