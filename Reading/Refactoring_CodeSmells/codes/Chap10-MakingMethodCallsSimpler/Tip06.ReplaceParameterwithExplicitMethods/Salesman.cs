namespace Tip06.ReplaceParameterWithExplicitMethods
{
    internal class Salesman : Employee
    {
        public Salesman()
        {
            Console.WriteLine($"Instance of {GetType().Name} is created.");
        }
    }
}