using Tip2.InlineMethod.Example1_RatingDriver;

namespace Tip2.InlineMethod.Example1_RatingDrive.Optimize
{
    public class RatingService
    {
        public int Rating(Driver driver)
        {
            return driver.NumberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}