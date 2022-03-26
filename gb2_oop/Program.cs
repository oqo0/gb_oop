using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            account.UpdateNumber();
            account.SetType(BankAccount.BankAccountType.Credit);
            account.SetBalance(20000);

            Console.WriteLine($"{account.GetNumber()} - {account.GetType()}, {account.GetBalance()} $");
        }
    }

    class BankAccount
    {
        private static int UniqueNumber = 0;
        private int Number = UniqueNumber;
        private int Balance = 0;
        private BankAccountType Type = BankAccountType.None;
        public enum BankAccountType
        {
            None,
            Current,
            Settlement,
            Credit
        }

        public int GetNumber()
        {
            return Number;
        }
        public void UpdateNumber()
        {
            UniqueNumber++;
        }
        
        public long GetBalance()
        {
            return Balance;
        }
        public void SetBalance(int value)
        {
            Balance = value;
        }
        
        public BankAccountType GetType()
        {
            return Type;
        }
        public void SetType(BankAccountType type)
        {
            Type = type;
        }
    }
}