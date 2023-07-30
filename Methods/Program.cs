using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteHelloWorld();

            int result = AddTwoNumbers(2, 3);
            Console.WriteLine($"2 + 3 = {result}");
            Console.WriteLine();

            int first;
            int second;
            GiveMeTwoNumbers(out first, out second);

            Console.WriteLine($"first = {first}, second = {second}");
            Console.WriteLine();

            int number = 6;
            Console.WriteLine($"number before = {number}");
            IncreaseNumber(ref number);
            Console.WriteLine($"number after = {number}");
        }

        public static void WriteHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public static int AddTwoNumbers(int first, int second)
        {
            int result = first + second;
            return result;
        }

        public static void GiveMeTwoNumbers(out int first, out int second)
        {
            first = 5;
            second = 10;
        }

        public static void IncreaseNumber(ref int number)
        {
            number = number + 1;
        }
    }
}
