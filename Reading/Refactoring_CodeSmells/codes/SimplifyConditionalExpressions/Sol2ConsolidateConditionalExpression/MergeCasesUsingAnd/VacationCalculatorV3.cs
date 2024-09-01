namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingAnd
{
    internal class VacationCalculatorV3
    {
        // Using the ternary operator
        internal static double ApplyVacation(Employee employee)
        {
            return (employee.OnVacation && employee.ServiceYears > 10) ? 1 : 0.5;
        }
    }
}