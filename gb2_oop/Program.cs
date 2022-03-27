using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            account.Number = 0;
            account.Type = BankAccount.BankAccountType.Credit;
            account.Balance = 20000;

            Console.WriteLine($"{account.Number} - {account.Type}, {account.Balance} $");
            
            BankAccount a = new BankAccount();
            
            a.Number = 0;
            a.Type = BankAccount.BankAccountType.Credit;
            a.Balance = 10000;
            
            Console.WriteLine($"{a.Number} - {a.Type}, {a.Balance} $"); // 1 - Credit, 10000 $
            
            BankAccount.TransferMoney(a, 1000);
            
            Console.WriteLine($"{a.Number} - {a.Type}, {a.Balance} $"); // 1 - Credit, 9000 $
        }
    }
    class BankAccount
    {
        private static int UniqueNumber = 0;
        private int number = UniqueNumber;
        private int balance = 0;
        private BankAccountType type = BankAccountType.None;
        public enum BankAccountType
        {
            None,
            Current,
            Settlement,
            Credit
        }
        public static void TransferMoney(BankAccount account, int amount)
        {
            account.Balance -= amount;
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = ++UniqueNumber;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public BankAccountType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}