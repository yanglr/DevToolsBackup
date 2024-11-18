namespace Tip01.RenameMethod1.SimpleExample
{
    internal class TestClient
    {
        public static void Test()
        {
            var calculator = new Calculator();

            var result = calculator.Circum(5);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}