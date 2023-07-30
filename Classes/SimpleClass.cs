using System;
namespace Classes
{
    class SimpleClass
    {
        private int number; // Private Member variable

        public int Number // Public readonly Property
        {
            get { return number; }
        }

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
