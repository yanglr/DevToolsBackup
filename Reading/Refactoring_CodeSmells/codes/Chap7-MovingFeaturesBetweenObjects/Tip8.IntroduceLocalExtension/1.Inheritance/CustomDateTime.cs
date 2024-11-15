using Tip8.IntroduceLocalExtension;

namespace Tip8.IntroduceLocalExtension1.Inheritance
{
    internal class CustomDateTime : OriginalDate
    {
        public CustomDateTime(DateTime date) : base(date)
        {
        }

        public bool IsHoliday()
        {
            // Check if the date is a holiday
            return false;
        }
    }
}
