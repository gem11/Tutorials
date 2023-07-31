using System;
namespace ClassesInAction
{
    public class Account
    {
        int balance;
        Person person;

        public Person Person
        {
            get { return person; }
            private set { person = value; }
        }

        public Account(Person person)
        {
            this.Person = person;
            this.balance = 0;
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
            else
            {
                throw new Exception("Amount needs to be positive");
            }
        }

        public bool Withdraw(int requestedAmount, out int withdrawnAmount)
        {
            if (balance - requestedAmount >= Person.CreditLimit)
            {
                withdrawnAmount = requestedAmount;
                balance -= requestedAmount;                
                return true;
            }
            else if (balance > Person.CreditLimit)
            {
                withdrawnAmount = balance - Person.CreditLimit;
                balance = Person.CreditLimit;
                return true;
            }
            else
            {
                withdrawnAmount = 0;
                return false;
            }
        }

        public string GetBalanceStatement()
        {
            return $"The current balance is: {balance}. Account belongs to '{Person.Name}'";
        }
    }
}
