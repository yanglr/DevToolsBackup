namespace Tip2.InlineMethod.Example1_RatingDriver
{
    public class RatingService
    {
        public int Rating(Driver driver)
        {
            return MoreThanFiveLateDeliveries(driver) ? 2 : 1;
        }

        private bool MoreThanFiveLateDeliveries(Driver driver)
        {
            return driver.NumberOfLateDeliveries > 5;
        }
    }
}