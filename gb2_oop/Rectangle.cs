namespace gb2_oop;

public class Rectangle : Point
{
    public int Length { get; set; }
    public int Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }
}