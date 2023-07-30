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

            // Private members not accessible:
            // sc1.number = 5;
            // sc1.PerformIncrease();
        }
    }

    class SimpleClass
    {
        private int number; // Private Member variable
        
        public SimpleClass(int number) // Constructor
        {
            this.number = number;
        }

        public void WriteNumber() // Public Instance Method
        {
            Console.WriteLine("number = " + number);
        }

        private void PerformIncrease() // Private Instance Method
        {
            this.number = this.number + 1;
        }

        public void IncreaseNumber() // Public Instance Method
        {
            PerformIncrease();
        }

        public static void WriteSomething() // Static Method
        {
            Console.WriteLine("This is a static method");
        }
    }
}
