using System.Diagnostics;

namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion
{
    internal class EmployeeV1
    {
        private const double InvalidExpense = -1.0;
        private double _expenseLimit = InvalidExpense;
        private Project _primaryProject;

        private bool WithinLimit(double expenseAmount)
        {
            return expenseAmount <= GetExpenseLimit();
        }

        private double GetExpenseLimit()
        {
            Trace.Assert(_expenseLimit > InvalidExpense || _primaryProject != null);
            return _expenseLimit != InvalidExpense ? _expenseLimit :
                (double)_primaryProject?.GetExpenseLimit();
        }
    }
}