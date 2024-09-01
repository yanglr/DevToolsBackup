using System.Diagnostics;

namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForProjectExpense
{
    internal class Employee
    {
        private const double InvalidExpense = -1;
        private Project _primaryProject;

        internal bool WithinLimit(double actualEexpense, double expenseLimit)
        {
            return actualEexpense <= GetProjectExpenseLimit(expenseLimit);
        }

        private double GetProjectExpenseLimit(double expenseLimit)
        {
            Trace.Assert(_primaryProject != null || expenseLimit != InvalidExpense);
            return (expenseLimit != InvalidExpense) ?
                expenseLimit :
                (_primaryProject?.GetExpenseLimit() ?? 0);
        }
    }
}