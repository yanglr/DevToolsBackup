namespace Tip07.PreserveWholeObject.Step2
{
    internal class Room
    {
        private TempRange _tempRange;

        public Room(int low, int high)
        {
            _tempRange = new TempRange(low, high);
        }

        // Get temparature of the day
        public TempRange DaysTempRange()
        {
            return _tempRange;
        }

        public bool WithinPlan(HeatingPlan plan)
        {
            return plan.Includes(DaysTempRange());
        }
    }
}