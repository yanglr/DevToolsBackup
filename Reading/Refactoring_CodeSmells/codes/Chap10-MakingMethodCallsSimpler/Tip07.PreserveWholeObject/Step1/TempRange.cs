namespace Tip07.PreserveWholeObject.Step1
{
    internal class TempRange
    {
        private int _low;
        private int _high;

        public TempRange(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public int GetLow() => _low;

        public int GetHigh() => _high;
    }
}