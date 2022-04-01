namespace gb2_oop;

public enum AccountType
{
    None,
    Current,
    Credit,
    Deposit
}

public class BankAccount
{
    private static int uniqueId;
    
    private readonly int _id;
    private int _balance;
    private AccountType _type;

    public int Balance
    {
        get
        {
            return _balance;
        }
    }
    
    public BankAccount(int balance, AccountType type)
    {
        _id = ++uniqueId;
        _balance = balance;
        _type = type;
    }
    
    public static bool operator ==(BankAccount n1, BankAccount n2)
    {
        bool balanceIsSimilar = (n1._balance == n2._balance);
        return balanceIsSimilar;
    }
    public static bool operator !=(BankAccount n1, BankAccount n2)
    {
        bool balanceIsNotSimilar = (n1._balance == n2._balance);
        return balanceIsNotSimilar;
    }
    public override bool Equals(Object o)
    {
        if (o == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public override int GetHashCode()
    {
        return _id;
    }
    public override string ToString()
    {
        string info = $"{_id} - account type: {_type}, balance: {_balance}$";
        return info;
    }
}