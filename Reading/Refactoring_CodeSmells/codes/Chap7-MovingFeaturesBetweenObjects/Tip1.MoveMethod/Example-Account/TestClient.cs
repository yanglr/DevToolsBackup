namespace Tip1.MoveMethod.Example_Account
{
    internal class TestClient
    {
        public static void Test()
        {
            var account = new Account();
            var accountType = new AccountType();
            accountType.IsPremium = true;
            account._type = accountType;

            double result = account.OverdraftCharge();

            Console.WriteLine(result);
        }
    }
}