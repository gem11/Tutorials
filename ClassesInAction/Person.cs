using System;

namespace ClassesInAction
{
    public class Person
    {
        public string Name { get; private set; }

        public int CreditLimit { get; private set; }

        public Person(string name, int creditLimit)
        {
            this.Name = name;
            this.CreditLimit = creditLimit;
        }
    }
}