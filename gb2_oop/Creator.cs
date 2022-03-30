using System.Runtime.CompilerServices;

namespace gb2_oop;

/// <summary>
/// Фабрика класса Building
/// </summary>
public class Creator
{
    private Creator() {} 
    public static Building CreateBuild()
    {
        return new Building()
        {
            Height = 1,
            FloorsAmount = 1,
            ApartamentAmount = 1,
            EntranceAmount = 1
        };
    }
    public static Building CreateBuild(int height)
    {
        return new Building()
        {
            Height = height,
            FloorsAmount = 1,
            ApartamentAmount = 1,
            EntranceAmount = 1
        };
    }
    public static Building CreateBuild(int height, int floorsAmount)
    {
        return new Building()
        {
            Height = height,
            FloorsAmount = floorsAmount,
            ApartamentAmount = 1,
            EntranceAmount = 1
        };
    }
    public static Building CreateBuild(int height, int floorsAmount, int apartamentAmount)
    {
        return new Building()
        {
            Height = height,
            FloorsAmount = floorsAmount,
            ApartamentAmount = apartamentAmount,
            EntranceAmount = 1
        };
    }
    public static Building CreateBuild(int height, int floorsAmount, int apartamentAmount, int entranceAmount)
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