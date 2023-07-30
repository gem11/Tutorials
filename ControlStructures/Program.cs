using System;

namespace ControlStructures
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IfElse(5);
            Console.WriteLine();

            Switch(2);
            Console.WriteLine();

            For(10);
            Console.WriteLine();

            While(6);
            Console.WriteLine();

            DoWhile(0);
            Console.WriteLine();
        }

        public static void IfElse(int number)
        {
            if (number < 5)
            {
                Console.WriteLine("number is smaller then 5");
            }
            else if (number > 5)
            {
                Console.WriteLine("number is bigger then 5");
            }
            else
            {
                Console.WriteLine("number should be 5");
            }
        }

        public static void Switch(int number)
        {
            switch(number)
            {
                case 1:
                    Console.WriteLine("It is ONE");
                    break;
                case 2:
                    Console.WriteLine("It is TWO");
                    break;
                case 3:
                    Console.WriteLine("It is THREE");
                    break;
                default:
                    Console.WriteLine("It is another number");
                    break;
            }

        }

        public static void For(int upTo)
        {
            int sum = 0;
            for(int i = 1; i <= upTo; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"Sum = {sum}");
        }

        public static void While(int upTo)
        {
            int sum = 1;
            while(sum < upTo)
            {
                sum = (sum + sum);
            }
            Console.WriteLine($"Sum = {sum}");
        }

        public static void DoWhile(int startFrom)
        {
            int sum = startFrom;
            do
            {
                sum = sum - 1;
            }
            while (sum > 0);
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
