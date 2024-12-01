namespace Tip06.ReplaceParameterWithExplicitMethods.Optimize
{
    internal class Manager : Employee
    {
        public Manager()
        {
            Console.WriteLine($"Instance of {GetType().Name} is created.");
        }
    }
}