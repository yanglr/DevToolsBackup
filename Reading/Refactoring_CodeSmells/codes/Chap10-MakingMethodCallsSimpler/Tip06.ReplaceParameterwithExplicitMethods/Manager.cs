namespace Tip06.ReplaceParameterWithExplicitMethods
{
    internal class Manager : Employee
    {
        public Manager()
        {
            Console.WriteLine($"Instance of {GetType().Name} is created.");
        }
    }
}