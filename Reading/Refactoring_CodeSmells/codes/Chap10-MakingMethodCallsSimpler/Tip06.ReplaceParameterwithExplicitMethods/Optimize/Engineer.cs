namespace Tip06.ReplaceParameterWithExplicitMethods.Optimize
{
    internal class Engineer : Employee
    {
        public Engineer()
        {
            Console.WriteLine($"Instance of {GetType().Name} is created.");
        }
    }
}