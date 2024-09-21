namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingAnd
{
    internal class VacationCalculatorV2
    {
        internal double ApplyVacation(Employee employee)
        {
            if (employee.OnVacation && employee.ServiceYears > 10)
            {
                return 1;
            }

            return 0.5;
        }
    }
}