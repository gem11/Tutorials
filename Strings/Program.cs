using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Hello World";

            Console.WriteLine(text);
            Console.WriteLine();

            string textWithNewLine = "Fist Line\nSecond Line";

            Console.WriteLine(textWithNewLine);
            Console.WriteLine();

            string escapedText = @"Text containing \n, but no new line";

            Console.WriteLine(escapedText);
            Console.WriteLine();

            int number = 20;
            string textWithPlaceholder = $"Number is {number}";

            Console.WriteLine(textWithPlaceholder);
            Console.WriteLine();

            string combinedText = "First Text" + " " + "Second Text";

            Console.WriteLine(combinedText);
            Console.WriteLine();


        }
    }
}
