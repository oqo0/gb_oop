using System;
using System.Xml.Schema;

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