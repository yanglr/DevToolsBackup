namespace Tip07.PreserveWholeObject
{
    internal class HeatingPlan
    {
        private TempRange _range;

        public HeatingPlan(TempRange range)
        {
            _range = range;
        }

        public bool WithinRange(int low, int high)
        {
            return low >= _range.GetLow() && high <= _range.GetHigh();
        }
    }
}