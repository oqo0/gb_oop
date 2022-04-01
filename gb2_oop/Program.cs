using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1000, AccountType.Current);
            BankAccount account2 = new BankAccount(1500, AccountType.Deposit);

            if (account == account2)
                Console.WriteLine($"На счетах {account.ToString()} и {account2.ToString()} одинаковое кол-во денег.");
            else
                Console.WriteLine($"На счетах {account.ToString()} и {account2.ToString()} разное кол-во денег.");
        }
    }
}