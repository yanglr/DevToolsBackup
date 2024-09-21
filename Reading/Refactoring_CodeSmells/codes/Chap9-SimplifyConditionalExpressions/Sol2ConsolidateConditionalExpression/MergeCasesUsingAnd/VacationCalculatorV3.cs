namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingAnd
{
    internal class VacationCalculator
    {
        // Using the ternary operator
        internal double ApplyVacation(Employee employee)
        {
            return employee.OnVacation && employee.ServiceYears > 10 ? 1 : 0.5;
        }
    }
}