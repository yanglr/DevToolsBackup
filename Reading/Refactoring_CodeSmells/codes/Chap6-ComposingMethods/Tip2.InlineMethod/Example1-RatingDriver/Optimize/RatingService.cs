using Tip2.InlineMethod.Example1_RatingDriver;

namespace Tip2.InlineMethod.Example1_RatingDrive.Optimize
{
    public class RatingService
    {
        // 1 - 1st level (优) driver, 2 - 2nd level (良) driver
        public int Rating(Driver driver)
        {
            return driver.NumberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}