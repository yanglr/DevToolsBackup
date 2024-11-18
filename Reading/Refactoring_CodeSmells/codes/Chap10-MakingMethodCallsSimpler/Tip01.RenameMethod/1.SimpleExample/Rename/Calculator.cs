namespace Tip01.RenameMethod1.SimpleExample.Rename
{
    internal class Calculator
    {
        // Perimeter is more generic, if change to Rectangle, can use similar method name
        public double CalculateCirclePerimeter(int radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}