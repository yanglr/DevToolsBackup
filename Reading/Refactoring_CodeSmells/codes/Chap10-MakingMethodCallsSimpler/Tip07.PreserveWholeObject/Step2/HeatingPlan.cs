namespace Tip07.PreserveWholeObject.Step2
{
    internal class HeatingPlan
    {
        private TempRange _range;

        public HeatingPlan(TempRange range)
        {
            _range = range;
        }

        public bool Includes(TempRange tempRange)
        {
            return tempRange.GetLow() >= _range.GetLow() && tempRange.GetHigh() <= _range.GetHigh();
        }
    }
}