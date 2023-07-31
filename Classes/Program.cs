using System;

namespace Classes
{
    class FirstClass
    {
        string text;

        public FirstClass(string text)
        {
            this.text = text;
        }

        public void SayHello()
        {
            Console.WriteLine(text);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // new creates a new object of type 'FirstClass'
            FirstClass firstClass = new FirstClass("Hello World");
            firstClass.SayHello();
            Console.WriteLine();

            // The following code uses a class defined in SimpleClass.cs:

            // New instance of SimpleClass, passing '1' to constructor:
            SimpleClass sc1 = new SimpleClass(1);
            sc1.WriteNumber();
            Console.WriteLine();

            // We let the class incrase the number and check the result:
            sc1.IncreaseNumber();
            sc1.WriteNumber();
            Console.WriteLine();

            // We declare 'alsoSc1', which links to the same object:
            SimpleClass alsoSc1 = sc1;
            alsoSc1.IncreaseNumber(); // Increasing number on alsoSc1
            sc1.WriteNumber(); // sc1 is affected
            Console.WriteLine();

            sc1 = null; // sc1 is set to null => not pointing to any object
            alsoSc1.WriteNumber(); // alsoSc1 still points to the object
            Console.WriteLine();

            SimpleClass.WriteSomething(); // Static member call, without object
            Console.WriteLine();

            // Private members are not accessible and will create compiler error
            // Try to uncomment the following lines:
            // sc1.number = 5;
            // sc1.PerformIncrease();
        }
    }

    
}
