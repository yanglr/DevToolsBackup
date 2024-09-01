namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingAnd
{
    internal class Employee
    {
        private int _serviceYears; // service years

        private bool _onVacation;

        public int ServiceYears
        {
            get { return _serviceYears; }
            set { _serviceYears = value; }
        }

        public bool OnVacation
        {
            get { return _onVacation; }
            set { _onVacation = value; }
        }

        public Employee(int seniority, bool onVacation)
        {
            _serviceYears = seniority;
            _onVacation = onVacation;
        }
    }
}