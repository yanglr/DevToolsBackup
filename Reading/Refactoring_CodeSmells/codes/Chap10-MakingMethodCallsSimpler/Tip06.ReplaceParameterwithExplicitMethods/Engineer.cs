namespace Tip06.ReplaceParameterWithExplicitMethods
{
    internal class Engineer : Employee
    {
        public Engineer()
        {
            Console.WriteLine($"Instance of {GetType().Name} is created.");
        }
    }
}