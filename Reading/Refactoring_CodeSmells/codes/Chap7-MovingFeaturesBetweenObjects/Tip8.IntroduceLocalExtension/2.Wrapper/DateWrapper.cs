using Tip8.IntroduceLocalExtension;

namespace Tip8.IntroduceLocalExtension_2.Wrapper
{
    internal class DateWrapper
    {
        private readonly OriginalDate _originalDate;

        public DateWrapper(OriginalDate originalDate)
        {
            _originalDate = originalDate;
        }

        public bool IsHoliday()
        {
            // Check if the date is a holiday
            return false;
        }

        // Delegate other methods to the _originalDate if any...
    }
}

