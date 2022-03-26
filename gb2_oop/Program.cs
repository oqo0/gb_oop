using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            BankAccount account = new BankAccount(4000, BankAccount.BankAccountType.Current);
            
            Console.WriteLine($"{account.GetNumber()} - {account.GetType()}, {account.GetBalance()} $");
            account.Deposit(1000);
            Console.WriteLine($"{account.GetNumber()} - {account.GetType()}, {account.GetBalance()} $");
            account.Withdraw(2000);
            Console.WriteLine($"{account.GetNumber()} - {account.GetType()}, {account.GetBalance()} $");
            account.Withdraw(5000);
            Console.WriteLine($"{account.GetNumber()} - {account.GetType()}, {account.GetBalance()} $");
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

        public void Deposit(int value)
        {
            Balance += value;
        }

        public void Withdraw(int value)
        {
            if (Balance >= value)
                Balance -= value;
        }
    }
}