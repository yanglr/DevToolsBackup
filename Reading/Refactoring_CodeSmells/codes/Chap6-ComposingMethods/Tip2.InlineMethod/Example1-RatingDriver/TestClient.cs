using Tip2.InlineMethod.Example1_RatingDrive;

namespace Tip2.InlineMethod.Example1_RatingDriver
{
    internal class TestClient
    {
        public static void Test()
        {
            var driver = new Driver { NumberOfLateDeliveries = 6 };
            var ratingService = new RatingService();
            Console.WriteLine("Rating of the driver:" + ratingService.Rating(driver));
        }
    }
}