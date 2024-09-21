namespace AlternativeClassesWithDiffInterfaces.SquareAndRectangle.Optimize
{
    internal class Square : IShape
    {
        public double Length { get; set; }

        public Square(double length)
        {
            Length = length;
        }

        public double Area()
        {
            return Length * Length;
        }

        public double Perimeter()
        {
            return 4 * Length;
        }
    }
}