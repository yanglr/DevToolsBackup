namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingOr
{
    internal class Employee
    {
        private int _seniority; // service years

        private int _monthsDisabled;

        private bool _isPartTime;

        public int Seniority
        {
            get { return _seniority; }
            set { _seniority = value; }
        }

        public int MonthsDisabled
        {
            get { return _monthsDisabled; }
            set { _monthsDisabled = value; }
        }

        public bool IsPartTime
        {
            get { return _isPartTime; }
            set { _isPartTime = value; }
        }

        public Employee(int seniority, int monthsDisabled, bool isPartTime)
        {
            _seniority = seniority;
            _monthsDisabled = monthsDisabled;
            _isPartTime = isPartTime;
        }
    }
}