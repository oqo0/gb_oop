namespace gb2_oop;

public class RationalNumber
{
    public int _numerator;
    public int _denominator;

    public RationalNumber(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public static string ToString(RationalNumber n)
    {
        return Convert.ToString(n._numerator / n._denominator); 
    }

    public static explicit operator float(RationalNumber n)
    {
        return (float) n._numerator / n._denominator;
    }
    public static explicit operator int(RationalNumber n)
    {
        return (int) n._numerator / n._denominator;
    }
        
    public static bool operator ==(RationalNumber n1, RationalNumber n2) => (n1.Equals(n2));
    public static bool operator !=(RationalNumber n1, RationalNumber n2) => (!n1.Equals(n2));

    public static bool operator >(RationalNumber n1, RationalNumber n2)
    {
        return (n1._numerator / n1._denominator > n2._numerator / n2._denominator);
    }
    public static bool operator <(RationalNumber n1, RationalNumber n2)
    {
        return (n1._numerator / n1._denominator < n2._numerator / n2._denominator);
    }
    public static bool operator >=(RationalNumber n1, RationalNumber n2)
    {
        return (n1._numerator / n1._denominator >= n2._numerator / n2._denominator);
    }
    public static bool operator <=(RationalNumber n1, RationalNumber n2)
    {
        return (n1._numerator / n1._denominator <= n2._numerator / n2._denominator);
    }
    public static int operator +(RationalNumber n1, RationalNumber n2)
    {
        return (n1._numerator / n1._denominator + n2._numerator / n2._denominator);
    }
    public static int operator -(RationalNumber n1, RationalNumber n2)
    {
        return (n1._numerator / n1._denominator - n2._numerator / n2._denominator);
    }
    public static RationalNumber operator ++(RationalNumber n)
    {
        n._denominator++;
        n._numerator++;
        return (n);
    }
    public static RationalNumber operator --(RationalNumber n)
    {
        n._denominator--;
        n._numerator--;
        return (n);
    }
    public static int operator *(RationalNumber n1, RationalNumber n2)
    {
        return ((n1._numerator / n1._denominator) * (n2._numerator / n2._denominator));
    }
    public static int operator /(RationalNumber n1, RationalNumber n2)
    {
        return ((n1._numerator / n1._denominator) / (n2._numerator / n2._denominator));
    }
    public static int operator %(RationalNumber n1, RationalNumber n2)
    {
        return ((n1._numerator / n1._denominator) % (n2._numerator / n2._denominator));
    }
}