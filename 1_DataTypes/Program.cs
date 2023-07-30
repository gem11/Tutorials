using System;

namespace _DataTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 15; // a 32 bit whole number

            float f = 7.5f; // a 32 bit floating pointing number (suffix ´f´)

            double d = 7.5; // a 64 bit floating point number

            bool b = true; // true or false

            int i2 = i + 10; // i2 = 25

            float f2 = 7.5f + 1; // f2 = 8.5

            double d2 = d + f; // d2 = 15, implicit conversion float -> double

            bool b2 = (i2 == 25);

            Console.WriteLine($"i = {i}, f = {f}, d = {d}, b = {b}, i2 = {i2}, f2 = {f2}, d2 = {d2}, b2 = {b2}");
            Console.WriteLine();
        }
    }
}
