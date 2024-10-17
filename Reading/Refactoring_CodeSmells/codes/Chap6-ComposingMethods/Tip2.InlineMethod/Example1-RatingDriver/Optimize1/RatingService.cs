namespace Tip2.InlineMethod.Example1_RatingDriver.Optimize1
{
    public class RatingService
    {
        public int Rating(Driver driver)
        {
            return driver.NumberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}