using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            BankAccount account = new BankAccount(4000, BankAccount.BankAccountType.Current);
            Console.WriteLine($"{account.GetNumber()} - {account.GetType()}, {account.GetBalance()} $");
            
            BankAccount account2 = new BankAccount(5200, BankAccount.BankAccountType.Credit);
            Console.WriteLine($"{account2.GetNumber()} - {account2.GetType()}, {account2.GetBalance()} $");
            
            BankAccount account3 = new BankAccount(2000, BankAccount.BankAccountType.Current);
            Console.WriteLine($"{account3.GetNumber()} - {account3.GetType()}, {account3.GetBalance()} $");
        }
    }

    class BankAccount
    {
        private static int UniqueNumber = 0;
        private int Number = UniqueNumber;
        private int Balance = 0;
        private BankAccountType Type = BankAccountType.None;

        public BankAccount(int balance)
        {
            Balance = balance;
            GenerateUniqueNumber();
        }
        public BankAccount(BankAccountType type)
        {
            Type = type;
            GenerateUniqueNumber();

        }
        public BankAccount(int balance, BankAccountType type)
        {
            Balance = balance;
            Type = type;
            GenerateUniqueNumber();
        }
        
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

        private void GenerateUniqueNumber()
        {
            UniqueNumber++;
        }

        public long GetBalance()
        {
            return Balance;
        }

        public BankAccountType GetType()
        {
            return Type;
        }
    }
}