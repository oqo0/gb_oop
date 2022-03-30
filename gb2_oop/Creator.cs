using System.Runtime.CompilerServices;

namespace gb2_oop;

/// <summary>
/// Фабрика класса Building
/// </summary>
public class Creator
{
    /*private int _height;
    private int _floorsAmount;
    private int _apartamentsAmount;
    private int _entranceAmount;*/
    
    internal Building Create(int height, int floorsAmount, int apartamentAmout) : this(hei)
    internal Building Create(int height, int floorsAmount, int apartamentAmount, int entranceAmount)
    {
        return new Building()
        {
            Height = height,
            FloorsAmount = floorsAmount,
            ApartamentAmount = apartamentAmount,
            EntranceAmount = entranceAmount
        };
    }
}