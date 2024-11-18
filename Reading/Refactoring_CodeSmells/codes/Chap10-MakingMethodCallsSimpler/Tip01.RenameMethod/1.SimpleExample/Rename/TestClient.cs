namespace Tip01.RenameMethod1.SimpleExample.Rename
{
    internal class TestClient
    {
        public static void Test()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateCirclePerimeter(5);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}