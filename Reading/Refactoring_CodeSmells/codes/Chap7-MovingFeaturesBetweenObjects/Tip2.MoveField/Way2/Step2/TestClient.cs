namespace Tip2.MoveField.Way2.Step2
{
    internal class TestClient
    {
        public static void Test()
        {
            var accountType = new AccountType("deposit");
            accountType.SetInterestRate(0.5);
            var account = new Account(accountType);

            double result = account.InterestForAmountWithDays(1000, 5);

            Console.WriteLine(string.Format("{0:F2}", result));
        }
    }
}