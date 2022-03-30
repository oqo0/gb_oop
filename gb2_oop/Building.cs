namespace gb2_oop;

public class Building
{
    private static int _number = 0;
    private int _height;
    private int _floorsAmount;
    private int _apartamentsAmount;
    private int _entranceAmount;

    internal Building()
    {
        _number++;
    }

    internal int Number
    {
        get
        {
            return _number;
        }
    }
    
    internal int Height
    {
        get
        {
            return _height;
        }
        set
        {
            _height = value >= 0 ? value : _height;
        }
    }
    internal int FloorsAmount
    {
        get
        {
            return _floorsAmount;
        }
        set
        {
            _floorsAmount = value >= 0 ? value : _floorsAmount;
        }
    }
    internal int ApartamentAmount
    {
        get
        {
            return _apartamentsAmount;
        }
        set
        {
            _apartamentsAmount = value >= 0 ? value : _apartamentsAmount;
        }
    }
    internal int EntranceAmount
    {
        get
        {
            return _entranceAmount;
        }
        set
        {
            _entranceAmount = value >= 0 ? value : _entranceAmount;
        }
    }
    
    // Вычисление высоты этажа
    internal double GetFloorHeight()
    {
        return (Convert.ToDouble(_height) / _floorsAmount);
    }
    // Вычисление кол-ва квартир в подъезде
    internal int GetFlatsInEntranceAmount()
    {
        return (_apartamentsAmount / _entranceAmount);
    }
    // Вычисление кол-ва квартир на этаже
    internal int GetFlatsOnFloorAmount()
    {
        return (_apartamentsAmount / _floorsAmount);
    }
    // Вычисление кол-ва квартир в одном подъезде на этаже
    internal int GetFlatsOnFloorInEntranceAmount()
    {
        return (GetFlatsOnFloorAmount() / _entranceAmount);
    }
}