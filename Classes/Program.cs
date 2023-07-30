using System;

namespace Classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SimpleClass sc1 = new SimpleClass(1);
            sc1.WriteNumber();
            Console.WriteLine();

            sc1.IncreaseNumber();
            sc1.WriteNumber();
            Console.WriteLine();

            SimpleClass alsoSc1 = sc1;
            alsoSc1.IncreaseNumber();
            sc1.WriteNumber();
            Console.WriteLine();

            sc1 = null;
            alsoSc1.WriteNumber();
            Console.WriteLine();
        }
    }

    class SimpleClass
    {
        int number;
        
        public SimpleClass(int number)
        {
            this.number = number;
        }

        public void WriteNumber()
        {
            Console.WriteLine("number = " + number);
        }

        public void IncreaseNumber()
        {
            this.number = this.number + 1;
        }
    }
}
