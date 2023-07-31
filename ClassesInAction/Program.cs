using System;

namespace ClassesInAction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person john = new Person("John", -1000);
            Person bob = new Person("Bob", -100000);

            Account johnsSavingsAccount = new Account(john);
            Account bobsDeposit1Account = new Account(bob);
            Account bobsDeposit2Account = new Account(bob);

            johnsSavingsAccount.Deposit(2000);
            Console.WriteLine("Balance on John's account:");
            Console.WriteLine(johnsSavingsAccount.GetBalanceStatement());

            if (bobsDeposit1Account.Withdraw(30000, out int money))
            {
                bobsDeposit2Account.Deposit(money);
            }

            Console.WriteLine("Balance on Bob's accounts:");
            Console.WriteLine(bobsDeposit1Account.GetBalanceStatement());
            Console.WriteLine(bobsDeposit2Account.GetBalanceStatement());
        }
    }
}
