namespace gb2_oop;

public class Circle : Point
{
    public int Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}