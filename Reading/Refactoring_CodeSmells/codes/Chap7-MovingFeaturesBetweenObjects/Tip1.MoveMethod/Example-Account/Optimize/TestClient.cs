namespace Tip1.MoveMethod.Example_Account.Optimize
{
    internal class TestClient
    {
        public static void Test()
        {
            var accountType = new AccountType(true);
            var account = new Account(accountType);

            double result = account.OverdraftCharge();

            Console.WriteLine(result);
        }
    }
}