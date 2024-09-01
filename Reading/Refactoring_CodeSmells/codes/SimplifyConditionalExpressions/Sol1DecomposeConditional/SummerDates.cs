namespace SimplifyConditionalExpressions.Sol1DecomposeConditional
{
    internal static class SummerDates
    {
        private static int _currentYear = DateTime.Now.Year;

        internal static DateTime SummerStart = new DateTime(_currentYear, 6, 1);

        internal static DateTime SummerEnd = new DateTime(_currentYear, 8, 31);
    }
}