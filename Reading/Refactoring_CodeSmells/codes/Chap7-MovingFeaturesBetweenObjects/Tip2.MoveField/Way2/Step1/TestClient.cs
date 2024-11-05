namespace Tip2.MoveField.Way2.Step1
{
    internal class TestClient
    {
        public static void Test()
        {
            var accountType = new AccountType("deposit");
            var account = new Account(accountType);
            account.SetInterestRate(0.5);

            double result = account.InterestForAmountWithDays(1000, 5);

            Console.WriteLine(string.Format("{0:F2}", result));
        }
    }
}