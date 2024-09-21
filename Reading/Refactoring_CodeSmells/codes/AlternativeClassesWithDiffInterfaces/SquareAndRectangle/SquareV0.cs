namespace AlternativeClassesWithDiffInterfaces.SquareAndRectangle
{
    internal class SquareV0
    {
        public double Length { get; set; }

        public SquareV0(double length)
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
