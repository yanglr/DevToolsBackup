namespace Tip07.PreserveWholeObject
{
    internal class Room
    {
        private TempRange _tempRange;

        public Room(int low, int high)
        {
            _tempRange = new TempRange(low, high);
        }

        // Get temperature of the day
        public TempRange DaysTempRange()
        {
            return _tempRange;
        }

        public bool WithinPlan(HeatingPlan plan)
        {
            int low = DaysTempRange().GetLow();
            int high = DaysTempRange().GetHigh();
            return plan.WithinRange(low, high);
        }
    }
}