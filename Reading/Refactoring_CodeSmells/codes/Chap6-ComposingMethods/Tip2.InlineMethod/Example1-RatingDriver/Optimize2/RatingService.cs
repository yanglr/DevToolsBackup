namespace Tip2.InlineMethod.Example1_RatingDriver.Optimize2
{
    public class RatingService
    {
        public int Rating(Driver driver) 
            => driver.NumberOfLateDeliveries > 5 ? 2 : 1;
    }
}