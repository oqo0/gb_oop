namespace gb2_oop;

public class Figure
{
    private FigureColor _color;
    private bool _visible;
    private int _posX;
    private int _posY;

    public void MoveHorizontally(int distance)
    {
        _posX += distance;
    }
    
    public void MoveVertically(int distance)
    {
        _posY += distance;
    }

    public void ChangeColor(FigureColor color)
    {
        _color = color;
    }

    public void ChangeVisibility(bool visible)
    {
        _visible = visible;
    }

    public void Print()
    {
        Console.WriteLine("color: " + _color);
        Console.WriteLine("visible: " + _visible);
        Console.WriteLine("position: " + _posX + ", " + _posY);
    }
}