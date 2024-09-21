namespace AlternativeClassesWithDiffInterfaces.SquareAndRectangle;

internal class RectangleV0
{
    public double Width { get; set; }
    public double Height { get; set; }

    public RectangleV0(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}
